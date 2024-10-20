using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AR1C0_MoveManager : MonoBehaviour
{
    public static AR1C0_MoveManager Instance;
    public Timer timer;

    public TMP_InputField InputField;
    public TMP_Text MainText;

    public GameObject Arrow;
    public GameObject Arrow_L;
    public GameObject Arrow_R;
    public GameObject ClickEvent;
    public GameObject Files_C;
    public GameObject Picture_C;
    public GameObject Profile_C;
    public GameObject Blackboard_C;
    public GameObject Typer_C;
    public GameObject Black;
    public GameObject Files_B;
    public GameObject Files_Ex;
    public GameObject Files_R;
    public GameObject Files_Enter;
    public GameObject Files_Contents;
    public GameObject Files_C1;
    public GameObject Files_C2;
    public GameObject Files_C3;
    public GameObject Files_C4;
    public GameObject Files_Back;
    public GameObject Files_Next;
    public GameObject Files_Answer;
    public GameObject Note_Big;
    public GameObject Note_Content;
    public GameObject Note_Close;
    public GameObject RedArrow;
    public GameObject Quiz2;
    public GameObject Quiz2_BG;
    public GameObject Q2_A1;
    public GameObject Q2_A2;
    public GameObject Q2_A3;
    public GameObject Quiz2_E1;
    public GameObject Quiz2_E2;
    public GameObject Quiz2_E3;
    public GameObject Quiz2_Submit;
    public GameObject Quiz2_Back;
    public GameObject Pictures;
    public GameObject BlackboardBG;
    public GameObject Blackboard_pics;
    public GameObject BlackboardBtn;
    public GameObject BlackboardClose;
    public GameObject BB_Lines;
    public GameObject SuspectPf;
    public GameObject SuspectN;
    public GameObject Quiz4;
    public GameObject Q4Image;
    public GameObject Q4Left;
    public GameObject Q4Right;
    public GameObject Quiz5;
    public GameObject block;

    public Sprite Q4_1;
    public Sprite Q4_2;
    public Sprite Q4_3;
    public Sprite Q4_4;

    public bool IsUsed = false;
    public bool BlackEnd = false;
    public bool GetNote = false;
    
    public int ForBB = 0;
    public int progress = 0;
    public int ForQuiz2 = 0;
    public int usepic = 0;

    bool BG_2;
    bool FileEnd = false;
    bool Profilefirst = false;
    bool directyper = false;
    bool arrow = false;
    bool file4 = false;

    int ForFiles = 0;
    int ForSuspect = 0;
    int[] AR1C0_time = new int[] { 9, 0 };

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        BG_2 = true;
        progress = 0;
    }
    void OnDisable()
    {
        progress = 0;
        BG_2 = false;
    }
    public void TimeStart()
    {
        timer.StartTimer(AR1C0_time[0], AR1C0_time[1]);
    }
    public void ChapterStart()
    {
        AR1C0_BackgroundManager.Instance.Background_2();
        MainText.text = "존스티나 공작령, 특수 사건 전담 사무소";
        GameObject.Find("AR1C0_1").GetComponent<AR1_InteractionController>().Text();
    }
    public void ChapterStart_1()
    {
        Arrow.SetActive(true);
        Profile_C.SetActive(true);
        Typer_C.SetActive(true);
    }
    public void ClickLeft()
    {
        if (BG_2)
        {
            BG_2 = false;
            AR1C0_BackgroundManager.Instance.Background_1();
            Arrow_L.SetActive(false);
            Profile_C.SetActive(false);
            Files_C.SetActive(true);
            if (Typer_C != null)
            {
                Typer_C.SetActive(false);
            }
        }
        else
        {
            AR1C0_BackgroundManager.Instance.Background_2();
            BG_2 = true;
            Arrow_R.SetActive(true);
            Profile_C.SetActive(true);
            Blackboard_C.SetActive(false);
            if (Typer_C != null)
            {
                Typer_C.SetActive(true);
            }
        }
    }
    public void ClickRight()
    {
        if (BG_2)
        {
            BG_2 = false;
            AR1C0_BackgroundManager.Instance.Background_3();
            Arrow_R.SetActive(false);
            Profile_C.SetActive(false);
            Blackboard_C.SetActive(true);
            if (Typer_C != null)
            {
                Typer_C.SetActive(false);
            }
        }
        else
        {
            AR1C0_BackgroundManager.Instance.Background_2();
            BG_2 = true;
            Arrow_L.SetActive(true);
            Files_C.SetActive(false);
            Profile_C.SetActive(true);
            if (Typer_C != null)
            {
                Typer_C.SetActive(true);
            }
        }
    }
    public void ClickTyper()
    {
        AR1C0_BackgroundManager.Instance.Typewriter();
        GameObject.Find("AR1C0_24").GetComponent<AR1_InteractionController>().Text();
        directyper = true;
        Arrow.SetActive(false);
    }
    public void Typer_1()
    {
        Black.SetActive(true);
        Files_Answer.SetActive(true);
    }
    public void ClickFiles()
    {
        if (progress == 0)
        {
            Black.SetActive(true);
            Files_B.SetActive(true);
            Arrow.SetActive(false);
            Files_Ex.SetActive(true);
            ClickEvent.SetActive(false);
        }
        else
        {
            GameObject.Find("AR1C0_2").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void AfterFiles()
    {
        Black.SetActive(true);
        Files_Contents.SetActive(true);
        Arrow.SetActive(false);
    }
    public void Files_1()
    {
        progress = 1;
        MainText.text = "Quiz 1";
        Files_Ex.SetActive(false);
        Files_Enter.SetActive(true);
        Files_R.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(1);
    }
    public void ClickFilesRead()
    {
        Files_Enter.SetActive(false);
        Files_R.SetActive(false);
        Files_Contents.SetActive(true);
        if (ForFiles == 0)
        {
            GameObject.Find("AR1C0_3").GetComponent<AR1_InteractionController>().Text();
        }
        else if (ForFiles == 1)
        {
            GameObject.Find("AR1C0_4").GetComponent<AR1_InteractionController>().Text();
        }
        else if (ForFiles == 2)
        {
            GameObject.Find("AR1C0_5").GetComponent<AR1_InteractionController>().Text();
        }
        else
        {
            GameObject.Find("AR1C0_6").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void Allfile()
    {
        if (file4)
        {
            return;
        }
        else
        {
            file4 = true;
            GameObject.Find("AR1C0_28").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void ClickFilesBack()
    {
        if (ForFiles == 1)
        {
            ForFiles = 0;
            Files_C1.SetActive(true);
            Files_C2.SetActive(false);
            Files_Back.SetActive(false);
            if (progress == 1)
            {
                GameObject.Find("AR1C0_3").GetComponent<AR1_InteractionController>().Text();
            }
            else
            {

            }
        }
        else if (ForFiles == 2)
        {
            ForFiles = 1;
            Files_C2.SetActive(true);
            Files_C3.SetActive(false);
            if (progress == 1)
            {
                GameObject.Find("AR1C0_4").GetComponent<AR1_InteractionController>().Text();
            }
            else
            {

            }
        }
        else
        {
            ForFiles = 2;
            Files_C3.SetActive(true);
            Files_C4.SetActive(false);
            Files_Next.SetActive(true);
            if (progress == 1)
            {
                GameObject.Find("AR1C0_5").GetComponent<AR1_InteractionController>().Text();
            }
            else
            {

            }
        }
    }
    public void ClickFilesNext()
    {
        if (ForFiles == 0)
        {
            ForFiles = 1;
            Files_C1.SetActive(false);
            Files_C2.SetActive(true);
            Files_Back.SetActive(true);
            if (progress == 1)
            {
                GameObject.Find("AR1C0_4").GetComponent<AR1_InteractionController>().Text();
            }
            else
            {

            }
        }
        else if (ForFiles == 1)
        {
            ForFiles = 2;
            Files_C2.SetActive(false);
            Files_C3.SetActive(true);
            if (progress == 1)
            {
                GameObject.Find("AR1C0_5").GetComponent<AR1_InteractionController>().Text();
            }
            else
            {

            }
        }
        else
        {
            ForFiles = 3;
            Files_C3.SetActive(false);
            Files_C4.SetActive(true);
            Files_Next.SetActive(false);
            if (progress == 1)
            {
                GameObject.Find("AR1C0_6").GetComponent<AR1_InteractionController>().Text();
            }
            else
            {

            }
        }
    }
    public void FilesSup_1()
    {
        GameObject.Find("AR1C0_25").GetComponent<AR1_InteractionController>().Text();
    }
    public void FilesSup_2()
    {
        GameObject.Find("AR1C0_26").GetComponent<AR1_InteractionController>().Text();
    }
    public void FilesSup_3()
    {
        GameObject.Find("AR1C0_27").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickFilesReadClose()
    {
        Files_Contents.SetActive(false);
        if (progress == 1)
        {
            Files_Enter.SetActive(true);
            Files_R.SetActive(true);
        }
        else
        {
            Black.SetActive(false);
            Arrow.SetActive(true);
        }
    }
    public void ClickFilesAnswer()
    {
        Files_B.SetActive(false);
        Files_Contents.SetActive(false);
        Files_R.SetActive(false);
        Files_Enter.SetActive(false);
        AR1C0_BackgroundManager.Instance.Typewriter();
        Files_Answer.SetActive(true);
    }
    public void FilesResult()
    {
        AR1_Manager.Instance.DisableHintButton();
        if (InputField.text.ToLower() == "drug")
        {
            AR1C0_BackgroundManager.Instance.Background_1();
            Files_Answer.SetActive(false);
            Black.SetActive(false);
            GameObject.Find("AR1C0_7").GetComponent<AR1_InteractionController>().Text();
            Destroy(Typer_C);
        }
        else
        {
            Files_Answer.SetActive(false);
            GameObject.Find("AR1C0_8").GetComponent<AR1_InteractionController>().Text();
        }

    }
    public void FilesAgain()
    {
        Files_Answer.SetActive(true);
        InputField.text = "";
        AR1_Manager.Instance.EnableHintButton(1);
    }
    public void ClickFilesAnswerBack()
    {
        if (directyper)
        {
            Arrow.SetActive(true);
            Files_Answer.SetActive(false);
            Black.SetActive(false);
            Profile_C.SetActive(true);
            Typer_C.SetActive(true);
            AR1C0_BackgroundManager.Instance.Background_2();
            directyper = false;
        }
        else
        {
            Files_Answer.SetActive(false);
            Files_B.SetActive(true);
            Files_R.SetActive(true);
            Files_Enter.SetActive(true);
            AR1C0_BackgroundManager.Instance.Background_1();
        }
    }
    public void Quiz2Start()
    {
        Files_Answer.SetActive(false);
        progress = 2;
        MainText.text = "Quiz 2";
        Quiz2.SetActive(true);

        GameObject.Find("AR1C0_9").GetComponent<AR1_InteractionController>().Text();
    }
    public void BeforeQ2()
    {
        Quiz2.SetActive(false);
        Note_Big.SetActive(true);
        Black.SetActive(true);
        GameObject.Find("AR1C0_9_1").GetComponent<AR1_InteractionController>().Text();
    }
    public void BQ2_1()
    {
        Note_Big.SetActive(false);
        Note_Content.SetActive(true);
        GameObject.Find("AR1C0_9_2").GetComponent<AR1_InteractionController>().Text();
    }
    public void Inventory_1()
    {
        AR1_Block.UsingItem = false;
        GetNote = true;
        RedArrow.SetActive(true);
        Note_Content.SetActive(false);
        arrow = true;
    }
    public void ViewNote()
    {
        Black.SetActive(true);
        Note_Content.SetActive(true);
        Note_Close.SetActive(true);
    }
    public void CloseNote()
    {
        Note_Content.SetActive(false);
        if (arrow)
        {
            Quiz2.SetActive(true);
            Q2_A1.AddComponent<AR1C0_TouchManager>();
            Q2_A2.AddComponent<AR1C0_TouchManager>();
            Q2_A3.AddComponent<AR1C0_TouchManager>();
            arrow = false;
            AR1_Manager.Instance.EnableHintButton(2);
        }
        else
        {
            Black.SetActive(false);
        }
    }
    public void ClickQuiz2People()
    {
        Quiz2_BG.SetActive(false);
        Quiz2_Back.SetActive(true);
        Quiz2_Submit.SetActive(true);
        if (ForQuiz2 == 1)
        {
            Quiz2_E1.SetActive(true);
        }
        else if (ForQuiz2 == 2)
        {
            Quiz2_E2.SetActive(true);
        }
        else
        {
            Quiz2_E3.SetActive(true);
        }
    }
    public void ClickQuiz2Back()
    {
        ForQuiz2 = 0;
        Quiz2_Back.SetActive(false);
        Quiz2_Submit.SetActive(false);
        Quiz2_E1.SetActive(false);
        Quiz2_E2.SetActive(false);
        Quiz2_E3.SetActive(false);
        Quiz2_BG.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(2);
    }
    public void ClickQuiz2Submit()
    {
        AR1_Manager.Instance.DisableHintButton();
        if (ForQuiz2 == 3)
        {
            Quiz2End();
        }
        else
        {
            GameObject.Find("AR1C0_11").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void Quiz2End()
    {
        Black.SetActive(false);
        Quiz2.SetActive(false);
        FileEnd = true;
        MainText.text = "존스티나 공작령, 특수 사건 전담 사무소";
        GameObject.Find("AR1C0_10").GetComponent<AR1_InteractionController>().Text();
    }
    public void AfterQuiz()
    {
        Arrow.SetActive(true);
        ClickEvent.SetActive(true);
    }
    /*public void ClickPictures()
    {
        PicEnd = true;
        Arrow.SetActive(false);
        Pictures.SetActive(false);
        GameObject.Find("AR1C0_12").GetComponent<AR1_InteractionController>().Text();
    }*/

    public void ClickBlackboard()
    {
        Black.SetActive(true);
        BlackboardBG.SetActive(true);
        Arrow.SetActive(false);

        if (FileEnd && BlackEnd == false && progress == 2)
        {
            GameObject.Find("AR1C0_13").GetComponent<AR1_InteractionController>().Text();
            Destroy(Picture_C);
            ForBB = 10;
            ClickEvent.SetActive(false);
        }
        else if (progress == 3 && BlackEnd == false)
        {
            Black.SetActive(true);
            BlackboardBG.SetActive(true);
            Blackboard_pics.SetActive(true);
            BB_Lines.SetActive(true);
            BlackboardClose.SetActive(true);
            BlackboardBtn.SetActive(true);
        }
        else if (BlackEnd)
        {
            AfterBlack();
        }
        else
        {
            GameObject.Find("AR1C0_13").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void AfterBlack()
    {
        Black.SetActive(true);
        BlackboardBG.SetActive(true);
        Blackboard_pics.SetActive(true);
        BB_Lines.SetActive(true);
        BlackboardClose.SetActive(true);
        ForBB = 0;
    }
    public void BlackboardBack()
    {
        Black.SetActive(false);
        BlackboardBG.SetActive(false);
        ClickEvent.SetActive(true);
        Arrow.SetActive(true);
        BlackboardBtn.SetActive(false);
        BlackboardClose.SetActive(false);
        Blackboard_pics.SetActive(false);
        if (BlackEnd || progress == 3)
        {
            BB_Lines.SetActive(false);
        }
    }
    public void Blackboard_1()
    {
        progress = 3;
        MainText.text = "Quiz 3";
        Blackboard_pics.SetActive(true);
        BlackboardBtn.SetActive(true);
        BlackboardClose.SetActive(true);
        ForBB = 0;
        AR1_Manager.Instance.EnableHintButton(3);
    }
    public void BlackboardSuccess()
    {
        BlackboardBG.SetActive(false);
        Blackboard_pics.SetActive(false);
        Black.SetActive(false);
        BB_Lines.SetActive(false);
        BlackboardBtn.SetActive(false);
        BlackboardClose.SetActive(false);
        BlackEnd = true;
        MainText.text = "존스티나 공작령, 특수 사건 전담 사무소";
        GameObject.Find("AR1C0_14").GetComponent<AR1_InteractionController>().Text();
        ClickEvent.SetActive(true);
        AR1_Manager.Instance.DisableHintButton();
    }
    public void BlackboardFail()
    {
        BlackboardBG.SetActive(false);
        Blackboard_pics.SetActive(false);
        BB_Lines.SetActive(false);
        GameObject.Find("AR1C0_15").GetComponent<AR1_InteractionController>().Text();
        AR1_Manager.Instance.DisableHintButton();
    }
    public void BlackboardAgain()
    {
        BlackboardBG.SetActive(true);
        Blackboard_pics.SetActive(true);
        BB_Lines.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(3);
    }
    public void ClickProfiles()
    {
        if (BlackEnd)
        {
            if (Profilefirst)
            {
                Black.SetActive(true);
                Quiz4.SetActive(true);
                Arrow.SetActive(false);
                ClickEvent.SetActive(false);
            }
            else
            {
                Black.SetActive(true);
                SuspectPf.SetActive(true);
                Arrow.SetActive(false);
                ClickEvent.SetActive(false);
                GameObject.Find("AR1C0_17").GetComponent<AR1_InteractionController>().Text();
                Profilefirst = true;
            }
        }
        else
        {
            Arrow.SetActive(false);
            GameObject.Find("AR1C0_16").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void Profile__1()
    {
        SuspectN.SetActive(true);
        GameObject.Find("AR1C0_17 (1)").GetComponent<AR1_InteractionController>().Text();
    }
    public void Profiles_1()
    {
        SuspectPf.SetActive(false);
        Quiz4.SetActive(true);
        progress = 4;
        MainText.text = "Quiz 4";
        AR1_Manager.Instance.EnableHintButton(4);
    }
    public void Q4ToLeft()
    {
        switch (ForSuspect)
        {
            case 1:
                Q4Left.SetActive(false);
                Q4Image.GetComponent<Image>().sprite = Q4_1;
                ForSuspect = 0;
                break;
            case 2:
                Q4Image.GetComponent<Image>().sprite = Q4_2;
                ForSuspect = 1;
                break;
            case 3:
                Q4Right.SetActive(true);
                Q4Image.GetComponent<Image>().sprite = Q4_3;
                ForSuspect = 2;
                break;
        }
    }
    public void Q4ToRight()
    {
        switch (ForSuspect)
        {
            case 0:
                Q4Left.SetActive(true);
                Q4Image.GetComponent<Image>().sprite = Q4_2;
                ForSuspect = 1;
                break;
            case 1:
                Q4Image.GetComponent<Image>().sprite = Q4_3;
                ForSuspect = 2;
                break;
            case 2:
                Q4Right.SetActive(false);
                Q4Image.GetComponent<Image>().sprite = Q4_4;
                ForSuspect = 3;
                break;
        }
    }
    public void Quiz4Back()
    {
        Black.SetActive(false);
        Quiz4.SetActive(false);
        Arrow.SetActive(true);
        ClickEvent.SetActive(true);
    }
    public void Quiz4Result()
    {
        AR1_Manager.Instance.DisableHintButton();
        if (Q4Image.GetComponent<Image>().sprite == Q4_2)
        {
            Quiz4Success();
        }
        else if (Q4Image.GetComponent<Image>().sprite == Q4_3)
        {
            Quiz4Fail_1();
        }
        else
        {
            Quiz4Fail();
        }
    }
    public void Quiz4Success()
    {
        Black.SetActive(false); 
        Quiz4.SetActive(false);
        MainText.text = "존스티나 공작령, 특수 사건 전담 사무소";

        GameObject.Find("AR1C0_18").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz4Fail()
    {
        Black.SetActive(false);
        Quiz4.SetActive(false);
        GameObject.Find("AR1C0_19").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz4Fail_1()
    {
        Black.SetActive(false);
        Quiz4.SetActive(false);
        GameObject.Find("AR1C0_20").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q4Again()
    {
        Black.SetActive(true);
        Quiz4.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(4);
    }
    public void Quiz5Start()
    {
        GameObject.Find("AR1C0_21").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz5_1()
    {
        Black.SetActive(true);
        Quiz5.SetActive(true);
        progress = 5;
        MainText.text = "Quiz 5";
        AR1_Manager.Instance.EnableHintButton(5);
    }
    public void Quiz5Success()
    {
        Black.SetActive(false);
        Quiz5.SetActive(false);
        MainText.text = "존스티나 공작령, 특수 사건 전담 사무소";
        GameObject.Find("AR1C0_22").GetComponent<AR1_InteractionController>().Text();
        AR1_Manager.Instance.DisableHintButton();
    }
    public void Quiz5Fail()
    {
        GameObject.Find("AR1C0_23").GetComponent<AR1_InteractionController>().Text();
        AR1_Manager.Instance.DisableHintButton();
    }
}
