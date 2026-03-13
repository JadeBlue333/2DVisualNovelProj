//InkManager.cs와 같은역할 but 두 캐릭터와 삼자대면으로 이야기할때의 InkManager역할
//먼저 이야기하는 사람을 1로 설정해야한다.
//오른쪽으로 밀려나가는 애니메이션 필요

using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Multi_InkManager : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSONAsset;

    [Header("StartNode")]
    public static string startNode = "";

    [Header("UI")]
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI speakerText;
    public Button nextButton;
    public Transform choiceButtonContainer;
    public Button choiceButtonPrefab;
    public Image speakerImage;
    public Image dialogueImage;
    public Image dialoguedeco1;
    public Image dialoguedeco2;
    public GameObject prob;

    [Header("배경")]
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;

    [Header("캐릭터1")]
    public GameObject characterRoot1;
    public Image charImage1;
    public Image faceImage1;
    public List<ExpressionSprite> expressionSprites1;
    private Dictionary<string, Sprite> expressionDict1;

    [Header("캐릭터2")]
    public GameObject characterRoot2;
    public Image charImage2;
    public Image faceImage2;
    public List<ExpressionSprite> expressionSprites2;
    private Dictionary<string, Sprite> expressionDict2;

    [Header("애니메이션")]
    public Animator character1Animator;
    private bool hasPlayedPushAnimation = false;

    [Header("브금")]
    public AudioSource bgmSource;
    public AudioClip bgmClip;
    private bool bgmStarted = false;

    public static Multi_InkManager Instance { get; private set; }
    public Story story;
    public static UnityEngine.Events.UnityEvent OnDialogueEndEvent = new UnityEngine.Events.UnityEvent();

    private Coroutine typingCoroutine;
    private bool isTyping = false;
    private string currentText = "";
    private string currentSpeaker = "";
    private string previousSpeaker = "";

    [System.Serializable]
    public class ExpressionSprite
    {
        public string expressionName;
        public Sprite sprite;
    }
    
    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        expressionDict1 = new Dictionary<string, Sprite>();
        foreach (var pair in expressionSprites1)
            expressionDict1[pair.expressionName.ToLower()] = pair.sprite;

        expressionDict2 = new Dictionary<string, Sprite>();
        foreach (var pair in expressionSprites2)
            expressionDict2[pair.expressionName.ToLower()] = pair.sprite;
    }
    
    void Start()
    {
        if (nextButton != null)
            nextButton.onClick.AddListener(OnClickNextButton);

        if (inkJSONAsset != null)
        {
            story = new Story(inkJSONAsset.text);
        }
        else
        {
            dialogueText.text = "";
            return;
        }

        story.ChoosePathString(startNode);
        SetPlayerVariable();
        RefreshView();
    }

    public void SetPlayerVariable()
    {
        /*
        if (InkVariablesSaver.HasSavedState)
            story.state.LoadJson(InkVariablesSaver.SavedState);
        */
        string fullName = PlayerInfo.lastName + PlayerInfo.firstName;
        story.variablesState["playerName"] = fullName;
        story.variablesState["Name"] = PlayerInfo.firstName;
        //INK에서 인식하는 변수를 Unity에서 인식하는 변수와 동기화시켜줘야 한다.
        story.variablesState["money"] = PlayerInfo.money;
        story.variablesState["strength"] = PlayerInfo.strength;
        story.variablesState["sociability"] = PlayerInfo.sociability;
        story.variablesState["intelligence"] = PlayerInfo.intelligence;
        story.variablesState["refinement"] = PlayerInfo.refinement;
        story.variablesState["appearance"] = PlayerInfo.appearance;
    }

    public void RefreshView()
    {
        ClearChoices();

        if (story.canContinue)
        {
            currentText = story.Continue().Trim();

            string speakerName = GetSpeakerFromTags(story.currentTags);
            if (string.IsNullOrEmpty(speakerName))
                speakerName = previousSpeaker;

            if (speakerName == "Narr")
            {
                speakerText.gameObject.SetActive(false);
                speakerImage.gameObject.SetActive(false);
            }
            else
            {
                speakerText.gameObject.SetActive(true);
                speakerImage.gameObject.SetActive(true);
                speakerText.text = speakerName == "��"
                    ? PlayerInfo.lastName + PlayerInfo.firstName
                    : speakerName;
            }

            previousSpeaker = speakerName;

            if (typingCoroutine != null)
                StopCoroutine(typingCoroutine);

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
        
        foreach (string tag in story.currentTags)
        {
            if (tag.StartsWith("show:"))
            {
                string charNum = tag.Substring("show:".Length);

                if (charNum == "1")
                {
                    characterRoot1.SetActive(true);

                    if (!bgmStarted && bgmSource != null && bgmClip != null)
                    {
                        bgmSource.clip = bgmClip;
                        bgmSource.loop = true;
                        bgmSource.Play();
                        bgmStarted = true;
                    }
                }
                else if (charNum == "2")
                {
                    characterRoot2.SetActive(true);

                    if (!hasPlayedPushAnimation && characterRoot1.activeSelf)
                    {
                        character1Animator.SetTrigger("PushRight");
                        hasPlayedPushAnimation = true;
                    }
                }
            }

            if (tag.StartsWith("gone:"))
            {
                string charNum = tag.Substring("gone:".Length);

                if (charNum == "1")
                    characterRoot1.SetActive(false);
                else if (charNum == "2")
                    characterRoot2.SetActive(false);
            }

            if (tag.StartsWith("expression:"))
            {
                string data = tag.Substring("expression:".Length).Trim();
                string[] split = data.Split(' ');

                if (split.Length >= 2)
                {
                    string charNum = split[0];
                    string expression = split[1].ToLower();

                    if (charNum == "1" && expressionDict1.TryGetValue(expression, out Sprite sprite1))
                        faceImage1.sprite = sprite1;

                    else if (charNum == "2" && expressionDict2.TryGetValue(expression, out Sprite sprite2))
                        faceImage2.sprite = sprite2;
                }
            }

            if (tag.StartsWith("background:"))
            {
                string bgNumber = tag.Substring("background:".Length);

                background1.SetActive(bgNumber == "1");
                background2.SetActive(bgNumber == "2");
                background3.SetActive(bgNumber == "3");
            }

            if (tag.StartsWith("progress:"))
            {
                string progressTag = tag.Substring("progress:".Length);
                StoryProgress.ApplyProgress(progressTag);
            }
            else if (tag.StartsWith("ending:"))
            {
                string ending = tag.Substring("ending:".Length);
                if (ending == "bad20") SceneManager.LoadScene("(3)Bad_ending20");
                else if (ending == "bad21") SceneManager.LoadScene("(3)Bad_ending21");
                else if (ending == "bad22") SceneManager.LoadScene("(3)Bad_ending22");
                else if (ending == "bad23") SceneManager.LoadScene("(3)Bad_ending23");
                else if (ending == "bad24") SceneManager.LoadScene("(3)Bad_ending24");
                else if (ending == "bad25") SceneManager.LoadScene("(4)Bad_ending25");
                else if (ending == "bad26") SceneManager.LoadScene("(4)Bad_ending26");
                else if (ending == "bad27") SceneManager.LoadScene("(4)Bad_ending27");
                else if (ending == "bad28") SceneManager.LoadScene("(4)Bad_ending28");
                else if (ending == "bad29") SceneManager.LoadScene("(4)Bad_ending29");
            }
        }

        if (!story.canContinue && story.currentChoices.Count == 0)
        {
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

        isTyping = false;
    }

    public void OnClickNextButton()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (!story.canContinue)
        {

            if (currentScene == "(4)pub" || currentScene == "(4)stream" || currentScene == "(4)street1" || currentScene == "(4)street2")
                SceneManager.LoadScene("(4)map");
            else if (currentScene == "(3)farm")
                SceneManager.LoadScene("(3)map");
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
            Destroy(child.gameObject);
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
}
