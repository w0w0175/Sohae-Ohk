using UnityEngine;
using UnityEngine.UI;

public class Stage2Manager : MonoBehaviour
{
    static public Stage2Manager instance;

    public GameObject statusE;
    public GameObject RodO;

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
        RodO.SetActive(false);

        CurrentT.text = "잡은 물고기 수 " + numCatch + "/" + maxCatch;
    }

    public void AddCatch() //잡은 물고기 수 처리하는 함수
    {
        ++numCatch;
        CurrentT.text = "잡은 물고기 수 " + numCatch + "/" + maxCatch;

        if (numCatch < maxCatch)
        {
            if (numCatch == 2)
            {
                ProgressManager.instance.PopupMsg("이제 한 마리만 더 잡으면 돼!", 2);
            }
            else
            {
                ProgressManager.instance.PopupMsg("와! 잡았다!", 2);
            }
        }
        else
        {
            ProgressManager.instance.ToNext();
        }
    }

    public void OnDetected() //카드 인식됐을 때 실행되는 함수
    {
        ProgressManager.instance.TimerStart();
        RodO.SetActive(true);
        ProgressManager.instance.PopupMsg("드래그 해서 바구니를 던지세요", 1);
    }
}
