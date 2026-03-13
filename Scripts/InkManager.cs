//INK의 대화를 Unity 씬에서 실제로 재생시켜줄 코드.

using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class InkManager : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSONAsset;

    [Header("시작할 노드 이름. 비워두기")]
    public static string startNode = "";

    [Header("UI 요소")]
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI speakerText;
    public Button nextButton;
    public Transform choiceButtonContainer;
    public Button choiceButtonPrefab;
    public Image speakerImage;
    public Image charImage;
    public Image dialogueImage;
    public Image dialoguedeco1;
    public Image dialoguedeco2;
    public GameObject characterRoot;
    public GameObject prob;

    [Header("배경이미지(없을시 투명한 이미지 삽입)")]
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;

    [Header("표정 처리")]
    public Image faceImage;
    public List<ExpressionSprite> expressionSprites;

    [Header("배경음악")]
    public AudioSource bgmSource;
    public AudioClip bgmClip;
    private bool bgmStarted = false;

    public static InkManager Instance { get; private set; }
    public Story story;
    public static UnityEngine.Events.UnityEvent OnDialogueEndEvent = new UnityEngine.Events.UnityEvent();

    private Coroutine typingCoroutine;
    private bool isTyping = false;
    private string currentText = "";
    private string currentSpeaker = "";
    private string previousSpeaker = "";
    private Dictionary<string, Sprite> expressionDict;

    [System.Serializable]
    public class ExpressionSprite
    {
        public string expressionName;
        public Sprite sprite;
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        expressionDict = new Dictionary<string, Sprite>();
        foreach (var pair in expressionSprites)
        {
            expressionDict[pair.expressionName.ToLower()] = pair.sprite;
        }
    }

    void Start()
    {
        if (nextButton != null)
        {
            nextButton.onClick.AddListener(OnClickNextButton);
        }

        if (inkJSONAsset != null)
        {
            story = new Story(inkJSONAsset.text);

            if (InkVariablesSaver.HasSavedState)
            {
                story.state.LoadJson(InkVariablesSaver.SavedState);
            }

            //INK에서 인식하는 변수를 Unity에서 인식하는 변수와 동기화시켜줘야 한다.
            story.variablesState["money"] = PlayerInfo.money;
            story.variablesState["strength"] = PlayerInfo.strength;
            story.variablesState["sociability"] = PlayerInfo.sociability;
            story.variablesState["intelligence"] = PlayerInfo.intelligence;
            story.variablesState["refinement"] = PlayerInfo.refinement;
            story.variablesState["appearance"] = PlayerInfo.appearance;

            //Debug.Log($"돈: {PlayerInfo.money}, 일차: {PlayerInfo.day}");

            /*
            foreach (var pair in PlayerInfo.affection)
                Debug.Log($"호감도 {pair.Key}: {pair.Value}");

            foreach (var pair in PlayerInfo.intimacy)
                Debug.Log($"친밀도 {pair.Key}: {pair.Value}");
                */
        }
        else
        {
            dialogueText.text = "";
        }

        //Startnode는 StartNodeSetter.cs에서 초기화된다.
        story.ChoosePathString(startNode);
        //Debug.Log(startNode + $"로 이동!");

        SetPlayerName();
        RefreshView();
    }

    public void SetPlayerName()
    {
        string fullName = PlayerInfo.lastName + PlayerInfo.firstName;
        story.variablesState["playerName"] = fullName;
        story.variablesState["Name"] = PlayerInfo.firstName;
    }

    public void RefreshView()
    {
        ClearChoices();
        /*
        PlayerInfo.money = (int)story.variablesState["money"];
        PlayerInfo.strength = (int)story.variablesState["strength"];
        PlayerInfo.sociability = (int)story.variablesState["sociability"];
        PlayerInfo.intelligence = (int)story.variablesState["intelligence"];
        PlayerInfo.refinement = (int)story.variablesState["refinement"];
        PlayerInfo.appearance = (int)story.variablesState["appearance"];
        */

        if (story.canContinue)
        {
            currentText = story.Continue().Trim();

            string speakerName = GetSpeakerFromTags(story.currentTags);
            if (string.IsNullOrEmpty(speakerName)) speakerName = previousSpeaker;

            if (speakerName == "Narr")
            {
                speakerText.gameObject.SetActive(false);
                speakerImage.gameObject.SetActive(false);
                speakerText.text = "";
            }
            else if (speakerName == "나")
            {
                speakerText.gameObject.SetActive(true);
                speakerImage.gameObject.SetActive(true);
                speakerText.text = PlayerInfo.lastName + PlayerInfo.firstName;
            }
            else
            {
                speakerText.gameObject.SetActive(true);
                speakerImage.gameObject.SetActive(true);
                speakerText.text = speakerName;
            }

            if (speakerName != currentSpeaker)
            {
                currentSpeaker = speakerName;
                previousSpeaker = currentSpeaker;
            }

            if (typingCoroutine != null)
                StopCoroutine(typingCoroutine);

            string waitTag = null;
            foreach (var tag in story.currentTags)
            {
                if (tag.StartsWith("wait:"))
                {
                    waitTag = tag.Substring("wait:".Length);
                    break;
                }
            }

            if (waitTag != null && float.TryParse(waitTag, out float waitTime))
            {
                DelayDialogue.Instance.StartWaitEvent(currentText, waitTime);
                return;
            }

            typingCoroutine = StartCoroutine(TypeText(currentText));
        }

        if (story.currentChoices.Count > 0)
        {
            nextButton.gameObject.SetActive(false);

            for (int i = 0; i < story.currentChoices.Count; i++)
            {
                Choice choice = story.currentChoices[i];
                Button choiceButton = Instantiate(choiceButtonPrefab, choiceButtonContainer);
                TextMeshProUGUI choiceText = choiceButton.GetComponentInChildren<TextMeshProUGUI>();
                Transform lockIcon = choiceButton.transform.Find("LockIcon");

                if (choice.text.StartsWith("LOCKED_"))
                {
                    if (choiceText != null) choiceText.text = "";
                    if (lockIcon != null) lockIcon.gameObject.SetActive(true);
                    choiceButton.interactable = false;
                }
                else
                {
                    if (choiceText != null) choiceText.text = choice.text;
                    if (lockIcon != null) lockIcon.gameObject.SetActive(false);
                    int choiceIndex = i;
                    choiceButton.onClick.AddListener(delegate { OnClickChoiceButton(choiceIndex); });
                }
            }
        }
        else
        {
            nextButton.gameObject.SetActive(true);
        }

        if (story.currentTags != null)
        {
            foreach (string tag in story.currentTags)
            {
                Debug.Log($"처리 중인 태그: {tag}");
                AffectionSystem.AdjustLevel(tag);

                //진행도 저장 부분
                if (tag.StartsWith("progress:"))
                {
                    string progressTag = tag.Substring("progress:".Length);
                    StoryProgress.ApplyProgress(progressTag);
                }
                else if (tag.StartsWith("ending:"))
                {
                    string ending = tag.Substring("ending:".Length);
                    if (ending == "bad1") SceneManager.LoadScene("(1)Bad_ending1");
                    else if (ending == "bad2") SceneManager.LoadScene("(1)Bad_ending2");
                    else if (ending == "bad3") SceneManager.LoadScene("(1)Bad_ending3");
                    else if (ending == "bad4") SceneManager.LoadScene("(1)Bad_ending4");
                    else if (ending == "bad5") SceneManager.LoadScene("(1)Bad_ending5");
                    else if (ending == "bad6") SceneManager.LoadScene("(2)Bad_ending6");
                    else if (ending == "bad7") SceneManager.LoadScene("(2)Bad_ending7");
                    else if (ending == "bad8") SceneManager.LoadScene("(3)Bad_ending8");
                    else if (ending == "bad9") SceneManager.LoadScene("(3)Bad_ending9");
                    else if (ending == "bad10") SceneManager.LoadScene("(3)Bad_ending10");
                    else if (ending == "bad11") SceneManager.LoadScene("(3)Bad_ending11");
                    else if (ending == "bad12") SceneManager.LoadScene("(3)Bad_ending12");
                    else if (ending == "bad13") SceneManager.LoadScene("(3)Bad_ending13");
                    else if (ending == "bad14") SceneManager.LoadScene("(3)Bad_ending14");
                    else if (ending == "bad15") SceneManager.LoadScene("(3)Bad_ending15");
                    else if (ending == "bad16") SceneManager.LoadScene("(3)Bad_ending16");
                    else if (ending == "bad17") SceneManager.LoadScene("(3)Bad_ending17");
                    else if (ending == "bad18") SceneManager.LoadScene("(3)Bad_ending18");
                    else if (ending == "bad19") SceneManager.LoadScene("(3)Bad_ending19");

                    else if (ending == "normal1") SceneManager.LoadScene("(3)Normal_Ending1");
                }

                if (tag.StartsWith("expression: "))
                {
                    string expression = tag.Substring("expression: ".Length).ToLower();
                    if (expressionDict.TryGetValue(expression, out Sprite newSprite))
                    {
                        faceImage.sprite = newSprite;
                    }
                    else if (expressionDict.TryGetValue("default", out Sprite defaultSprite))
                    {
                        faceImage.sprite = defaultSprite;
                    }
                }

                if (tag == "show")
                {
                    characterRoot.SetActive(true);
                    faceImage.gameObject.SetActive(true);
                    charImage.gameObject.SetActive(true);

                    if (!bgmStarted && bgmSource != null && bgmClip != null)
                    {
                        bgmSource.clip = bgmClip;
                        bgmSource.loop = true;
                        bgmSource.Play();
                        bgmStarted = true;
                    }
                }

                if (tag == "gone")
                {
                    characterRoot.SetActive(false);
                }

                if (tag.StartsWith("prob:"))
                {
                    string status = tag.Substring("prob:".Length);

                    if (status == "show") prob.SetActive(true);
                    else prob.SetActive(false);
                }

                if (tag.StartsWith("background:"))
                {
                    string bgNumber = tag.Substring("background:".Length);

                    if (bgNumber == "1")
                    {
                        background1.SetActive(true);
                        background2.SetActive(false);
                        background3.SetActive(false);
                    }
                    else if (bgNumber == "2")
                    {
                        background1.SetActive(false);
                        background2.SetActive(true);
                        background3.SetActive(false);
                    }
                    else
                    {
                        background1.SetActive(false);
                        background2.SetActive(false);
                        background3.SetActive(true);
                    }
                }
            }
        }

        if (!story.canContinue && story.currentChoices.Count == 0)
        {
            InkVariablesSaver.SavedState = story.state.ToJson();
            Debug.Log("다이얼로그 완료. 이벤트 호출!");
            OnDialogueEndEvent.Invoke();
        }
    }

    IEnumerator TypeText(string text)
    {
        isTyping = true;
        dialogueText.text = "";

        foreach (char c in text)
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(0.03f);
        }

        dialogueImage?.gameObject.SetActive(true);
        dialoguedeco1?.gameObject.SetActive(true);
        dialoguedeco2?.gameObject.SetActive(true);

        /*
        if (currentSpeaker == "Narr")
        {
            speakerText.gameObject.SetActive(false);
            speakerImage.gameObject.SetActive(false);
            speakerText.text = "";
        }
        else if (speakerName == "나")
        {
            speakerText.gameObject.SetActive(true);
            speakerImage.gameObject.SetActive(true);
            speakerText.text = PlayerInfo.lastName + PlayerInfo.firstName;
        }
        else
        {
            speakerText.text = currentSpeaker;
            speakerText.gameObject.SetActive(true);
            speakerImage.gameObject.SetActive(true);
        }
        */

        isTyping = false;
    }

    public void OnClickNextButton()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (!story.canContinue)
        {
            //이동할 씬 지정

            if (currentScene == "(1)hospital" || currentScene == "(1)pub" || currentScene == "(1)stream" || currentScene == "(1)Street1" || currentScene == "(1)street2")
                SceneManager.LoadScene("map");
            else if (currentScene == "day1Outro")
                SceneManager.LoadScene("day2Intro");
            else if (currentScene == "(2)hospital" || currentScene == "(2)pub" || currentScene == "(2)stream" || currentScene == "(2)street1" || currentScene == "(2)street2" || currentScene == "(2)farm")
                SceneManager.LoadScene("(2)map");
            else if (currentScene == "(3)hospital" || currentScene == "(3)pub" || currentScene == "(3)stream" || currentScene == "(3)street1" || currentScene == "(3)street2" || currentScene == "(3)farm")
                SceneManager.LoadScene("(3)map");
            else if (currentScene == "(4)pub" || currentScene == "(4)stream" || currentScene == "(4)street1" || currentScene == "(4)street2")
                SceneManager.LoadScene("(4)map");
        }
        else if (isTyping)
        {
            if (typingCoroutine != null) StopCoroutine(typingCoroutine);
            dialogueText.text = currentText;
            isTyping = false;
        }
        else
        {
            RefreshView();
        }
    }

    public void OnClickChoiceButton(int choiceIndex)
    {
        story.ChooseChoiceIndex(choiceIndex);
        RefreshView();
    }

    void ClearChoices()
    {
        foreach (Transform child in choiceButtonContainer)
        {
            Destroy(child.gameObject);
        }
    }

    string GetSpeakerFromTags(List<string> tags)
    {
        foreach (string tag in tags)
        {
            if (tag.StartsWith("speaker: "))
                return tag.Substring("speaker: ".Length);
        }
        return null;
    }

    public string GetInkStateJson()
    {
        return story.state.ToJson();
    }

    public void LoadInkState(string jsonState)
    {
        story.state.LoadJson(jsonState);
    }
}
