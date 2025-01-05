using UnityEngine;
using UnityEngine.UI;

public class Stage1Manager : MonoBehaviour
{
    static public Stage1Manager instance;

    public GameObject statusE;

    public Text statusText;
    public Text CurrentT;
    public int maxCatch;
    int numCatch = 0;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        statusE.SetActive(true);
        statusText.text = "카드를 인식시켜 주세요";

        CurrentT.text = "획득한 과일 수 " + numCatch + "/" + maxCatch;
    }

    public void AddCatch() //과일을 획득했을 시
    {
        ++numCatch;
        CurrentT.text = "획득한 과일 수 " + numCatch + "/" + maxCatch;

        if (numCatch < maxCatch)
        {
            ProgressManager.instance.PopupMsg("우와 맛있겠다!", 1);
        }
        else
        {
            ProgressManager.instance.PopupMsg("과일을 다 모았네\n이제 숲 밖으로 나가자", 1);
        }
    }

    public void OnDetected() //카드가 인식됐을 때 타이머 시작, 게임 플레이 설명
    {
        ProgressManager.instance.TimerStart();
        ProgressManager.instance.PopupMsg("상하좌우키를 이용해\n과일을 수집하세요", 1);
    }
}
