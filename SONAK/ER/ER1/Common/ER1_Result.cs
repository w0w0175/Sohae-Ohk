using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ER1_Result : MonoBehaviour
{
    public static ER1_Result Instance;

    public GameObject Success;
    public GameObject Failure;
    public GameObject Icons;
    public GameObject NewRecordImg;

    public TMP_Text Maintext;
    public TMP_Text playTimeText;

    public GameObject ER1C1;
    public GameObject ER1C2;
    public GameObject ER1C3;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(Instance);
    }

    public void FailStatue()
    {
        Failure.SetActive(true);
    }

    public void SuccessStatue()
    {
        Icons.SetActive(false);
        Success.SetActive(true);
        SetBestRecord();

        Maintext.text = "";
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
        if (ER1_Timer.TimeEnd) // 타임오버
        {
            ER1_Timer.TimeEnd = false;
            SceneManager.LoadScene("ER1");
        }
        else
        {
            if (ER1C1.activeSelf == true)
            {
                if (ER1C1_MovingManager.Instance.er1c1)
                {
                    ER1C1_MovingManager.Instance.TimeStart();
                    if (ER1C1_MovingManager.Instance.returnfeed && ER1C1_MovingManager.Instance.forPB)
                    {
                        ER1C1_MovingManager.Instance.Bird_3_2_2();
                        ER1C1_MovingManager.Instance.returnfeed = false;
                        ER1C1_MovingManager.Instance.BirdAgain = true;
                    }
                    else if (ER1C1_MovingManager.Instance.forPB && ER1C1_MovingManager.Instance.returnfeed == false)
                    {
                        ER1C1_MovingManager.Instance.Bird_3_2_2();
                        ER1C1_MovingManager.Instance.honeytrue = true;
                        ER1C1_MovingManager.Instance.meattrue = true;
                        ER1C1_MovingManager.Instance.forHoney = true;
                        ER1C1_MovingManager.Instance.BearReSet = true;
                    }
                    else if (ER1C1_MovingManager.Instance.forCave && ER1C1_MovingManager.Instance.progress == 1)
                    {
                        ER1C1_MovingManager.Instance.CaveAgain();
                        ER1C1_MovingManager.Instance.honeytrue = true;
                        ER1C1_MovingManager.Instance.meattrue = true;
                        ER1C1_MovingManager.Instance.forMeat = true;
                        ER1C1_MovingManager.Instance.BearReSet = true;
                    }
                    else if (ER1C1_MovingManager.Instance.progress == 2)
                    {
                        ER1C1_QuizDragAndDrop.Instance.ResetGame();
                        ER1C1_MovingManager.Instance.CliffAgain();
                    }
                }
            }
            else if (ER1C2.activeSelf == true)
            {
                ER1C2_MoveManager.Instance.TimeStart();
                if (ER1C2_MoveManager.Instance.FailBox)
                {
                    ER1C2_MoveManager.Instance.BoxAgain();
                }
                else if (ER1C2_MoveManager.Instance.FailTree)
                {
                    ER1C2_MoveManager.Instance.TreeAgain();
                }
                else if (ER1C2_MoveManager.Instance.progress == 5)
                {
                    ER1_Manager.Instance.EnableHintButton(9);
                }
            }
            else if (ER1C3.activeSelf == true)
            {
                ER1C3_MoveManager.Instance.TimeStart();
                if (ER1C3_MoveManager.Instance.progress == 1)
                {
                    ER1C3_MoveManager.Instance.Q1Again();
                }
                else if (ER1C3_MoveManager.Instance.progress == 3)
                {
                    ER1C3_MoveManager.Instance.Q3Again();
                }
                else if (ER1C3_MoveManager.Instance.progress == 5)
                {
                    ER1C3_MoveManager.Instance.Q5Again();
                }
            }
        }
    }
}