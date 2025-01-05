using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressManager : MonoBehaviour
{
    static public ProgressManager instance;

    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Explanation;
    public GameObject NextBtn;
    public GameObject CurrentE;
    public GameObject Ani_Pro;
    public GameObject Ani_Background;
    public GameObject Timer;

    public Sprite fruit;
    public Sprite fish;
    public Sprite fight;
    public Sprite maze;
    public Sprite b_fishing;
    public Sprite cat;
    public Sprite squ;

    public Text ExT;
    public Text CurrentT;
    public Text TimerT;

    public Image Img_timer;
    

    public static bool fail_game;

    int num;
    int minute;
    int second;

    float LimitTime;

    void Start()
    {
        LimitTime = 120;

        if (instance == null)
            instance = this;

           Stage1.SetActive(true);
           Stage2.SetActive(false);
           Stage3.SetActive(false);

        CurrentE.GetComponent<Image>().sprite = fruit;
        fail_game = false;
    }

    void Update()
    {
       if (Timer.activeSelf) //타이머기능
        {
            LimitTime -= Time.deltaTime;
            minute = (int)LimitTime / 60;
            second = (int)LimitTime % 60;
            TimerT.text = minute.ToString("00") + " : " + second.ToString("00"); // 00:00 형태로 출력

            if (LimitTime <= 0.01f) //타이머가 끝났을 경우
            {
                fail_game = true;
                ToResult();
            }
        }
       else
        {

        }
    }

    public void TimerStart()
    {
        Timer.SetActive(true);
    }

    public void PopupMsg(string msg, int time)
    {
        StartCoroutine(ShowMsg(msg, time));
    }

    IEnumerator ShowMsg(string msg, int time)
    {
        if (Explanation.activeSelf == false)
        {
            Explanation.SetActive(true);
        }
        ExT.text = msg;
        Explanation.GetComponent<Image>().raycastTarget = false;
        yield return new WaitForSeconds(time);
        ExT.text = "";
        Explanation.GetComponent<Image>().raycastTarget = true;
        Explanation.SetActive(false);
    }

    public void ToNext() //다음 스테이지로 진행하기 위한 중간 단계
    {
        if (Stage1.activeSelf) //스테이지 1이 켜져있을 경우 끄고, 짧은 진행 시작
        {
            CurrentE.SetActive(false);
            Stage1.SetActive(false);
            Timer.SetActive(false);

            Ani_Pro.SetActive(true);
            Explanation.SetActive(true);
            ExT.text = "와 과일을 다 모았네!";
            NextBtn.SetActive(true);
            NextInfo();

            Ani_Background.GetComponent<Image>().sprite = maze;
        }
        else if (Stage2.activeSelf) //스테이지 2가 켜져있을 경우 끄고, 짧은 진행 시작
        {
            CurrentE.SetActive(false);
            Stage2.SetActive(false);
            Timer.SetActive(false);

            Ani_Pro.SetActive(true);
            Explanation.SetActive(true);
            ExT.text = "야호 물고기도 다 잡았어!";
            NextBtn.SetActive(true);
            NextInfo();

            Ani_Background.GetComponent<Image>().sprite = b_fishing;
        }
        else if (Stage3.activeSelf) //스테이지 3이 켜져있을 경우
        {
            Stage3.SetActive(false);
            Timer.SetActive(false);

            ToResult();
        }
    }

    public void OnClickButton() //진행 중 뜨는 대화창 클릭 시
    {
        if (Ani_Background.GetComponent<Image>().sprite == maze) //스테이지가 꺼졌으므로 켜진 Animation의 배경으로 구분
        {
            switch (num)
            {
                case 0:
                    ExT.text = "이제 물고기를 잡으러 가자!";
                    num++;
                    break;

                case 1:
                    ExT.text = "물고기는 처음 잡아보지?\n아마 놓칠 수도 있을 거 같아";
                    num++;
                    break;

                case 2:
                    ExT.text = "그래도 열심히 잡아보자구!";
                    num++;
                    break;

                case 3:
                    ExT.text = "";
                    Ani_Pro.SetActive(false);
                    Explanation.SetActive(false);
                    NextBtn.SetActive(false);

                    Stage2.SetActive(true);
                    CurrentE.SetActive(true);
                    CurrentE.GetComponent<Image>().sprite = fish;
                    num = 0;
                    break;
            }
        }
        else if (Stage3.activeSelf == false && Ani_Background.GetComponent<Image>().sprite == b_fishing)
        {
            switch (num)
            {
                case 0:
                    ExT.text = "이제 집으로 돌아가자!";
                    num++;
                    break;

                case 1:
                    ExT.text = "어? 근데 저기 누가 서 있네";
                    num++;
                    break;

                case 2:
                    ExT.text = "한 번 가서 말 걸어볼까?";
                    num++;
                    break;

                case 3:
                    ExT.text = "";
                    Ani_Pro.SetActive(false);
                    Explanation.SetActive(false);
                    NextBtn.SetActive(false);

                    Stage3.SetActive(true);
                    num = 0;
                    break;
            }
        }
        else if (Stage3.activeSelf)
        {
            switch (num)
            {
                case 0:
                    ExT.text = "응 여기가 내 집이야";
                    Explanation.GetComponent<Image>().sprite = squ;
                    num++;
                    break;

                case 1:
                    ExT.text = "그래서 여기 지나가려면\n나랑 가위바위보 해서 이겨야해";
                    Explanation.GetComponent<Image>().sprite = squ;
                    num++;
                    break;

                case 2:
                    ExT.text = "뭐? 그런 게 어딨어!";
                    Explanation.GetComponent<Image>().sprite = cat;
                    num++;
                    break;

                case 3:
                    ExT.text = "맘대로 해\n난 안 비켜줄 거니까";
                    Explanation.GetComponent<Image>().sprite = squ;
                    num++;
                    break;

                case 4:
                    ExT.text = "";
                    Explanation.GetComponent<Image>().sprite = cat;
                    Explanation.SetActive(false);
                    NextBtn.SetActive(false);

                    TimerStart();
                    Stage3Manager.instance.StartRockScissorsPaper();
                    num = 0;
                    break;
            }
        }
    }

    public void StartStage3()
    {
        NextBtn.SetActive(true);
        NextInfo();
        ExT.text = "안녕! 너도 이 동네에 사니?";
    }

    public void NextInfo() //대화창에 화살표 깜빡이는 효과를 위한 코드
    {
        Color col = NextBtn.GetComponent<Image>().color;
        col.a = 0.0f;
        NextBtn.GetComponent<Image>().color = col;

        Invoke("NextInvisible", 0.4f);
    }

    public void NextInvisible() //대화창에 화살표 깜빡이는 효과를 위한 코드
    {
        Color col = NextBtn.GetComponent<Image>().color;
        col.a = 1.0f;
        NextBtn.GetComponent<Image>().color = col;

        Invoke("NextInfo", 0.4f);
    }

    void ToResult()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
