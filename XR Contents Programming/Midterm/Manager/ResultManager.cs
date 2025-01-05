using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    public GameObject Fail;
    public GameObject Success;
    public GameObject next;

    public Text Btntxt;

    int num;
    void Start()
    {
        next.SetActive(true);
        NextInfo();

        if (ProgressManager.fail_game) //타이머가 끝났을 경우 bool값을 받아옴
        {
            ProgressManager.fail_game = false;
            Fail.SetActive(true);
            Btntxt.text = "으아~ 해가 져버렸어~";
            
        }
        else //성공했을 경우
        {
            Success.SetActive(true);
            Btntxt.text = "와~ 덕분에 무사히 집에 도착했어";
        }
    }

    public void OnClickButton() //대화창 클릭시 진행 함수
    {
        if (Fail.activeSelf) //실패일 경우
        {
            switch (num)
            { 
                case 0:
                    Btntxt.text = "깜깜해서 길을 못 찾겠어";
                    num++;                   
                    break;

                case 1:
                    Btntxt.text = "오늘은 집에 못 가겠다..";
                    num++;
                    break;

                case 2:
                    Btntxt.text = "다시하기";
                    next.SetActive(false);
                    num++;
                    break;

                case 3:
                    num = 0;
                    SceneManager.LoadScene("GameScene");
                    break;
            }
        }
        else if (Success.activeSelf) //성공일 경우
        {
            switch (num)
            {
                case 0:
                    Btntxt.text = "너무 고마워! 다음에 또 놀러와!";
                    num++;
                    break;

                case 1:
                    Btntxt.text = "다시하기";
                    next.SetActive(false);
                    num++;
                    break;

                case 2:
                    num = 0;
                    SceneManager.LoadScene("StartScene");
                    break;
            }
        }
    }


    void NextInfo()
    {
        Color col = next.GetComponent<Image>().color;
        col.a = 0.0f;
        next.GetComponent<Image>().color = col;

        Invoke("NextInvisible", 0.4f);
    }

    void NextInvisible()
    {
        Color col = next.GetComponent<Image>().color;
        col.a = 1.0f;
        next.GetComponent<Image>().color = col;

        Invoke("NextInfo", 0.4f);
    }
}
