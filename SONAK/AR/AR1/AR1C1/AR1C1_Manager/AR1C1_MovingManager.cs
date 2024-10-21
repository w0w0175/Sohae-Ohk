using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AR1C1_MovingManager : MonoBehaviour
{
    public static AR1C1_MovingManager Instance;
    public Timer timer;

    GameObject[] go1;

    public GameObject Popup;
    public GameObject MainBg;
    public GameObject ToRight;
    public GameObject ToLeft;
    public GameObject BackBtn;
    public GameObject BlockingClick;
    public GameObject Move;
    public GameObject Q1;
    public GameObject BasicDesk;
    public GameObject PaperClick;
    public GameObject KeyClick;
    public GameObject PaperDesk;
    public GameObject KeyDesk;
    public GameObject BothDesk;
    public GameObject DownPointer;
    public GameObject Quiz1;
    public GameObject Downarrow1;
    public GameObject Downarrow2;
    public GameObject Exarrow;
    public GameObject B_F;
    public GameObject B_IX;
    public GameObject B_S;
    public GameObject B_EX;
    public GameObject PaperIntend;
    public GameObject AnswerPlace_1;
    public GameObject AnswerPlace_2;
    public GameObject AnswerPlace_3;
    public GameObject AnswerPlace_4;
    public GameObject CorrectGreen;
    public GameObject CorrectRed;
    public GameObject CorrectBlue;
    public GameObject CorrectPurple;
    public GameObject Wrong1;
    public GameObject Wrong2;
    public GameObject Wrong3;
    public GameObject Wrong4;
    public GameObject Wrong5;
    public GameObject Wrong6;
    public GameObject Q2_CancelBtn;
    public GameObject Q2_OkBtn;
    public GameObject Q2_solvedbg;
    public GameObject AR1C1_Office;
    public GameObject SecretRoom;
    public GameObject Q5Map;
    public GameObject Q5Map_text1;
    public GameObject Q5Map_text2;
    public GameObject Q5Map_text2_1;
    public GameObject Q5Map_text2_2;
    public GameObject Q3_paper;
    public GameObject FireFX;
    public GameObject Q3Skill;
    public GameObject Q3SkillUsedPaper;
    public GameObject Q3EndBtn;
    public GameObject ar1c1_paper;
    public GameObject Q4_Confidential;
    public GameObject Q4_Black;
    public GameObject Q4Bg;
    public GameObject Q4Interview;
    public GameObject Q4Apple;
    public GameObject Q4Banana;
    public GameObject Q4Cream;
    public GameObject Q4Doughnut;
    public GameObject BigCalendar;
    public GameObject Q5_Selection;
    public GameObject M_btns;
    public GameObject AR1C1_Q2;
    public GameObject AR1C1_Q1;
    public GameObject Q2Solved;
    public GameObject Clickempty;
    public GameObject Clickbookcase;
    public GameObject Block_Inven;
    public GameObject Block1;
    public GameObject Block2;
    public GameObject MoveD;
    public GameObject ME;
    public GameObject Icon;

    public Text Usedpaper3;
    public Text OpenBtnText;
    public Text Q5_Select_Text;

    public TMP_Text Maintext;

    public bool isQ1solved = false;
    public bool Q3Clear = false;
    public bool firstclick = false;
    public bool forpaper = false;
    public bool forQ2 = false;
    public bool isReturn = false;
    public bool forkey = false;
    public bool Q2Fail = false;
    public bool Q4Fail = false;
    public bool isCON = false;
    public bool isPaper = false;
    public bool Q5Around = false;
    public bool Q2Around = false;
    public bool removekey = false;
    public bool cb, cg, cr, cp, w1, w2, w3, w4, w5, w6 = false;
    public bool NextSecretroom = false;
    public bool quiz1start = false;
    public bool quiz2start = false;

    bool isQ3Q4solved = false;
    bool isConfidential = false;
    bool isKeyadded = false;
    bool isPaperadded = false;
    bool green, red, blue, purple = false;
    bool Q2BookGetText = false;
    bool Q2BookPutText = false;
    bool MapClick = false;
    bool btns = false;

    public int forquiz2 = 0;
    public int progress = 0;
    public int collectingbooks = 0;
    public int clickagain = 0;
    public int checkbooks = 0;

    int Q5Select = 0;
    int[] AR1C1_time = new int[] { 9, 0 };

    void OnDisable()
    {
        progress = 0;
        Destroy(BackBtn.GetComponent<AR1C1_TouchManager>());
        AR1_Slot.confidential = false;
        AR1_Slot.myspaper = false;
        AR1_Slot.ispaper = false;
    }
    void OnEnable()
    {
        go1 = null;

        AR1C1_4Answer.isred = false;
        AR1C1_3Answer.isblue = false;
        AR1C1_2Answer.isgreen = false;
        AR1C1_1Answer.ispurple = false;
        AR1_Slot.fordetail = 0;
        AR1_Slot.confidential = false;
        AR1_Slot.myspaper = false;
        AR1_Slot.ispaper = false;
        AR1_Detail.cb = false; AR1_Detail.cr = false; AR1_Detail.cp = false;
        AR1_Detail.cg = false; AR1_Detail.w11 = false; AR1_Detail.w22 = false;
        AR1_Detail.w33 = false; AR1_Detail.w44 = false; AR1_Detail.w55 = false; AR1_Detail.w66 = false;

        if (Instance == null)
            Instance = this;
        BackBtn.AddComponent<AR1C1_TouchManager>();
    }
    void Update()
    {
        if (progress == 2 && AR1_Block.UsingItem)
        {
            NotMove();
            btns = true;
        }
        if (progress == 2 && AR1_Block.UsingItem == false && btns)
        {
            btns = false;
            MoveAllClick();
        }
        if (quiz1start)
        {
            quiz1start = false;

            GameObject.Find("AR1C1_4").GetComponent<AR1_InteractionController>().Text();
        }

        if (green && red && blue && purple == true)
        {
            forQ2 = true;
        }
        if (AR1C1_ForBackGround2.Instance != null)
        {
            if (AR1C1_ForBackGround2.Instance.forQ3paper == true)
            {
                AR1C1_ForBackGround2.Instance.forQ3paper = false;
                ClicktoPaper();
            }
        }
        if (clickagain == 1)
        {
            clickagain = 0;
            Clickempty.SetActive(true);
            Clickbookcase.SetActive(false);
            if (Q2BookPutText)
            {
                TrytoPutBook();
            }
            MoveAllClick();
        }
        else if (clickagain == 2)
        {
            clickagain = 0;
            Clickempty.SetActive(false);
            Clickbookcase.SetActive(true);
            Q2LookingAround();
            MoveAllClick();
        }

        if (!NextSecretroom)
        {
            if (Q2BookGetText)
            {
                Clickbookcase.SetActive(false);
            }

            if (Q2BookPutText)
            {
                Clickempty.SetActive(false);
            }
        }
    }
    public void TimeStart()
    {
        timer.StartTimer(AR1C1_time[0], AR1C1_time[1]);
    }
    public void MeIn()
    {
        ME.SetActive(true);
        removekey = true;
    }
    public void MeOut()
    {
        ME.SetActive(false);
    }
    public void emptyClicks()
    {
        if (isQ1solved && !Q2BookPutText)
        {
            Clickempty.SetActive(true);
        }
    }
    public void ClicktoPickBooks()
    {
        if (collectingbooks == 1)
        {
            collectingbooks = 0;
            Destroy(CorrectGreen);
            green = true;
            cg = true;
        }
        if (collectingbooks == 2)
        {
            collectingbooks = 0;
            Destroy(CorrectRed);
            red = true;
            cr = true;
        }
        if (collectingbooks == 3)
        {
            collectingbooks = 0;
            Destroy(CorrectBlue);
            blue = true;
            cb = true;
        }
        if (collectingbooks == 4)
        {
            collectingbooks = 0;
            Destroy(CorrectPurple);
            purple = true;
            cp = true;
        }
        if (collectingbooks == 5)
        {
            collectingbooks = 0;
            Destroy(Wrong1);
            w1 = true;
        }
        if (collectingbooks == 6)
        {
            collectingbooks = 0;
            Destroy(Wrong2);
            w2 = true;
        }
        if (collectingbooks == 7)
        {
            collectingbooks = 0;
            Destroy(Wrong3);
            w3 = true;
        }
        if (collectingbooks == 8)
        {
            collectingbooks = 0;
            Destroy(Wrong4);
            w4 = true;
        }
        if (collectingbooks == 9)
        {
            collectingbooks = 0;
            Destroy(Wrong5);
            w5 = true;
        }
        if (collectingbooks == 10)
        {
            collectingbooks = 0;
            Destroy(Wrong6);
            w6 = true;
        }
    }
    public void bookcaseClicks()
    {
        if (isQ1solved && !Q2BookGetText)
        {
            Clickbookcase.SetActive(true);
        }
    }
    public void AR1C1_Popup()
    {
        Popup.SetActive(true);
    }
    public void PopupClose()
    {
        Popup.SetActive(false);
        Maintext.text = "교수의 사무실 안";
    }
    public void aClick()
    {
        Clickempty.SetActive(true);
    }
    public void bClick()
    {
        Clickbookcase.SetActive(true);
    }
    public void MainLeft()
    {
        Move.SetActive(false);
        ToLeft.SetActive(false);
        ToRight.SetActive(true);
        BackBtn.SetActive(true);
        Clickempty.SetActive(false);
        Clickbookcase.SetActive(false);
        Q2LookingAround();
    }
    public void MainEmptycase()
    {
        AfterClick();

        if (isQ1solved == false)
        {
            Clickempty.SetActive(true);
            GameObject.Find("AR1C1_2").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void MoveAllClick()
    {
        ToRight.SetActive(true);
        BackBtn.SetActive(true);
        ToLeft.SetActive(true);
    }
    public void ForQ2Click()
    {
        ToRight.SetActive(true);
        ToLeft.SetActive(true);
    }
    public void AfterClick()
    {
        ToRight.SetActive(true);
        BackBtn.SetActive(true);
        ToLeft.SetActive(true);
        BlockingClick.SetActive(false);
    }
    public void NotMove()
    {
        ToRight.SetActive(false);
        BackBtn.SetActive(false);
        ToLeft.SetActive(false);
    }
    public void MoveFalse()
    {
        Move.SetActive(false);
    }
    public void MainBookcase() //책 있는 책장 클릭했을 때
    {
        AfterClick();

        if (isQ1solved == false)
        {
            Clickbookcase.SetActive(true);
            GameObject.Find("AR1C1_3").GetComponent<AR1_InteractionController>().Text();
        }
        else
        {
            Q2BookGetText = true;
            Clickbookcase.SetActive(false);
            GameObject.Find("AR1C1_10").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void MainRight()
    {
        Move.SetActive(false);
        ToRight.SetActive(false);
        BackBtn.SetActive(true);
        ToLeft.SetActive(true);
        Clickempty.SetActive(false);
        Clickbookcase.SetActive(false);
        Q2LookingAround();
    }
    public void ToMain()
    {
        Move.SetActive(true);
        ToRight.SetActive(!true);
        BackBtn.SetActive(!true);
        ToLeft.SetActive(!true);
        Clickempty.SetActive(false);
        Clickbookcase.SetActive(false);
        Q2Around = false;
        Q2LookingAround();
    }
    public void Q1Start()
    {
        progress = 1;
        Maintext.text = "Quiz 1";

        AR1_Manager.Instance.EnableHintButton(6);

        BlockingClick.SetActive(false);
        Move.SetActive(false);
        Q1.SetActive(true);
        BasicDesk.SetActive(true);

        GameObject.Find("AR1C1_5").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickKey()
    {
        isKeyadded = true;
        if (isPaperadded == true)
        {
            BothDesk.SetActive(true);
            PaperClick.SetActive(false);

            GameObject.Find("AR1C1_6-2").GetComponent<AR1_InteractionController>().Text();
        }
        else
        {
            KeyDesk.SetActive(true);
            KeyClick.SetActive(false);

            GameObject.Find("AR1C1_6-1").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void ClickPaper()
    {
        isPaperadded = true;
        if (isKeyadded == true)
        {
            BothDesk.SetActive(true);
            KeyClick.SetActive(false);

            GameObject.Find("AR1C1_7-2").GetComponent<AR1_InteractionController>().Text();
        }
        else
        {
            PaperDesk.SetActive(true);
            PaperClick.SetActive(false);

            GameObject.Find("AR1C1_7-1").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void Q1End()
    {
        PaperClick.SetActive(false);
        KeyClick.SetActive(false);
        Maintext.text = "교수의 사무실 안";
        AR1_Manager.Instance.DisableHintButton();

        GameObject.Find("AR1C1_8").GetComponent<AR1_InteractionController>().Text();
    }
    public void Inventory_1() //인벤토리 최초로 클릭했을 때 인벤토리 클릭 막아둔 거 없애고 화살표 활성화
    {
        DownPointer.SetActive(true);
        DownPointer.GetComponent<Transform>().position = new Vector3(2.26f, -2.958f, 0f);
        Block_Inven.SetActive(false); AR1_Block.UsingItem = false;
        firstclick = true;
    }
    public void MyBagClick() //인벤토리 클릭해서 들어갔을 때
    {
        forpaper = true;
        Quiz1.SetActive(false);
        Downarrow2.SetActive(true);
        B_F.SetActive(true);
        B_IX.SetActive(true);
    }
    public void MybagOk() //서류를 눌러서 설명창이 활성화 됐을 때
    {
        Destroy(Downarrow1);
        Destroy(Downarrow2);

        Exarrow.SetActive(true);
        B_EX.SetActive(true);
        Block_Inven.SetActive(true);
        Block1.SetActive(false);
        Block2.SetActive(false);
    }
    //서류 끈 건 인벤토리 폴더에 AR1_Detail 스크립트에 있음
    public void MybagClose() //서류 보기 클릭했을 때
    {
        Block_Inven.SetActive(false);
        Destroy(PaperIntend);
        isQ1solved = true;
        MoveD.SetActive(false);
    }
    public void ForBackBtn() //백버튼 활성화 함수
    {
        if (BackBtn.activeSelf == false)
        {
            BackBtn.SetActive(true);
            BackBtn.GetComponent<RectTransform>().position = new Vector3(0, -3.23f, 0);
        }
        BackBtn.SetActive(true);
    }
    public void CloseBackBtn() //백버튼 비활성화 함수
    {
        BackBtn.SetActive(false);
    }
    public void CheckCorrectBook() //퀴즈 2 시작 전에 책장에서 정답 책을 다 주웠는지 체크
    {
        if (forQ2 == true) // 정답책을 다 주운 경우
        {
            GameObject.Find("AR1C1_12").GetComponent<AR1_InteractionController>().Text();
            Q2BookPutText = true;
        }
        else //정답책을 다 줍지 않고 비어있는 책장으로 간 경우
        {
            BlockingClick.SetActive(true);
            GameObject.Find("AR1C1_11").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void TrytoPutBook() //정답책을 다 줍고 빈 책장으로 간 경우
    {
        progress = 2;
        Maintext.text = "Quiz 2";
        AnswerPlace_1.SetActive(true);
        AnswerPlace_2.SetActive(true);
        AnswerPlace_3.SetActive(true);
        AnswerPlace_4.SetActive(true);
        Q2_CancelBtn.SetActive(true);
        Q2_OkBtn.SetActive(true);
        AR1C1_Q2.SetActive(true);
        Q2Around = true;

        AR1_Manager.Instance.EnableHintButton(7);
    }
    public void Q2LookingAround()
    {
        AR1C1_Q2.SetActive(false);
    }
    public void Q2Again()
    {
        AR1C1_Q2.SetActive(true);
        Q2Around = true;
    }
    public void ReturnBooks() //퀴즈 2에서 비우기를 선택한 경우
    {
        AR1_Block.UsingItem = false;
        checkbooks = 0;
        MoveAllClick();
        go1 = GameObject.FindGameObjectsWithTag("UsedBook");
        for (int i = 0; i < go1.Length; i++)
        {
            go1[i].SetActive(false);
            go1[i].tag = "DisusedBook";
            AR1C1_1Answer.ispurple = false;
            AR1C1_2Answer.isgreen = false;
            AR1C1_3Answer.isblue = false;
            AR1C1_4Answer.isred = false;
        }
        isReturn = true;
        if (AnswerPlace_1.activeSelf == false)
        {
            AnswerPlace_1.SetActive(true);
        }
        if (AnswerPlace_2.activeSelf == false)
        {
            AnswerPlace_2.SetActive(true);
        }
        if (AnswerPlace_3.activeSelf == false)
        {
            AnswerPlace_3.SetActive(true);
        }
        if (AnswerPlace_4.activeSelf == false)
        {
            AnswerPlace_4.SetActive(true);
        }
    }
    public void AnswerBooks() //퀴즈 2에서 꽂아보기를 선택한 경우
    {
        AR1_Manager.Instance.DisableHintButton();
        if (AR1C1_1Answer.ispurple && AR1C1_2Answer.isgreen && AR1C1_3Answer.isblue && AR1C1_4Answer.isred == true) //정답일 경우
        {
            Maintext.text = "교수의 사무실 안";
            AR1C1_1Answer.ispurple = false;
            AR1C1_2Answer.isgreen = false;
            AR1C1_3Answer.isblue = false;
            AR1C1_4Answer.isred = false;
            CloseBackBtn();
            Q2_solvedbg.SetActive(true);
            forkey = true;
            Q2_CancelBtn.SetActive(false);
            Q2_OkBtn.SetActive(false);
            AnswerPlace_1.SetActive(false);
            AnswerPlace_2.SetActive(false);
            AnswerPlace_3.SetActive(false);
            AnswerPlace_4.SetActive(false);
            go1 = GameObject.FindGameObjectsWithTag("UsedBook");
            for (int i = 0; i < go1.Length; i++)
            {
                go1[i].SetActive(false);
            }
            isReturn = true;
            NextSecretroom = true;

            GameObject.Find("AR1C1_14").GetComponent<AR1_InteractionController>().Text();
        }
        else //오답일 경우
        {
            Q2Fail = true;
            SoundManager.instance.PlaySFX(Sfx.Security_Alarm);
            GameObject.Find("AR1C1_13").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void ToSecretRoom() //열쇠 구멍에 대면 바로 비밀 사무실로 전환 update에 있음
    {
        Maintext.text = "교수의 비밀공간";
        AR1C1_Office.SetActive(false);
        AR1C1_Q2.SetActive(false);
        AR1C1_Q1.SetActive(false);
        Q2Solved.SetActive(false);
        SecretRoom.SetActive(true);

        MeOut();

        CloseBackBtn();

        GameObject.Find("AR1C1_15").GetComponent<AR1_InteractionController>().Text();
    }

    public void ClickToMap() //지도를 선택했을 경우
    {
        NextSecretroom = true;
        if (!MapClick)
        {
            GameObject.Find("AR1C1_16").GetComponent<AR1_InteractionController>().Text();
        }
        else
        {
            Q5Start();
        }
    }
    public void Q5Start()
    {
        if (isQ3Q4solved == true) //퀴즈5시작
        {
            progress = 5;
            Maintext.text = "Quiz 5";
            MapClick = true;
            Q5Map.SetActive(true);
            Q5Map_text1.SetActive(true);
            AR1_Manager.Instance.EnableHintButton(9);
        }
        else//대화 끝나고 걍 뒤로 가야됨
        {
            ForBackBtn();
        }
    }
    public void ClicktoMap_1() //퀴즈5 다음으로 넘어가는 부분
    {
        Q5Map_text1.SetActive(false);
        Q5Map_text2.SetActive(true);
        Q5Map_text2_1.SetActive(true);
    }
    public void LastText() //마지막 멘트
    {
        Q5Map_text2.SetActive(false);

        GameObject.Find("AR1C1_26").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClicktoMap_final() // Q5 정답 선택지
    {
        Q5Map_text2.SetActive(true);
        Q5Map_text2_1.SetActive(false);
        Q5Map_text2_2.SetActive(true);
        M_btns.SetActive(true);
        if (Q5Around == true)
        {
            Q5Map.SetActive(true);
        }
    }
    public void ClicktoPaper() // 사무실에서 종이를 선택했을 경우
    {
        NextSecretroom = true;
        progress = 3;
        Maintext.text = "Quiz 3";

        GameObject.Find("AR1C1_18").GetComponent<AR1_InteractionController>().Text();
    }
    public void ARPaperSkill()
    {
        Maintext.text = "교수의 비밀공간";
        Q3Skill.SetActive(true);
    }
    public void Q3BtnClick()
    {
        Q3Skill.SetActive(false);

        GameObject.Find("AR1C1_19").GetComponent<AR1_InteractionController>().Text();
    }
    public void ARSkill() //아이란 FX 사용하는 함수
    {
        ar1c1_paper.SetActive(false);
        FireFX.SetActive(true);
        Icon.SetActive(false);
        SoundManager.instance.PlaySFX(Sfx.Magic_Use);
        FireFX.GetComponent<Transform>().position = new Vector3(0, 0, 0);
        Invoke("ARSkillUsed", 0.8f);
    }
    public void ARSkillUsed() //수사일지 나오는 함수
    {
        Q3SkillUsedPaper.SetActive(true);
        Icon.SetActive(true);
        if (isConfidential == true)
        {
            Usedpaper3.text = "수사일지를 확인하세요.";
            OpenBtnText.text = "수사일지 열기";
        }
        else
        {
            Usedpaper3.text = "";
            OpenBtnText.text = "수사일지 찾기";
            Q3Clear = true;
        }
    }
    public void EndSkill()
    {
        Q3SkillUsedPaper.SetActive(false);
        FireFX.SetActive(false);
        isPaper = true;
        if (isConfidential == true)
        {
            progress = 4;
            Maintext.text = "Quiz 4";
            Q4_Black.SetActive(true);
            Q4Bg.SetActive(true);
            Q4Interview.SetActive(true);
        }
        else
        {
            ForBackBtn();

        }
    }
    public void ClicktoConfidential()
    {
        NextSecretroom = true;
        isConfidential = true;
        isCON = true;

        GameObject.Find("AR1C1_20").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClicktoCon_1()
    {
        Q4_Confidential.SetActive(false);

        if (Q3Clear == true)
        {
            GameObject.Find("AR1C1_21").GetComponent<AR1_InteractionController>().Text();
        }
        else
        {
            ForBackBtn();
        }
    }
    public void ClicktoCon_2()
    {
        progress = 4;
        Maintext.text = "Quiz 4";
        Q4_Black.SetActive(true);
        Q4Bg.SetActive(true);
        Q4Interview.SetActive(true);
        Q4Apple.SetActive(false);
        Q4Banana.SetActive(false);
        Q4Cream.SetActive(false);
        Q4Doughnut.SetActive(false);
        AR1_Manager.Instance.EnableHintButton(8);
    }
    public void Q4End()
    {
        Q4Apple.SetActive(false);
        Q4_Black.SetActive(false);
        Maintext.text = "교수의 비밀공간";
        AR1_Manager.Instance.DisableHintButton();
    }
    public void Q4SetActiveFalse()
    {
        Q4Interview.SetActive(false);
        Q4Bg.SetActive(false);
    }
    public void ClickApple()
    {
        Q4SetActiveFalse();
        Q4Apple.SetActive(true);
        isQ3Q4solved = true;

        GameObject.Find("AR1C1_25").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickBanana()
    {
        Q4SetActiveFalse();
        Q4Banana.SetActive(true);
        Q4Fail = true;

        GameObject.Find("AR1C1_22").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickCream()
    {
        Q4SetActiveFalse();
        Q4Cream.SetActive(true);
        Q4Fail = true;

        GameObject.Find("AR1C1_23").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickDoughnut()
    {
        Q4SetActiveFalse();
        Q4Doughnut.SetActive(true);
        Q4Fail = true;

        GameObject.Find("AR1C1_24").GetComponent<AR1_InteractionController>().Text();
    }
    public void ReturntoQ4()
    {
        Q4Bg.SetActive(true);
        Q4Interview.SetActive(true);
        Q4Apple.SetActive(false);
        Q4Banana.SetActive(false);
        Q4Cream.SetActive(false);
        Q4Doughnut.SetActive(false);
        AR1_Manager.Instance.EnableHintButton(8);
    }
    public void ClickCalendar()
    {
        NextSecretroom = true;
        GameObject.Find("AR1C1_17").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickCal_1()
    {
        BigCalendar.SetActive(true);
        ForBackBtn();
    }
    public void ClickCal_2()
    {
        BigCalendar.SetActive(false);
    }
    public void ClickScientia()
    {
        Q5Select = 1;
        Q5Selection();
    }
    public void ClickMedium()
    {
        Q5Select = 2;
        Q5Selection();
    }
    public void ClickReligio()
    {
        Q5Select = 3;
        Q5Selection();
    }
    public void ClickFimbria()
    {
        Q5Select = 4;
        Q5Selection();
    }
    public void Q5Selection()
    {
        Q5Map_text2.SetActive(false);
        Q5_Selection.SetActive(true);
        if (Q5Select == 1)
        {
            Q5_Select_Text.text = "정말로 '스키엔티아'를 선택하시겠습니까?";
        }
        if (Q5Select == 2)
        {
            Q5_Select_Text.text = "정말로 '메디움'을 선택하시겠습니까?";
        }
        if (Q5Select == 3)
        {
            Q5_Select_Text.text = "정말로 '렐리기오'를 선택하시겠습니까?";
        }
        if (Q5Select == 4)
        {
            Q5_Select_Text.text = "정말로 '핌브리아'를 선택하시겠습니까?";
        }
    }
    public void Q5Answer()
    {
        AR1_Manager.Instance.DisableHintButton();
        if (Q5Select == 4)
        {
            Destroy(BackBtn.GetComponent<AR1C1_TouchManager>());
            GameObject.Find("AR1C1_28").GetComponent<AR1_InteractionController>().Text();
        }
        else
        {
            Q5Return();

            GameObject.Find("AR1C1_27").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void Q5Return()
    {
        Q5_Selection.SetActive(false);
        Q5Map_text2.SetActive(true);
        Q5Map.SetActive(true);
        Q5Select = 0;

    }
    public void Q5LookAround()
    {
        Q5_Selection.SetActive(false);
        Q5Map.SetActive(false);
        Q5Map_text2.SetActive(false);
        M_btns.SetActive(false);
        Q5Around = true;
    }
}