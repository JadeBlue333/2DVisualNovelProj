//시작 버튼 누르면 inspector에서 입력한 이름과 일치하는 이름의 씬으로 이동
//targetStartNode에서 이야기 시작하도록 변수를 초기화해준다.
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNodeSetter : MonoBehaviour
{
    public string inkSceneName;
    public string targetStartNode;

    public void StartInkScene()
    {
        InkManager.startNode = targetStartNode;
        Multi_InkManager.startNode = targetStartNode;
        //재생되던 음악 없애기
        GameObject bgm = GameObject.Find("BGM");
        if (bgm != null)
        {
            Destroy(bgm);
        }
        //다 끝난 후에 씬 로드
        SceneManager.LoadScene(inkSceneName);
    }
}
