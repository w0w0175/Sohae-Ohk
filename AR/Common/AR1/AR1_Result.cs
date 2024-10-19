using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AR1_Result : MonoBehaviour
{
    public static AR1_Result Instance;

    public GameObject Icons;
    public GameObject Success;
    public GameObject Failure;
    public GameObject NewRecordImg;

    public TMP_Text Maintext;
    public TMP_Text playTimeText;

    public GameObject AR1C0;
    public GameObject AR1C1;
    public GameObject AR1C2;
    public GameObject AR1C3;
    public GameObject AR1C4;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void FailStatue()
    {
        Icons.SetActive(false);
        Failure.SetActive(true);
    }

    public void SuccessStatue()
    {
        Icons.SetActive(false);
        Success.SetActive(true);
        Maintext.text = "";

        SetBestRecord();
    }
    void SetBestRecord()
    {
        float currTimeRecord = TimeManager.instance.GetTime();
        float prevTimeRecord = DataController.instance.LoadTimeRecord();

        if (currTimeRecord < prevTimeRecord)
        {
            NewRecordImg.SetActive(true);
            DataController.instance.SaveTimeRecord(currTimeRecord);
        }

        playTimeText.text = $"{(int)currTimeRecord / 60}분 {(int)currTimeRecord % 60}초";
    }
    public void ToMain()
    {
        GameManager.instance.ExitChapter(true);
    }

    public void Clicktryagain()
    {
        Failure.SetActive(false);
        Icons.SetActive(true);
        if (AR1_Timer.TimeEnd) // 타임오버
        {
            AR1_Timer.TimeEnd = false;
            SceneManager.LoadScene("AR1");
        }
        else
        {
            if (AR1C1.activeSelf == true)
            {
                AR1C1_MovingManager.Instance.TimeStart();
                if (AR1C1_MovingManager.Instance.Q2Fail)
                {
                    AR1C1_MovingManager.Instance.Q2Fail = false;
                    AR1C1_MovingManager.Instance.ReturnBooks();
                    AR1_Manager.Instance.EnableHintButton(7);
                }
                else if (AR1C1_MovingManager.Instance.progress == 4)
                {
                    AR1C1_MovingManager.Instance.ReturntoQ4();
                }
                else if (AR1C1_MovingManager.Instance.progress == 5)
                {
                    AR1_Manager.Instance.EnableHintButton(9);
                }
            }
            else if (AR1C2.activeSelf == true)
            {
                AR1C2_MovingManager.Instance.TimeStart();
                if (AR1C2_MovingManager.Instance.forQ1)
                {
                    AR1C2_MovingManager.Instance.Q1_Again();
                }
                else if (AR1C2_MovingManager.Instance.forQ2point5)
                {
                    AR1C2_MovingManager.Instance.forQ2point5 = false;
                    AR1C2_MovingManager.Instance.Q2_Choice2();
                    AR1C2_MovingManager.Instance.ARBlackSeating();
                }
                else if (AR1C2_MovingManager.Instance.progress == 2)
                {
                    AR1C2_MovingManager.Instance.AR1C2_Q2Again();
                }
                else if (AR1C2_MovingManager.Instance.progress == 3)
                {
                    AR1C2_MovingManager.Instance.AR1C2_Q3Again();
                }
                else if (AR1C2_MovingManager.Instance.progress == 4)
                {
                    AR1C2_MovingManager.Instance.AR1C2_Q4Again();
                }
                else if (AR1C2_MovingManager.Instance.progress == 5)
                {
                    AR1C2_MovingManager.Instance.AR1C2_Q5Start();
                }
            }
            else if (AR1C3.activeSelf == true)
            {
                AR1C3_MoveManager.Instance.TimeStart();
                if (AR1C3_MoveManager.Instance.progress == 1)
                {
                    AR1C3_MoveManager.Instance.ReturnQ1();
                }
                else if (AR1C3_MoveManager.Instance.progress == 3)
                {
                    AR1C3_MoveManager.Instance.Quiz3Cancel();
                    AR1C3_MoveManager.Instance.ReturnQ3();
                    AR1C3_MoveManager.Instance.Quiz3_3();
                }
                else if (AR1C3_MoveManager.Instance.progress == 4)
                {
                    AR1C3_MoveManager.Instance.ReturnQ4();
                    AR1C3_MoveManager.Instance.Quiz4Start();
                    AR1_Block.UsingItem = false;
                }
                else if (AR1C3_MoveManager.Instance.progress == 5)
                {
                    AR1C3_MoveManager.Instance.ReturnQ5();
                }
            }

            else if (AR1C0.activeSelf == true)
            {
                AR1C0_MoveManager.Instance.TimeStart();
                if (AR1C0_MoveManager.Instance.progress == 1 || AR1C0_MoveManager.Instance.progress == 0)
                {
                    AR1C0_MoveManager.Instance.FilesAgain();
                }
                else if (AR1C0_MoveManager.Instance.progress == 2)
                {
                    AR1C0_MoveManager.Instance.ClickQuiz2Back();
                }
                else if (AR1C0_MoveManager.Instance.progress == 3)
                {
                    AR1C0_MoveManager.Instance.BlackboardAgain();
                    AR1C0_BlackboardManager.Instance.PlayAgain();
                }
                else if (AR1C0_MoveManager.Instance.progress == 4)
                {
                    AR1C0_MoveManager.Instance.Q4Again();
                }
                else if (AR1C0_MoveManager.Instance.progress == 5)
                {
                    AR1_Manager.Instance.EnableHintButton(5);
                }
            }
            else if (AR1C4.activeSelf == true)
            {
                AR1C4_MoveManager.Instance.TimeStart();
                if (AR1C4_MoveManager.Instance.progress == 1)
                {
                    AR1C4_MoveManager.Instance.InstAgain();
                }
                else if (AR1C4_MoveManager.Instance.progress == 2)
                {
                    AR1C4_MoveManager.Instance.MenuAgain();
                }
                else if (AR1C4_MoveManager.Instance.progress == 4)
                {
                    AR1C4_MoveManager.Instance.Door2Again();
                }
            }
        }
    }
}