using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AR2C4_MoveManager : MonoBehaviour
{
    public static AR2C4_MoveManager Instance;
    public Timer timer;

    public TMP_InputField Q5;

    public GameObject RoomBG;
    public GameObject Black;
    public GameObject ClickEvent;
    public GameObject Backbtn;
    public GameObject LongboxOpen;
    public GameObject Findcriminal;
    public GameObject BacktoFind;
    public GameObject BacktoGod;
    public GameObject Choicegod;
    public GameObject ChoicegodContent;
    public GameObject G_Fail_2;
    public GameObject G_Fail_3;
    public GameObject G_Fail_4;
    public GameObject G_Success;
    public GameObject Bookcase_BG;
    public GameObject ClickEvent_B;
    public GameObject Longbox_B;
    public GameObject Bookcase_Book;
    public GameObject ThirdBox;
    public GameObject Ballroom;
    public GameObject HiddenNotice;
    public GameObject HiddenQuiz;
    public GameObject AR2C4_Trash;
    public GameObject AR2C4_Chandelier;
    public GameObject AR2C4_Longbox;
    public GameObject Invation;
    public GameObject Envelope;

    public GameObject Quiz3;
    public GameObject Q3_1;
    public GameObject Q3_2;
    public GameObject Q3_3;
    public GameObject Q3_4;
    public GameObject Quiz4;
    public GameObject RoomTable;
    public GameObject Letter;
    public GameObject Letter_Big;
    public GameObject Amber;
    public GameObject ForInventory;
    public GameObject PresentBox;
    public GameObject Quiz5;

    public Text FC_Quest_Title;
    public Text G_Quest_Title;
    public Text Book_Content;
    public Text Find_Text;
    public Text God_Text;

    public TMP_Text MainText;

    public bool IsInvation;
    public bool IsEnvelope;
    public int progress = 0;
    public int Forquiz3 = 0;
    public bool ar2c4;
    public bool IsAmber = false;
    public bool Forquiz5 = false;
    public bool ForGod = false;
    public bool Isquiz3 = false;
    public bool IsGun = false;
    public bool IsMaid = false;
    public bool GodING = false;
    public bool Q2Out = false;
    public bool RemoveItems = false;

    bool IsSecond = false;
    bool IsChan = false;
    bool IsThirdBox = false;
    bool IsBookcase = false;
    bool Findcri = false;
    bool Isfindcri = false;
    int ForBook = 0;
    int quizcri = 0;
    int quizgod = 0;
    int trashhint = 0;

    bool Q1Check = false;
    bool Q1In = false;
    bool Q1Out = false;
    bool Q2In = false;

    bool OnlyOne1 = false;
    bool OnlyOne2 = false;
    bool OnlyOne3 = false;
    bool IsGod = false;
    bool outro = false;
    bool chapstart = false;

    int[] AR2C4_time = new int[] { 9, 0 };

    private void OnDisable()
    {
        Destroy(Backbtn.GetComponent<AR2C4_TouchManager>());
        ar2c4 = false;
    }
    void OnEnable()
    {
        if (Instance == null)
            Instance = this;

        Backbtn.AddComponent<AR2C4_TouchManager>();

        ar2c4 = true;

        IsGun = false;
        IsInvation = false;
        IsEnvelope = false;
        IsAmber = false;
        Forquiz5 = false;
        ForGod = false;
        Isquiz3 = false;
        Q2Out = false;
        IsMaid = false;
        GodING = false;

        Forquiz3 = 0;
        progress = 0;

        AR2C4_Quiz4.Q4 = false;
        AR2_Slot.Openold = false;
        AR2_Slot.oldq5 = false;
        AR2_Slot.IsGod = false;
        AR2_Slot.Ispaper = false;
        AR2_Slot.Isplan = false;
        AR2_Slot.Isdiary = false;
    }
    void Update()
    {
        if (Findcriminal.activeSelf || (Choicegod.activeSelf && ChoicegodContent.activeSelf) || outro)
        {
            AR2_Close.UsingItem = true;
        }
        else
        {
            AR2_Close.UsingItem = false;
        }

        if (chapstart)
        {
            if (trashhint == 2 && progress < 2)
            {
                AR2_Manager.Instance.EnableHintButton(11);
            }
            else if (trashhint < 2 && progress < 2)
            {
                AR2_Manager.Instance.EnableHintButton(10);
            }
            else
            {

            }
        }
    }
    public void TimeStart()
    {
        timer.StartTimer(AR2C4_time[0], AR2C4_time[1]);
    }
    public void BackBtnTrue()
    {
        Backbtn.SetActive(true);
    }
    public void BackBtnFalse()
    {
        Backbtn.SetActive(false);
        ClickEvent.SetActive(true);
        ClickEvent_B.SetActive(false);

        if (IsBookcase)
        {
            IsBookcase = false;
            Bookcase_BG.SetActive(false);
        }

        if (IsGun)
        {
            LongboxOpen.SetActive(true);
        }

        if (Q1In && !Q1Out)
        {
            BacktoFind.SetActive(true);
        }

        if (Q2In && !Q2Out)
        {
            BacktoGod.SetActive(true);
        }
    }
    public void ChapterStart()
    {
        ClickEvent.SetActive(true);
        RoomBG.SetActive(true);
        ForGod = true;
        chapstart = true;
        MainText.text = "존스티나 저택, 아이란의 방";

        if (DataController.instance.localData.AR2C1Gun)
        {
            LongboxOpen.SetActive(true);
        }
    }
    public void ClickTrash()
    {
        ClickEvent.SetActive(false);
        BacktoGod.SetActive(false);
        BacktoFind.SetActive(false);
        trashhint++;
        if (IsInvation)
        {

        }
        else
        {
            IsInvation = true;
            SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
        }

        if (IsSecond)
        {
            IsEnvelope = true; Q1Check = true;
            Destroy(AR2C4_Trash.GetComponent<AR2C4_TouchManager>());
            SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
            Black.SetActive(true);
            Envelope.SetActive(true);

            GameObject.Find("AR2C4_2").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            IsSecond = true;
            Black.SetActive(true);
            Invation.SetActive(true);

            GameObject.Find("AR2C4_1").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void FindSuspect()
    {
        Black.SetActive(false);
        Invation.SetActive(false);
        GameObject.Find("AR2C4_1 (1)").GetComponent<AR2_InteractionController>().Text();
    }
    public void TrashCross()
    {
        Black.SetActive(false);
        Envelope.SetActive(false);

        if (Q1Check && IsChan && Findcri == false)
        {
            ++progress;
            FindCriminal();
        }
        else
        {
            BackBtnTrue();

        }
    }
    public void ClickChandelier()
    {
        ClickEvent.SetActive(false);
        IsChan = true;
        BacktoGod.SetActive(false);
        BacktoFind.SetActive(false);
        Destroy(AR2C4_Chandelier.GetComponent<AR2C4_TouchManager>());

        GameObject.Find("AR2C4_3").GetComponent<AR2_InteractionController>().Text();
    }
    public void ChandelierCross()
    {
        if (IsSecond && Findcri == false && Q1Check)
        {
            ++progress;
            FindCriminal();
        }
        else
        {
            BackBtnTrue();
        }
    }
    public void FindCriminal()
    {
        AR2C4_BackgroundManager.Instance.ClicktoMain();
        Isfindcri = true; Q1In = true;
        BacktoFind.SetActive(false);
        Findcriminal.SetActive(true);
        quizcri = progress;
        MainText.text = "Quiz" + quizcri;


        FC_Quest_Title.text = "Quiz " + quizcri + ". 범인 찾기 문제";
        Backbtn.SetActive(false);
        Bookcase_BG.SetActive(false);

        if (!OnlyOne1)
        {
            OnlyOne1 = true;
            //FC_Quest_Title.text = "Quiz " + quizcri + ". 범인 찾기 문제";
            //Find_Text.text = quizcri.ToString();
        }
    }
    public void CriminalAgain()
    {
        IsMaid = false;
        Findcriminal.SetActive(true);
        MainText.text = "Quiz" + quizcri;
        FC_Quest_Title.text = "Quiz " + quizcri + ". 범인 찾기 문제";
        AR2C4_BackgroundManager.Instance.ClicktoMain();
        BacktoFind.SetActive(false);
    }
    public void ClickFC_Close()
    {
        Findcriminal.SetActive(false);
        BackBtnFalse();
        MainText.text = "존스티나 저택, 아이란의 방";

        if (Isfindcri)
        {
            BacktoFind.SetActive(true);
            Find_Text.text = quizcri.ToString();
        }
    }
    public void ClickMaid()
    {
        ClickFC_Close();
        BacktoFind.SetActive(false);
        Isfindcri = false;
        IsMaid = true;

        GameObject.Find("AR2C4_4").GetComponent<AR2_InteractionController>().Text();
    }
    public void ClickButler()
    {
        ClickFC_Close();
        BacktoFind.SetActive(false);
        Isfindcri = false;

        GameObject.Find("AR2C4_5").GetComponent<AR2_InteractionController>().Text();
    }
    public void ButlerCross()
    {
        Findcri = true; Q1Out = true;
        if (progress == 2 && IsGod == false && Findcri)
        {
            Quiz3Start();
        }
    }
    public void ChoiceGodmother()
    {
        AR2C4_BackgroundManager.Instance.ClicktoMain();
        quizgod = progress;
        MainText.text = "Quiz" + quizgod;
        AR2_Manager.Instance.EnableHintButton(12);

        Choicegod.SetActive(true);
        IsGod = true; Q2In = true;
        GodING = true;
        Backbtn.SetActive(false);
        Bookcase_BG.SetActive(false);

        if (!OnlyOne2)
        {
            OnlyOne2 = true;
            G_Quest_Title.text = "Quiz " + quizgod + ". 대모 결정하기";
            God_Text.text = quizgod.ToString();
        }
    }
    public void GodAgain()
    {
        AR2_Manager.Instance.EnableHintButton(12);
        Choicegod.SetActive(true);
        ChoicegodContent.SetActive(true);
        BacktoGod.SetActive(false);
        G_Quest_Title.text = "Quiz " + quizgod + ". 대모 결정하기";
        God_Text.text = quizgod.ToString();
        IsGod = true;
        GodING = true;
        BacktoGod.SetActive(false);

        MainText.text = "Quiz" + quizgod;
        AR2C4_BackgroundManager.Instance.ClicktoMain();
    }
    public void ClickG_Close()
    {
        MainText.text = "존스티나 저택, 아이란의 방";
        GodING = false;
        Choicegod.SetActive(false);
        if (IsGod)
        {
            BacktoGod.SetActive(true);
        }
    }
    public void GodFail2()
    {
        AR2_Manager.Instance.DisableHintButton();
        BacktoGod.SetActive(false);
        IsGod = false;
        ChoicegodContent.SetActive(false);
        Choicegod.SetActive(false);

        GameObject.Find("AR2C4_6_1").GetComponent<AR2_InteractionController>().Text();
    }
    public void GodFail3()
    {
        AR2_Manager.Instance.DisableHintButton();
        BacktoGod.SetActive(false);
        IsGod = false;
        ChoicegodContent.SetActive(false);
        Choicegod.SetActive(false);

        GameObject.Find("AR2C4_7_1").GetComponent<AR2_InteractionController>().Text();
    }
    public void GodFail4()
    {
        AR2_Manager.Instance.DisableHintButton();
        BacktoGod.SetActive(false);
        IsGod = false;
        ChoicegodContent.SetActive(false);
        Choicegod.SetActive(false);

        GameObject.Find("AR2C4_8_1").GetComponent<AR2_InteractionController>().Text();
    }

    public void GodFail_2()
    {
        Choicegod.SetActive(true);
        ChoicegodContent.SetActive(false);
        G_Fail_2.SetActive(true);
    }
    public void GodFail_2_1()
    {
        Choicegod.SetActive(false);
        G_Fail_2.SetActive(false);

        GameObject.Find("AR2C4_6_2").GetComponent<AR2_InteractionController>().Text();
    }
    public void GodFail_3()
    {
        Choicegod.SetActive(true);
        ChoicegodContent.SetActive(false);
        G_Fail_3.SetActive(true);
    }
    public void GodFail_3_1()
    {
        Choicegod.SetActive(false);
        G_Fail_3.SetActive(false);

        GameObject.Find("AR2C4_35").GetComponent<AR2_InteractionController>().Text();
    }
    public void GodFail_3_2()
    {
        GameObject.Find("AR2C4_7_2").GetComponent<AR2_InteractionController>().Text();
    }
    public void GodFail_4()
    {
        Choicegod.SetActive(true);
        ChoicegodContent.SetActive(false);
        G_Fail_4.SetActive(true);
    }
    public void GodFail_4_1()
    {
        Choicegod.SetActive(false);
        G_Fail_4.SetActive(false);

        GameObject.Find("AR2C4_8_2").GetComponent<AR2_InteractionController>().Text();
    }
    public void ChoiceGodSuccess()
    {
        AR2_Manager.Instance.DisableHintButton();
        ClickG_Close();
        BacktoGod.SetActive(false);
        ChoicegodContent.SetActive(false);
        IsGod = false;
        GodING = false;

        GameObject.Find("AR2C4_9_1").GetComponent<AR2_InteractionController>().Text();
    }
    public void GodSuceess_1()
    {
        Choicegod.SetActive(true);
        ChoicegodContent.SetActive(false);
        G_Success.SetActive(true);
    }
    public void GodSuceess_2()
    {
        ClickG_Close();

        GameObject.Find("AR2C4_9_2").GetComponent<AR2_InteractionController>().Text();
    }
    public void Quiz3Cross()
    {
        Q2Out = true;

        if (progress == 2 && Findcri)
        {
            Quiz3Start();
        }
    }
    public void BookcaseOut()
    {
        Bookcase_BG.SetActive(false);
        ClickEvent_B.SetActive(false);

        ClickEvent.SetActive(true);

        IsBookcase = false;
        BackBtnFalse();

        if (IsGun)
        {
            LongboxOpen.SetActive(true);
        }
    }
    public void ClickBookcase()
    {
        Bookcase_BG.SetActive(true);
        ClickEvent.SetActive(false);
        ClickEvent_B.SetActive(true);
        IsBookcase = true;
        BackBtnTrue();

        if (Q1In && !Q1Out)
        {
            BacktoFind.SetActive(true);
        }
        else
        {
            BacktoFind.SetActive(false);
        }

        if (Q2In && !Q2Out)
        {
            BacktoGod.SetActive(true);
        }
        else
        {
            BacktoGod.SetActive(false);
        }

        if (DataController.instance.localData.AR2C1Gun)
        {
            Longbox_B.SetActive(true);
        }

        if (IsGun)
        {
            Longbox_B.SetActive(true);
        }
    }
    public void BookContent()
    {
        ClickEvent_B.SetActive(false);
        ClickEvent.SetActive(false);
        Bookcase_Book.SetActive(true);
        IsBookcase = false;
        Backbtn.SetActive(false);

        if (ForBook == 1)
        {
            ForBook = 0;
            Book_Content.text = "...프레타 후작가를 중심으로 한 서부와, 존스티나 공작가를 중심으로 한 남부는 중앙 사교계와 항상 가까운 관계를 유지했다. 그러나, 건국 초기부터 독자적인 권력 구도를 가지던 북부의 히엠스 공국이나, 다툼 대륙과 활발하게 교류하며 개방적인 문화를 구축한 동부는 중앙 사교계와 다소 원만하지 못한 관계를 유지해온 것이 사실이다.";
        }
        if (ForBook == 2)
        {
            ForBook = 0;
            Book_Content.text = "...이처럼 막대한 힘을 가진 존스티나 공작가를 견제할 수 있을 정도의 세력은, 실질적으로 히엠스 공국밖에 없다. 그러나 히엠스 공국은 거의 중앙 정치에 개입하지 않는다.";
        }
        if (ForBook == 3)
        {
            ForBook = 0;
            Book_Content.text = "...플라멘은 지역의 수장을 플라멘 백작이 아닌, 아에르 대신관이라 지칭할 정도로 종교적인 지역이다. 바람과 자유의 신인 아에르를 섬기는 플라멘이 가장 원리원칙을 중시한다는 게 모순적일 수도 있겠으나...";
        }
        if (ForBook == 4)
        {
            ForBook = 0; OnlyOne3 = true;
            Book_Content.text = "...그렇게 해서, 폭주하던 화이트 드래곤을 잠재우고 우리의 영웅들은 나탈리스 왕국을 건국했다. 초대 국왕이자 빛의 기사, 초대 존스티나 공작이자 불의 마법사, 그리고... 열두 달의 영웅은 모두 신비한 유물을 가지고 있었다. ... 역사 속에서 대부분 자취를 감춘 지 오래... 존스티나 가문은 불의 지팡이를...";
        }
        if (ForBook == 5)
        {
            ForBook = 0;
            Book_Content.text = "...프레타 후작령은 가족주의, 혈통주의 성향이 강하다. 또한 작위가 높지 않더라도, 같은 지역의 귀족들을 잘 챙기는 성향이 있다. ...";
        }
        if (ForBook == 6)
        {
            ForBook = 0;
            Book_Content.text = "...히엠스 공국 사람들은 대체로 불 속성의 마법사를 몹시 선호한다. 공국 특성상 내부에서는 불 속성이 쉽게 발현되지 않는 편이기에, 불 속성의 마법사를 융숭하게 대접하는 편이다.";
        }
    }
    public void BookContent_Close()
    {
        if (!OnlyOne3)
        {
            Bookcase_Book.SetActive(false);
            ClickEvent_B.SetActive(true); ClickEvent.SetActive(false);
            IsBookcase = true;
            BackBtnTrue();

            if (IsThirdBox)
            {
                IsThirdBox = false;
                Destroy(ThirdBox.GetComponent<AR2C4_TouchManager>());
            }
        }
        else
        {
            OnlyOne3 = false; ClickEvent.SetActive(false);
            Bookcase_Book.SetActive(false); ClickEvent.SetActive(false);

            if (IsThirdBox)
            {
                IsThirdBox = false;
                Destroy(ThirdBox.GetComponent<AR2C4_TouchManager>());
            }

            if (DataController.instance.localData.AR2C1Gun)
            {
                GameObject.Find("AR2C4_18").GetComponent<AR2_InteractionController>().Text();
            }
            else
            {
                GameObject.Find("AR2C4_17").GetComponent<AR2_InteractionController>().Text();
            }
        }
    }
    public void ClickFirstLeft()
    {
        //<권력> 발견
        GameObject.Find("AR2C4_10").GetComponent<AR2_InteractionController>().Text();

        ForBook = 1; Backbtn.SetActive(false); ClickEvent.SetActive(false);
    }
    public void ClickFirstRight()
    {
        //<이권탐욕>발견
        GameObject.Find("AR2C4_11").GetComponent<AR2_InteractionController>().Text();

        ForBook = 2; Backbtn.SetActive(false); ClickEvent.SetActive(false);
    }
    public void ClickSecondLeft()
    {
        //<종교역사>
        GameObject.Find("AR2C4_15").GetComponent<AR2_InteractionController>().Text();

        ForBook = 3; Backbtn.SetActive(false); ClickEvent.SetActive(false);
    }
    public void ClickSecondRight()
    {
        //<나탈리스건국대>
        GameObject.Find("AR2C4_16").GetComponent<AR2_InteractionController>().Text();

        ForBook = 4; Backbtn.SetActive(false); ClickEvent.SetActive(false);
    }
    public void ClickThirdLeft()
    {
        //<프레타후작령문화>
        GameObject.Find("AR2C4_13").GetComponent<AR2_InteractionController>().Text();

        ForBook = 5; Backbtn.SetActive(false); ClickEvent.SetActive(false);
    }
    public void ClickThirdRight()
    {
        //<히엠스공국의문화>
        GameObject.Find("AR2C4_12").GetComponent<AR2_InteractionController>().Text();

        ForBook = 6; Backbtn.SetActive(false); ClickEvent.SetActive(false);
    }
    public void ClickThirdBox()
    {
        // 보석상자발견와우
        GameObject.Find("AR2C4_14").GetComponent<AR2_InteractionController>().Text();

        ClickEvent_B.SetActive(false); ClickEvent.SetActive(false);
        Backbtn.SetActive(false);
        IsThirdBox = true;
    }
    public void ClickLongBox()
    {
        ClickEvent_B.SetActive(false); ClickEvent.SetActive(false); AR2C4_Longbox.SetActive(false);
        Backbtn.SetActive(false);

        if (DataController.instance.localData.AR2C1Gun)
        {
            GameObject.Find("AR2C4_22").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            GameObject.Find("AR2C4_19").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void Hiddenquiz()
    {
        HiddenQuiz.SetActive(true);
    }
    public void BoxResult()
    {
        HiddenNotice.SetActive(false);
    }
    public void LockerFail()
    {
        HiddenQuiz.SetActive(false);
        ClickEvent_B.SetActive(true); AR2C4_Longbox.SetActive(false);

        GameObject.Find("AR2C4_20").GetComponent<AR2_InteractionController>().Text();
    }
    public void LockerSuccess()
    {
        HiddenQuiz.SetActive(false);
        ClickEvent_B.SetActive(true); AR2C4_Longbox.SetActive(false);
        Longbox_B.SetActive(true);
        LongboxOpen.SetActive(true);// 열림
        IsGun = true;

        GameObject.Find("AR2C4_21").GetComponent<AR2_InteractionController>().Text();
    }
    public void Quiz3Start()
    {
        chapstart = false;
        MainText.text = "궁정 다과회";
        RoomBG.SetActive(false);
        Bookcase_BG.SetActive(false);
        ClickEvent.SetActive(false);
        Ballroom.SetActive(true);
        RemoveItems = true;

        GameObject.Find("AR2C4_23").GetComponent<AR2_InteractionController>().Text();
    }
    public void Quiz3_1()
    {
        progress = 3;
        MainText.text = "Quiz 3";
        Quiz3.SetActive(true);
        Q3_1.SetActive(true);
        Q3_2.SetActive(false);
    }
    public void Quiz3_2()
    {
        Q3_1.SetActive(false);
        Q3_2.SetActive(true);
        Q3_3.SetActive(false);
    }
    public void Quiz3_3()
    {
        Q3_2.SetActive(false);
        Q3_3.SetActive(true);
        Q3_4.SetActive(false);
    }
    public void Quiz3_4()
    {
        Q3_3.SetActive(false);
        Q3_4.SetActive(true);
        AR2_Manager.Instance.EnableHintButton(14);
    }
    public void Q3Return()
    {
        AR2_Manager.Instance.EnableHintButton(14);
        Quiz3.SetActive(true);
        Q3_4.SetActive(true);
    }
    public void Q3Fail()
    {
        AR2_Manager.Instance.DisableHintButton();
        Quiz3.SetActive(false);
        Q3_4.SetActive(false);

        GameObject.Find("AR2C4_36").GetComponent<AR2_InteractionController>().Text();
    }
    public void Q3Fail_1()
    {
        GameObject.Find("AR2C4_24").GetComponent<AR2_InteractionController>().Text();
    }
    public void Q3Success()
    {
        AR2_Manager.Instance.DisableHintButton();
        Quiz3.SetActive(false);
        MainText.text = "궁정 다과회";

        GameObject.Find("AR2C4_37").GetComponent<AR2_InteractionController>().Text();
    }
    public void Q3Success_1()
    {
        GameObject.Find("AR2C4_25").GetComponent<AR2_InteractionController>().Text();
    }
    public void Q3Success_2()
    {
        GameObject.Find("AR2C4_38").GetComponent<AR2_InteractionController>().Text();
    }
    public void Q3Success_3()
    {
        GameObject.Find("AR2C4_39").GetComponent<AR2_InteractionController>().Text();
    }
    public void Quiz4Start()
    {
        progress = 4;
        MainText.text = "Quiz 4";
        Quiz4.SetActive(true);
        AR2_Manager.Instance.EnableHintButton(13);
    }
    public void Q4Fail()
    {
        Quiz4.SetActive(false);
        AR2_Manager.Instance.DisableHintButton();

        GameObject.Find("AR2C4_26").GetComponent<AR2_InteractionController>().Text();
    }
    public void Q4Success()
    {
        Quiz4.SetActive(false);
        MainText.text = "궁정 다과회";
        AR2_Manager.Instance.DisableHintButton();

        GameObject.Find("AR2C4_27").GetComponent<AR2_InteractionController>().Text();
    }
    public void ReturntoRoom()
    {
        MainText.text = "존스티나 저택, 아이란의 방";
        Ballroom.SetActive(false);
        RoomTable.SetActive(true);
        Letter.SetActive(true);
        PresentBox.SetActive(true);

        GameObject.Find("AR2C4_40").GetComponent<AR2_InteractionController>().Text();
    }
    public void ClickLetter()
    {
        Letter.SetActive(false);
        Black.SetActive(true);
        Letter_Big.SetActive(true);

        GameObject.Find("AR2C4_28").GetComponent<AR2_InteractionController>().Text();
    }
    public void GetAmber()
    {
        Amber.SetActive(true);
        Letter_Big.SetActive(false);

        GameObject.Find("AR2C4_29").GetComponent<AR2_InteractionController>().Text();
    }
    public void BeforeQuiz5()
    {
        Black.SetActive(false);
        Amber.SetActive(false);
        ForInventory.SetActive(true);
        Forquiz5 = true;
    }
    public void BQ5_1()
    {
        ForInventory.SetActive(false);
    }
    public void BQ5_2()
    {
        GameObject.Find("AR2C4_30").GetComponent<AR2_InteractionController>().Text();
    }
    public void BQ5_3()
    {
        PresentBox.AddComponent<AR2C4_TouchManager>();
    }
    public void Quiz5Start()
    {
        Quiz5.SetActive(true);
        Forquiz5 = true;
        progress = 5;
        MainText.text = "Quiz 5";
        Q5.text = "";
        AR2_Manager.Instance.EnableHintButton(15);
    }
    public void Q5Result()
    {
        AR2_Manager.Instance.DisableHintButton();
        Quiz5.SetActive(false);
        if (Q5.text == "60")
        {
            Q5Success();
        }
        else
        {
            Q5Fail();
        }
    }
    public void Q5Fail()
    {
        Quiz5.SetActive(false);
        Forquiz5 = false;
        if (int.Parse(Q5.text) < 60)
        {
            GameObject.Find("AR2C4_31").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            GameObject.Find("AR2C4_32").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void Q5Success()
    {
        Forquiz5 = false;
        MainText.text = "존스티나 저택, 아이란의 방";
        GameObject.Find("AR2C4_33").GetComponent<AR2_InteractionController>().Text();
    }
    public void Outro1()
    {
        PresentBox.SetActive(false);
        outro = true;
        GameObject.Find("AR2C4_34").GetComponent<AR2_InteractionController>().Text();
    }
    public void Outro2()
    {
        RoomTable.SetActive(false);
        RoomBG.SetActive(true);
    }
    public void End()
    {
        Destroy(Backbtn.GetComponent<AR2C4_TouchManager>());
        ar2c4 = false;
    }
}