using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AR2C2_MoveManager : MonoBehaviour
{
    public static AR2C2_MoveManager Instance;

    public Timer timer;

    public GameObject Choice_1, Choice2_1, Choice2_2;

    public GameObject Hallway;
    public GameObject Black;
    public GameObject RoomInside;
    public GameObject ChoiceBtn_1;
    public GameObject Paper;
    public GameObject PaperwithContent;
    public GameObject Failgray;
    public GameObject Quiz1box;
    public GameObject OldEti;
    public GameObject plan;
    public GameObject plan2;
    public GameObject EtiFX;
    public GameObject OpenHallway;
    public GameObject ClickHallDoor;
    public GameObject Garden;
    public GameObject planback;
    public GameObject Quiz2AnswerBtn;
    public GameObject ToplanbackBtn;
    public GameObject Quiz2AnswerPaper;
    public GameObject Q2AnswerBtns;
    public GameObject DiningBg;
    public GameObject DiningPeople;
    public GameObject DiningSeats;
    public GameObject redarrow;
    public GameObject Quiz3Btns;
    public GameObject paperback;
    public GameObject Q3_Seats;
    public GameObject Quiz4_people;
    public GameObject blocktouch;
    public GameObject ChoiceBtn_2;
    public GameObject girl;
    public GameObject second;
    public GameObject first;
    public GameObject last;
    public GameObject dad;
    public GameObject boy;
    public GameObject Quiz_5;
    public GameObject Q5_Food;
    public GameObject Q5_food1;
    public GameObject Q5_food2;
    public GameObject Q5_food3;
    public GameObject Q5_food4;
    public GameObject Q5_food5;
    public GameObject Q5_Content;
    public GameObject Q5_Choicefood;
    public GameObject Q5_QuizAgain;
    public GameObject CenterText;
    public GameObject Q2BackBtn;
    public GameObject Close_Content;

    public Text C_1;
    public Text C2_1;
    public Text C2_2;
    public Text Q1_1;
    public Text Q1_2;
    public Text Q1_3;
    public Text Q1_4;

    public TMP_Text Maintext;

    public bool ar2c2 = true;
    public bool IsPlan = false;
    public bool IsPlanadded = false;
    public bool IsPaper = false;
    public bool IsQuiz3 = false;
    public bool IsTalking = false;
    public bool IsSpoon = false;
    public bool toplanback = false;
    public bool topaperback = false;
    public bool toQ3 = false;
    public bool Isfirst = false;
    public bool Issecond = false;
    public bool Isgirl = false;
    public bool Isdad = false;
    public bool Isboy = false;
    public bool Forprogress = false;
    public bool ToDelPaperIntend = false;
    public bool Quiz3end = false;
    public bool plusold = false;

    bool Q4_girl = false;
    bool Q4_dad = false;
    bool Q4_second = false;
    bool Q4_boy = false;
    bool Q4_baby = false;
    bool Q4_first = false;

    public int progress = 0;
    bool Q1Check1 = false;
    bool Q1Check2 = false;

    public bool ar2c2_q3 = false;

    int[] AR2C2_time = new int[] { 7, 0 };

    void Awake()
    {
        if (Instance == null)
            Instance = this;

        Choice_1.AddComponent<AR2C2_TouchManager>();
        Choice2_1.AddComponent<AR2C2_TouchManager>();
        Choice2_2.AddComponent<AR2C2_TouchManager>();
        Close_Content.AddComponent<AR2C2_TouchManager>();
    }
    private void OnDisable()
    {
        progress = 0;
        Destroy(Choice_1.GetComponent<AR2C2_TouchManager>());
        Destroy(Choice2_1.GetComponent<AR2C2_TouchManager>());
        Destroy(Choice2_2.GetComponent<AR2C2_TouchManager>());
        Destroy(Close_Content.GetComponent<AR2C2_TouchManager>());
        ar2c2 = false;
        if (Q5_food1.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(Q5_food1.GetComponent<AR2C2_TouchManager>());
        }
        if (Q5_food2.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(Q5_food2.GetComponent<AR2C2_TouchManager>());
        }
        if (Q5_food3.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(Q5_food3.GetComponent<AR2C2_TouchManager>());
        }
        if (Q5_food4.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(Q5_food4.GetComponent<AR2C2_TouchManager>());
        }
        if (Q5_food5.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(Q5_food5.GetComponent<AR2C2_TouchManager>());
        }
        Color color1 = first.GetComponent<Image>().color;
        color1 = new Color32(255, 255, 255, 255);
        first.GetComponent<Image>().color = color1;
        first.AddComponent<AR2C2_TouchManager>();

        Color color2 = girl.GetComponent<Image>().color;
        color2 = new Color32(255, 255, 255, 255);
        girl.GetComponent<Image>().color = color2;
        girl.AddComponent<AR2C2_TouchManager>();

        Color color3 = second.GetComponent<Image>().color;
        color3 = new Color32(255, 255, 255, 255);
        second.GetComponent<Image>().color = color3;
        second.AddComponent<AR2C2_TouchManager>();

        Color color4 = last.GetComponent<Image>().color;
        color4 = new Color32(255, 255, 255, 255);
        last.GetComponent<Image>().color = color4;
        last.AddComponent<AR2C2_TouchManager>();

        Color color5 = dad.GetComponent<Image>().color;
        color5 = new Color32(255, 255, 255, 255);
        dad.GetComponent<Image>().color = color5;
        dad.AddComponent<AR2C2_TouchManager>();

        Color color6 = boy.GetComponent<Image>().color;
        color6 = new Color32(255, 255, 255, 255);
        boy.GetComponent<Image>().color = color6;
        boy.AddComponent<AR2C2_TouchManager>();
    }
    void OnEnable()
    {
        Quiz3end = false;
        Forprogress = true;
        progress = 0;
        ar2c2 = true;
        IsPlan = false;
        IsPaper = false;
        IsQuiz3 = false;
        IsTalking = false;
        IsSpoon = false;
        toplanback = false;
        topaperback = false;
        toQ3 = false;
        Isfirst = false;
        Issecond = false;
        Isgirl = false;
        Isdad = false;
        Isboy = false;
        ToDelPaperIntend = false;
        IsPlanadded = false;
        ar2c2_q3 = false;
        plusold = false;

        AR2_Slot.Openold = false;
        AR2_Slot.oldq5 = false;
        AR2_Slot.IsGod = false;
        AR2_Slot.Ispaper = false;
        AR2_Slot.Isplan = false;
        AR2_Slot.Isdiary = false;
    }
    void Update()
    {
        if (Q4_girl && Q4_dad && Q4_second && Q4_boy && Q4_baby && Q4_first)
        {
            Q4_girl = false; Q4_dad = false; Q4_second = false;
            Q4_boy = false; Q4_baby = false; Q4_first = false;
            Invoke("Quiz5", 1.0f);
        }
    }
    public void TimeStart()
    {
        timer.StartTimer(AR2C2_time[0], AR2C2_time[1]);
    }
    public void ChapterStart()
    {
        AR2_Close.UsingItem = true;
        Maintext.text = "제 2장 : 존스티나 공작가, 아이란의 방";
        SoundManager.instance.PlaySFX(Sfx.Knock_Door);
        ar2c2_q3 = true;
        plusold = true;
        GameObject.Find("AR2C2_1").GetComponent<AR2_InteractionController>().Text();
    }
    public void Outside()
    {
        Black.SetActive(true);
        ChoiceBtn_1.SetActive(true);
        C_1.text = "문 밖으로 나가기";
    }
    public void AtHallway()
    {
        Black.SetActive(false);
        ChoiceBtn_1.SetActive(false);
        RoomInside.SetActive(false);
        Hallway.SetActive(true);

        GameObject.Find("AR2C2_2").GetComponent<AR2_InteractionController>().Text();
    }
    public void Hallway_1()
    {
        Black.SetActive(true);
        Paper.SetActive(true);
        IsPaper = true;

        GameObject.Find("AR2C2_3").GetComponent<AR2_InteractionController>().Text();
    }
    public void Quiz1()
    {
        progress = 1;
        Maintext.text = "Quiz 1";
        Black.SetActive(false);
        Paper.SetActive(false);

        GameObject.Find("AR2C2_4").GetComponent<AR2_InteractionController>().Text();
    }
    public void Quiz1_1()
    {
        Black.SetActive(true);
        PaperwithContent.SetActive(true);

        GameObject.Find("AR2C2_5").GetComponent<AR2_InteractionController>().Text();
    }
    public void Quiz1_2()
    {
        Quiz1box.SetActive(true);
        AR2_Manager.Instance.EnableHintButton(5);
    }
    public void Quiz1Result()
    {
        AR2_Manager.Instance.DisableHintButton();
        if (Q1_1.text == "1" && Q1_2.text == "9" && Q1_3.text == "0" && Q1_4.text == "0")
        {
            Quiz1Success();
        }
        else
        {
            Quiz1Fail();
        }
    }
    public void ReturnQ1()
    {
        /*Q1_1.text = "0";
        Q1_2.text = "0";
        Q1_3.text = "0";
        Q1_4.text = "0";*/
        AR2_Manager.Instance.EnableHintButton(5);
        Failgray.SetActive(false);
        Quiz1box.SetActive(true);
        PaperwithContent.SetActive(true);
    }
    public void Quiz1Fail()
    {
        Quiz1box.SetActive(false);
        PaperwithContent.SetActive(false);
        Failgray.SetActive(true);

        if (int.Parse(Q1_1.text) > 1 || Q1_1.text == "1" && Q1_2.text == "9" && (int.Parse(Q1_3.text) > 0 || int.Parse(Q1_4.text) > 0))
        {
            GameObject.Find("AR2C2_7").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            GameObject.Find("AR2C2_6").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void Quiz1Success()
    {
        Quiz1box.SetActive(false);
        PaperwithContent.SetActive(false);
        Black.SetActive(false);
        Q1Check1 = true;
        Maintext.text = "제 2장 : 존스티나 공작가, 아이란의 방";

        GameObject.Find("AR2C2_8").GetComponent<AR2_InteractionController>().Text();
    }
    public void UsingItemF()
    {
        AR2_Close.UsingItem = false; Debug.Log("1");
    }
    public void Quiz1Check()
    {
        if (IsPlanadded == true)
        {
            ClickHallDoor.SetActive(true);

            GameObject.Find("AR2C2_10").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            Q1Check2 = true;

            GameObject.Find("AR2C2_9").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void OldEtiquette()
    {
        AR2_Close.UsingItem = true;
        plusold = false;
        Black.SetActive(true);
        OldEti.SetActive(true);
        Invoke("Old_1", 0.5f);
    }
    public void Old_1()
    {
        OldEti.SetActive(false);
        EtiFX.SetActive(true);
        Invoke("Old_2", 0.8f);
    }
    public void Old_2()
    {
        EtiFX.SetActive(false);
        plan.SetActive(true);

        Invoke("Old_3", 0.5f);
    }
    public void Old_3()
    {
        Black.SetActive(false);
        plan.SetActive(false);
        Old_5();
    }
    public void Old_5()
    {
        CenterText.SetActive(true);
        AR2_Close.UsingItem = false;
    }
    public void Old_6()
    {
        CenterText.SetActive(false);
        if (IsPlan)
        {
            IsPlanadded = false;
        }
        else
        {
            IsPlanadded = true;
        }

        if (Q1Check1 && Q1Check2)
        {
            ClickHallDoor.SetActive(true);

            GameObject.Find("AR2C2_10").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void ClickHallwayDoor()
    {
        ClickHallDoor.SetActive(false);
        OpenHallway.SetActive(true);
        Invoke("OutsideBuilding", 0.5f);
    }
    public void OutsideBuilding()
    {
        Maintext.text = "제 2장 : 존스티나 공작가, 정원";
        OpenHallway.SetActive(false);
        Garden.SetActive(true);

        GameObject.Find("AR2C2_11").GetComponent<AR2_InteractionController>().Text();
    }
    public void Q2Intro()
    {
        plan2.SetActive(true);
    }
    public void Quiz2()
    {
        progress = 2;
        Maintext.text = "Quiz 2";
        AR2_Close.UsingItem = true;
        AR2_Manager.Instance.EnableHintButton(6);
        Black.SetActive(true);
        ToplanbackBtn.SetActive(true);
        Quiz2AnswerBtn.SetActive(true);
    }
    public void PlanBack()
    {
        plan2.SetActive(false);
        planback.SetActive(true);
        toplanback = true;
    }
    public void PlanFront()
    {
        plan2.SetActive(true);
        planback.SetActive(false);
        toplanback = false;
    }
    public void Quiz2Answer()
    {
        plan2.SetActive(false);
        planback.SetActive(false);
        ToplanbackBtn.SetActive(false);
        Quiz2AnswerBtn.SetActive(false);
        Quiz2AnswerPaper.SetActive(true);
        Q2AnswerBtns.SetActive(true);
        Q2BackBtn.SetActive(true);
    }
    public void PlanAgain()
    {
        Quiz2AnswerPaper.SetActive(false);
        Q2AnswerBtns.SetActive(false);
        ToplanbackBtn.SetActive(true);
        Quiz2AnswerBtn.SetActive(true);
        Q2BackBtn.SetActive(false);

        if (!toplanback)
        {
            plan2.SetActive(true);
        }
        else
        {
            planback.SetActive(true);
        }
    }
    public void Quiz2Fail()
    {
        AR2_Manager.Instance.DisableHintButton();
        Quiz2AnswerPaper.SetActive(false);
        Q2AnswerBtns.SetActive(false);
        Q2BackBtn.SetActive(false);
        Black.SetActive(false);

        GameObject.Find("AR2C2_12").GetComponent<AR2_InteractionController>().Text();
    }
    public void ReturnQ2()
    {
        plan2.SetActive(true);
        ToplanbackBtn.SetActive(true);
        Quiz2AnswerBtn.SetActive(true);
        Black.SetActive(true);
        AR2_Manager.Instance.EnableHintButton(6);
    }
    public void Quiz2Success()
    {
        AR2_Manager.Instance.DisableHintButton();
        Maintext.text = "제 2장 : 존스티나 공작가, 식당";
        Quiz2AnswerPaper.SetActive(false);
        Q2AnswerBtns.SetActive(false);
        Black.SetActive(false);
        Garden.SetActive(false);
        DiningBg.SetActive(true);
        DiningPeople.SetActive(true);
        DiningSeats.SetActive(true);
        Q2BackBtn.SetActive(false);
        AR2_Close.UsingItem = false;

        IsQuiz3 = true;

        GameObject.Find("AR2C2_13").GetComponent<AR2_InteractionController>().Text();
    }
    public void ToQuiz3()
    {
        redarrow.SetActive(true);
        toQ3 = true;
    }
    public void Quiz3()
    {
        ToDelPaperIntend = true;
        progress = 3;
        Maintext.text = "Quiz 3";
        Quiz3end = true;
        Black.SetActive(true);
        PaperwithContent.SetActive(true);
        topaperback = true;
        Quiz3Btns.SetActive(true);
        AR2_Manager.Instance.EnableHintButton(7);
    }
    public void ToPaperBack()
    {
        topaperback = false;
        PaperwithContent.SetActive(false);
        paperback.SetActive(true);
    }
    public void ToPaperFront()
    {
        topaperback = true;
        PaperwithContent.SetActive(true);
        paperback.SetActive(false);
    }
    public void ClosePaper()
    {
        AR2_Close.UsingItem = false;
        Quiz3Btns.SetActive(false);
        PaperwithContent.SetActive(false);
        paperback.SetActive(false);
        Black.SetActive(false);
        if (Q3_Seats != null)
        {
            Q3_Seats.SetActive(true);
            DiningSeats.SetActive(false);
        }
        else
        {

        }

    }
    public void Quiz3Fail()
    {
        Q3_Seats.SetActive(false);
        Failgray.SetActive(true);
        AR2_Manager.Instance.DisableHintButton();

        GameObject.Find("AR2C2_14").GetComponent<AR2_InteractionController>().Text();
    }
    public void ReturnQ3()
    {
        Failgray.SetActive(false);
        Q3_Seats.SetActive(true);
        AR2_Manager.Instance.EnableHintButton(7);
    }
    public void Quiz3Success()
    {
        Destroy(Q3_Seats);
        DiningSeats.SetActive(true);
        Quiz3end = true;
        Maintext.text = "제 2장 : 존스티나 공작가, 식당";
        AR2_Manager.Instance.DisableHintButton();

        GameObject.Find("AR2C2_15").GetComponent<AR2_InteractionController>().Text();
    }
    public void Quiz4()
    {
        progress = 4;

        GameObject.Find("AR2C2_16").GetComponent<AR2_InteractionController>().Text();

        Maintext.text = "Quiz 4";
        IsTalking = false;
    }
    public void Q4Again()
    {
        GameObject.Find("AR2C2_16").GetComponent<AR2_InteractionController>().Text();
        Maintext.text = "Quiz 4";
        if (Q4_first)
        {
            Color color = first.GetComponent<Image>().color;
            color = new Color32(100, 100, 100, 255);
            first.GetComponent<Image>().color = color;
        }
        else
        {
            first.AddComponent<AR2C2_TouchManager>();
        }

        if (Q4_second)
        {
            Color color = second.GetComponent<Image>().color;
            color = new Color32(100, 100, 100, 255);
            second.GetComponent<Image>().color = color;
        }
        else
        {
            second.AddComponent<AR2C2_TouchManager>();
        }

        if (Q4_boy)
        {
            Color color = boy.GetComponent<Image>().color;
            color = new Color32(100, 100, 100, 255);
            boy.GetComponent<Image>().color = color;
        }
        else
        {
            boy.AddComponent<AR2C2_TouchManager>();
        }

        if (Q4_baby)
        {
            Color color = last.GetComponent<Image>().color;
            color = new Color32(100, 100, 100, 255);
            last.GetComponent<Image>().color = color;
        }

        if (Q4_dad)
        {
            Color color = dad.GetComponent<Image>().color;
            color = new Color32(100, 100, 100, 255);
            dad.GetComponent<Image>().color = color;
        }
        else
        {
            dad.AddComponent<AR2C2_TouchManager>();
        }

        if (Q4_girl)
        {
            Color color = girl.GetComponent<Image>().color;
            color = new Color32(100, 100, 100, 255);
            girl.GetComponent<Image>().color = color;
        }
        else
        {
            girl.AddComponent<AR2C2_TouchManager>();
        }
    }
    public void Quiz4Start()
    {
        DiningPeople.SetActive(false);
        Quiz4_people.SetActive(true);
    }
    public void ClickFirst()
    {
        if (first.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(first.GetComponent<AR2C2_TouchManager>());
        }
        IsTalking = true;
        Isfirst = true;

        GameObject.Find("AR2C2_17").GetComponent<AR2_InteractionController>().Text();
    }
    public void First_1()
    {
        ChoiceBtn_2.SetActive(true);
        C2_1.text = "안녕하세요";
        C2_2.text = "누구세요?";
    }
    public void First_1_1()
    {
        ChoiceBtn_2.SetActive(false);
        Isfirst = false;

        GameObject.Find("AR2C2_18").GetComponent<AR2_InteractionController>().Text();
    }
    public void First_1_2()
    {
        ChoiceBtn_2.SetActive(false);
        Isfirst = false;

        GameObject.Find("AR2C2_19").GetComponent<AR2_InteractionController>().Text();
    }
    public void First_1_2_1()
    {
        Color color = first.GetComponent<Image>().color;
        color = new Color32(100, 100, 100, 255);
        first.GetComponent<Image>().color = color;
        IsTalking = false;
        Q4_first = true;
        if (first.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(first.GetComponent<AR2C2_TouchManager>());
        }
    }
    public void ClickSecond()
    {
        if (second.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(second.GetComponent<AR2C2_TouchManager>());
        }
        IsTalking = true;
        Issecond = true;

        GameObject.Find("AR2C2_20").GetComponent<AR2_InteractionController>().Text();
    }
    public void Second_1()
    {
        ChoiceBtn_2.SetActive(true);
        C2_1.text = "부정한다";
        C2_2.text = "긍정한다";
    }
    public void Second_1_2()
    {
        ChoiceBtn_2.SetActive(false);
        Issecond = false;
        GameObject.Find("AR2C2_21").GetComponent<AR2_InteractionController>().Text();
    }
    public void Second_1_1()
    {
        ChoiceBtn_2.SetActive(false);
        Issecond = false;

        GameObject.Find("AR2C2_22").GetComponent<AR2_InteractionController>().Text();
    }
    public void Second_1_1_1()
    {
        Color color = second.GetComponent<Image>().color;
        color = new Color32(100, 100, 100, 255);
        second.GetComponent<Image>().color = color;
        IsTalking = false;
        Q4_second = true;
        if (second.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(second.GetComponent<AR2C2_TouchManager>());
        }
    }
    public void ClickLittleGirl()
    {
        if (girl.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(girl.GetComponent<AR2C2_TouchManager>());
        }
        IsTalking = true;
        Isgirl = true;

        GameObject.Find("AR2C2_23").GetComponent<AR2_InteractionController>().Text();
    }
    public void littlegirl_1()
    {
        ChoiceBtn_2.SetActive(true);
        C2_1.text = "반말로 대답한다";
        C2_2.text = "존댓말로 대답한다";
    }
    public void littlegirl_1_2()
    {
        ChoiceBtn_2.SetActive(false);
        Isgirl = false;

        GameObject.Find("AR2C2_24").GetComponent<AR2_InteractionController>().Text();
    }
    public void littlegirl_1_1()
    {
        ChoiceBtn_2.SetActive(false);
        Isgirl = false;

        GameObject.Find("AR2C2_25").GetComponent<AR2_InteractionController>().Text();
    }
    public void littlegirl_1_1_1()
    {
        Color color = girl.GetComponent<Image>().color;
        color = new Color32(100, 100, 100, 255);
        girl.GetComponent<Image>().color = color;
        IsTalking = false;
        Q4_girl = true;
        if (girl.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(girl.GetComponent<AR2C2_TouchManager>());
        }
    }
    public void ClickBoy()
    {
        if (boy.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(boy.GetComponent<AR2C2_TouchManager>());
        }
        IsTalking = true;
        Isboy = true;

        GameObject.Find("AR2C2_26").GetComponent<AR2_InteractionController>().Text();
    }
    public void Boy_1()
    {
        ChoiceBtn_2.SetActive(true);
        C2_1.text = "뭘 봐?";
        C2_2.text = "우리 아까도 봤었지?";
    }
    public void Boy_1_1()
    {
        ChoiceBtn_2.SetActive(false);
        Isboy = false;

        GameObject.Find("AR2C2_27").GetComponent<AR2_InteractionController>().Text();
    }
    public void Boy_1_2()
    {
        ChoiceBtn_2.SetActive(false);
        Isboy = false;

        GameObject.Find("AR2C2_28").GetComponent<AR2_InteractionController>().Text();
    }
    public void Boy_1_2_1()
    {
        if (Q4_first)
        {
            GameObject.Find("AR2C2_30").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            GameObject.Find("AR2C2_29").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void Boy_1_2_2()
    {
        GameObject.Find("AR2C2_31").GetComponent<AR2_InteractionController>().Text();
    }
    public void Boy_1_2_3()
    {
        Color color = boy.GetComponent<Image>().color;
        color = new Color32(100, 100, 100, 255);
        boy.GetComponent<Image>().color = color;
        IsTalking = false;
        Q4_boy = true;
        if (boy.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(boy.GetComponent<AR2C2_TouchManager>());
        }
    }
    public void ClickLast()
    {
        if (last.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(last.GetComponent<AR2C2_TouchManager>());
        }
        IsTalking = true;

        GameObject.Find("AR2C2_32").GetComponent<AR2_InteractionController>().Text();
    }
    public void Last_1()
    {
        Color color = last.GetComponent<Image>().color;
        color = new Color32(100, 100, 100, 255);
        last.GetComponent<Image>().color = color;
        IsTalking = false;
        Q4_baby = true;
        if (last.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(last.GetComponent<AR2C2_TouchManager>());
        }
    }
    public void ClickDad()
    {
        if (dad.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(dad.GetComponent<AR2C2_TouchManager>());
        }
        IsTalking = true;
        Isdad = true;

        GameObject.Find("AR2C2_33").GetComponent<AR2_InteractionController>().Text();
    }
    public void Dad_1()
    {
        ChoiceBtn_2.SetActive(true);
        C2_1.text = "괜찮아요.";
        C2_2.text = "없진 않아요.";
    }
    public void Dad_1_1()
    {
        ChoiceBtn_2.SetActive(false);
        Isdad = false;

        GameObject.Find("AR2C2_35").GetComponent<AR2_InteractionController>().Text();
    }
    public void Dad_1_2()
    {
        ChoiceBtn_2.SetActive(false);
        Isdad = false;
        GameObject.Find("AR2C2_34").GetComponent<AR2_InteractionController>().Text();
    }
    public void Dad_1_2_1()
    {
        Color color = dad.GetComponent<Image>().color;
        color = new Color32(100, 100, 100, 255);
        dad.GetComponent<Image>().color = color;
        if (dad.GetComponent<AR2C2_TouchManager>() != null)
        {
            Destroy(dad.GetComponent<AR2C2_TouchManager>());
        }
        IsTalking = false;
        Q4_dad = true;
    }
    public void Q4Fail()
    {
        IsTalking = false;
        Q4Again();
    }
    public void Quiz5()
    {
        Maintext.text = "제 2장 : 존스티나 공작가, 식당";
        DiningPeople.SetActive(true);
        Quiz4_people.SetActive(false);
        Quiz_5.SetActive(true);
        Q5_Content.SetActive(false);
        Q5_Food.SetActive(false);

        GameObject.Find("AR2C2_36").GetComponent<AR2_InteractionController>().Text();
    }
    public void Quiz5_1()
    {
        Q5_Food.SetActive(true);

        GameObject.Find("AR2C2_37").GetComponent<AR2_InteractionController>().Text();
    }
    public void Quiz5_2()
    {
        progress = 5;
        Maintext.text = "Quiz 5";
        Q5_Content.SetActive(true);
        Q5_Choicefood.SetActive(true);
        AR2_Manager.Instance.EnableHintButton(8);
    }
    public void ClickChoicefood()
    {
        Q5_Content.SetActive(false);
        Q5_Choicefood.SetActive(false);
        Q5_QuizAgain.SetActive(true);
        if (Q5_food1.GetComponent<AR2C2_TouchManager>() == null)
        {
            Q5_food1.AddComponent<AR2C2_TouchManager>();
        }
        if (Q5_food2.GetComponent<AR2C2_TouchManager>() == null)
        {
            Q5_food2.AddComponent<AR2C2_TouchManager>();
        }
        if (Q5_food3.GetComponent<AR2C2_TouchManager>() == null)
        {
            Q5_food3.AddComponent<AR2C2_TouchManager>();
        }
        if (Q5_food4.GetComponent<AR2C2_TouchManager>() == null)
        {
            Q5_food4.AddComponent<AR2C2_TouchManager>();
        }
        if (Q5_food5.GetComponent<AR2C2_TouchManager>() == null)
        {
            Q5_food5.AddComponent<AR2C2_TouchManager>();
        }
    }
    public void ClickBackQ5()
    {
        Q5_Content.SetActive(true);
        Q5_Choicefood.SetActive(true);
        Q5_QuizAgain.SetActive(false);
    }
    public void Quiz5Fail()
    {
        Q5_QuizAgain.SetActive(false);
        AR2_Manager.Instance.DisableHintButton();

        GameObject.Find("AR2C2_38").GetComponent<AR2_InteractionController>().Text();
    }
    public void ReturnQ5()
    {
        Q5_QuizAgain.SetActive(true);
        AR2_Manager.Instance.EnableHintButton(8);
    }
    public void Quiz5Success()
    {
        Q5_QuizAgain.SetActive(false);
        Q5_Choicefood.SetActive(false);
        DiningBg.SetActive(false);
        Quiz_5.SetActive(false);
        Hallway.SetActive(true);
        AR2_Manager.Instance.DisableHintButton();

        GameObject.Find("AR2C2_39").GetComponent<AR2_InteractionController>().Text();
    }
    public void ForSpoon()
    {
        IsSpoon = true;
    }
    public void End()
    {
        progress = 0;
        Destroy(Choice_1.GetComponent<AR2C2_TouchManager>());
        Destroy(Choice2_1.GetComponent<AR2C2_TouchManager>());
        Destroy(Choice2_2.GetComponent<AR2C2_TouchManager>());
        Destroy(Close_Content.GetComponent<AR2C2_TouchManager>());
        ar2c2 = false;
    }
}