using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartManager : MonoBehaviour
{
    public GameObject background;
    public GameObject next;
    public Text statetext;

    int num;
    void Start()
    {
        statetext.text = "카드를 인식하면 게임이 시작됩니다";
        num = 0;
    }

    public void CharacterOn() //카드가 인식됐을 때
    {
        background.SetActive(true);
        statetext.text = "안녕! 만나서 반가워\n난 오늘 여기로 이사 왔어";
        next.SetActive(true);
        NextInfo();
        num++;
    }

    public void OnClickButton() //대화창 진행
    {
        switch (num)
        {
            case 1: statetext.text = "그래서 그런데, 나랑 같이\n먹을 걸 구하러 가줄 수 있을까?";
                num++;
                break;

            case 2:
                statetext.text = "여기 길을 잘 몰라서.. \n해 지기 전에 돌아와야 할 거 같아";
                num++;
                break;

            case 3:
                statetext.text = "먼저 과일을 구하러\n가고 싶은데 괜찮지?";
                num++;
                break;

            case 4:
                statetext.text = "3개 정도면 충분할 거 같아!";
                num++;
                break;

            case 5:
                statetext.text = "그럼 출발~";
                num++;
                break;

            case 6:
                SceneManager.LoadScene("GameScene");
                break;
        }

    }

    public void NextInfo()
    {
        Color col = next.GetComponent<Image>().color;
        col.a = 0.0f;
        next.GetComponent<Image>().color = col;

        Invoke("NextInvisible", 0.4f);
    }

    public void NextInvisible()
    {
        Color col = next.GetComponent<Image>().color;
        col.a = 1.0f;
        next.GetComponent<Image>().color = col;

        Invoke("NextInfo", 0.4f);
    }
}
