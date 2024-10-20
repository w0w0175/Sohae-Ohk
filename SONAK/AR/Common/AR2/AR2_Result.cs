using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AR2_Result : MonoBehaviour
{
    public static AR2_Result Instance;

    public GameObject Success;
    public GameObject Failure;

    public GameObject NewRecordImg;

    public TMP_Text Maintext;
    public TMP_Text playTimeText;

    public GameObject AR2C1;
    public GameObject AR2C2;
    public GameObject AR2C3;
    public GameObject AR2C4;
    public GameObject AR2C5;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void FailStatue()
    {
        Failure.SetActive(true);
    }

    public void SuccessStatue()
    {
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

        if (AR2_Timer.TimeEnd) // 타임오버
        {
            AR2_Timer.TimeEnd = false;
            SceneManager.LoadScene("AR2");
        }
        else
        {
            if (AR2C1.activeSelf == true)
            {
                if (AR2C1_MovingManager.Instance.ar2c1)
                {
                    AR2C1_MovingManager.Instance.ReturnMap();
                    AR2C1_MovingManager.Instance.TimeStart();
                }
            }
            else if (AR2C2.activeSelf == true)
            {
                if (AR2C2_MoveManager.Instance.ar2c2)
                {
                    AR2C2_MoveManager.Instance.TimeStart();
                    if (AR2C2_MoveManager.Instance.progress == 1)
                    {
                        AR2C2_MoveManager.Instance.ReturnQ1();
                    }
                    if (AR2C2_MoveManager.Instance.progress == 2)
                    {
                        AR2C2_MoveManager.Instance.ReturnQ2();
                    }
                    if (AR2C2_MoveManager.Instance.progress == 3)
                    {
                        AR2C2_MoveManager.Instance.ReturnQ3();
                    }
                    if (AR2C2_MoveManager.Instance.progress == 5)
                    {
                        AR2C2_MoveManager.Instance.ReturnQ5();
                    }
                }
            }
            else if (AR2C3.activeSelf == true)
            {
                if (AR2C3_MoveManager.Instance != null)
                {
                    SceneManager.LoadScene("AR2");
                }
            }
            else if (AR2C4.activeSelf == true)
            {
                if (AR2C4_MoveManager.Instance.ar2c4)
                {
                    AR2C4_MoveManager.Instance.TimeStart();
                    if (AR2C4_MoveManager.Instance.IsMaid && (AR2C4_MoveManager.Instance.progress == 1 || AR2C4_MoveManager.Instance.progress == 2))
                    {
                        AR2C4_MoveManager.Instance.CriminalAgain();
                    }
                    if (AR2C4_MoveManager.Instance.GodING && (AR2C4_MoveManager.Instance.progress == 1 || AR2C4_MoveManager.Instance.progress == 2))
                    {
                        AR2C4_MoveManager.Instance.GodAgain();
                    }
                    if (AR2C4_MoveManager.Instance.progress == 3)
                    {
                        AR2C4_MoveManager.Instance.Q3Return();
                    }
                    if (AR2C4_MoveManager.Instance.progress == 4)
                    {
                        AR2C4_MoveManager.Instance.Quiz4Start();
                    }
                    if (AR2C4_MoveManager.Instance.progress == 5)
                    {
                        AR2C4_MoveManager.Instance.Quiz5Start();
                    }
                }
            }
            else if (AR2C5.activeSelf == true)
            {
                if (AR2C5_MoveManager.Instance != null)
                {
                    AR2C5_MoveManager.Instance.TimeStart();
                    if (AR2C5_MoveManager.Instance.FailRight)
                    {
                        AR2C5_MoveManager.Instance.FailRight = false;
                        AR2C5_MoveManager.Instance.RightAgain();
                    }
                    else if (AR2C5_MoveManager.Instance.FailLeft)
                    {
                        AR2C5_MoveManager.Instance.FailLeft = false;
                        AR2C5_MoveManager.Instance.LeftAgain();
                    }
                    else if (AR2C5_MoveManager.Instance.FailCup)
                    {
                        AR2C5_MoveManager.Instance.FailCup = false;
                        AR2C5_MoveManager.Instance.CupAgain();
                    }
                    else if (AR2C5_MoveManager.Instance.progress == 5)
                    {
                        AR2C5_MoveManager.Instance.LastClickEvent();
                    }
                }
            }
        }
    }
}