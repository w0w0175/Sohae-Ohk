using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ER1C1_MovingManager : MonoBehaviour
{
    public static ER1C1_MovingManager Instance;
    public Timer timer;

    public GameObject Choice_2_1;
    public GameObject Choice_2_2;
    public GameObject Choice_3_1;
    public GameObject Choice_3_2;
    public GameObject Choice_3_3;
    public GameObject Choice_2;
    public GameObject Choice_3;
    public GameObject Backbtn;
    public GameObject Icons;

    public GameObject Pasture_M;
    public GameObject Intro;
    public GameObject Pasture_E;
    public GameObject CaveandLake;
    public GameObject Cliff_1;
    public GameObject Cliff_2;
    public GameObject Cottonfield;
    public GameObject Hill;
    public GameObject Click_Hill_Main;
    public GameObject Black;
    public GameObject Meat_Big;
    public GameObject GetGreen;
    public GameObject C_Green;
    public GameObject B_Green;
    public GameObject Rock_Before;
    public GameObject Rock_After;
    public GameObject B_Black;
    public GameObject C_Black;
    public GameObject ErdenSkill;
    public GameObject EDSkillFX;
    public GameObject C_Rock;
    public GameObject PinkBirdBasic;
    public GameObject PinkBirdAngry;
    public GameObject C_PinkSheep;
    public GameObject B_PinkSheep;
    public GameObject C_PinkBird;
    public GameObject ToLC;
    public GameObject Click_LC_Main;
    public GameObject C_Honey;
    public GameObject C_Blue;
    public GameObject C_Lake;
    public GameObject B_Blue;
    public GameObject C_Picture;
    public GameObject C_Inside;
    public GameObject B_Inside;
    public GameObject Bear;
    public GameObject BearRock;
    public GameObject C_Cave;
    public GameObject B_Bearrock;
    public GameObject ToHill;
    public GameObject Wolf;
    public GameObject Cliff_Event;
    public GameObject C_Explain;
    public GameObject C_GEx;
    public GameObject Click_Cotton_Main;
    public GameObject B_Grandpa;
    public GameObject C_Grandpa;
    public GameObject B_Glower;
    public GameObject B_Smile;
    public GameObject B_White;
    public GameObject C_White;
    public GameObject B_Cotton;
    public GameObject C_Cotton;
    public GameObject C_Ladder;
    public GameObject B_Ladder;
    public GameObject Ladder_B;
    public GameObject FinishLadder;
    public GameObject UsedLadder;
    public GameObject ER1C1_Icons;
    public GameObject BClick;
    public GameObject C_LakeClick;
    public GameObject Bee;

    public GameObject GreenSheep;
    public GameObject PinkSheep;
    public GameObject BlackSheep;
    public GameObject BlackSheep2;
    public GameObject BlueSheep;
    public GameObject BrownSheep;
    public GameObject WhiteSheep;
    public GameObject CottonSheep;
    public GameObject YellowSheep;

    public GameObject SheepBasket__;
    public GameObject SheepBasket_0;
    public GameObject SheepBasket_1;
    public GameObject SheepBasket_2;
    public GameObject SheepBasket_3;
    public GameObject SheepBasket_4;
    public GameObject SheepBasket_5;
    public GameObject SheepBasket_6;
    public GameObject SheepBasket_7;
    public GameObject SheepBasket_8;

    public Text C_2_1;
    public Text C_2_2;
    public Text C_3_1;
    public Text C_3_2;
    public Text C_3_3;

    public TMP_Text Maintext;

    public static int SheepBasket = -1;

    public bool Istree = false;
    public bool forMeat = false;
    public bool forGloves = false;
    public bool forRock = false;
    public bool forPB = false;
    public bool forHoney = false;
    public bool forBlue = false;
    public bool forCave = false;
    public bool forGrandpa = false;
    public bool forLadder = false;
    public bool UsingLadder = false;
    public bool forHill = false;
    public bool returnfeed = false;
    public bool honeytrue = false;//꿀을사용했는가?
    public bool meattrue = false;//고기사용했는가? 
    public bool gsheep = false;
    public bool er1c1 = true;
    public bool BearReSet = false;
    public bool UsedGlove = false;
    public bool Used_Ladder = false;
    public bool Used_Bird = false;
    public bool BirdAgain = false;
    public bool Used_Meat = false;
    public bool Used_Honey = false;
    public bool isusedladder = false;

    public int progress = 0;

    bool pinksheep = false;
    bool bearblock = false;
    bool honeyget = false;  //꿀을획득하러갔다왔는가?(획득만하면계속true)
    bool honey = false;     //꿀을획득하러갔다왔는가?(메인화면용:메인화면가면false됨)
    bool cotton = false;
    bool ladder = false;
    bool ladderget = false;
    bool green = false;
    bool cottonfield = false;
    bool birdsuccess = false;
    bool bearsuccess = false;
    bool white = false;
    bool outro = false;
    bool blacksheep = false;
    bool caveCheck = false;
    bool JustOne = false;
    bool Cliff_check = false;

    int[] ER1C1_time = new int[] { 8, 0 };

    void OnDisable()
    {
        er1c1 = false; SheepBasket = -1;
        Destroy(Choice_2_1.GetComponent<ER1C1_TouchManager>());
        Destroy(Choice_2_2.GetComponent<ER1C1_TouchManager>());
        Destroy(Choice_3_1.GetComponent<ER1C1_TouchManager>());
        Destroy(Choice_3_2.GetComponent<ER1C1_TouchManager>());
        Destroy(Choice_3_3.GetComponent<ER1C1_TouchManager>());
        Destroy(Backbtn.GetComponent<ER1C1_TouchManager>());
    }
    void OnEnable()
    {
        if (Instance == null)
            Instance = this;

        Choice_2_1.AddComponent<ER1C1_TouchManager>();
        Choice_2_2.AddComponent<ER1C1_TouchManager>();
        Choice_3_1.AddComponent<ER1C1_TouchManager>();
        Choice_3_2.AddComponent<ER1C1_TouchManager>();
        Choice_3_3.AddComponent<ER1C1_TouchManager>();
        Backbtn.AddComponent<ER1C1_TouchManager>();

        Maintext.text = "목초지 앞";

        Icons.SetActive(true);
        ChapterStart();

        er1c1 = true;
        CliffAgain();
        SheepBasket = -1;

        ER1C1_QuizStart.erdenatstart = 1;
        ER1C1_QuizAnswer.forfailwolfsheep = false;
        ER1C1_QuizAnswer.forfailsheepgrass = false;
        ER1C1_QuizAnswer.ww = false;
        ER1C1_QuizAnswer.ss = false;
        ER1C1_QuizAnswer.gg = false;
    }
    void Update()
    {
        SheepProgress();
        if (isusedladder)
        {
            isusedladder = false;
            White_2();
        }

        if (Choice_2.activeSelf || Choice_3.activeSelf || Black.activeSelf || outro)
        {
            ER1_Close.Instance.UsingItem = true;
        }
        else
        {
            ER1_Close.Instance.UsingItem = false;
        }

        if (BearReSet)
        {
            BearReSet = false;
            C_Cave.SetActive(true);
            B_Bearrock.SetActive(false);
        }
    }
    public void OutroCheck()
    {
        if (SheepBasket == 8)
        {
            SheepBasket = 100;
            Outro();
        }
    }
    public void TimeStart()
    {
        timer.StartTimer(ER1C1_time[0], ER1C1_time[1]);
    }
    public void SheepProgress()
    {
        switch (SheepBasket)
        {
            case -1:
                break;
            case 0:
                SheepBasket_0.SetActive(true);
                break;
            case 1:
                SheepBasket_0.SetActive(false);
                SheepBasket_1.SetActive(true);
                break;
            case 2:
                SheepBasket_1.SetActive(false);
                SheepBasket_2.SetActive(true);
                break;
            case 3:
                SheepBasket_2.SetActive(false);
                SheepBasket_3.SetActive(true);
                break;
            case 4:
                SheepBasket_3.SetActive(false);
                SheepBasket_4.SetActive(true);
                break;
            case 5:
                SheepBasket_4.SetActive(false);
                SheepBasket_5.SetActive(true);
                break;
            case 6:
                SheepBasket_5.SetActive(false);
                SheepBasket_6.SetActive(true);
                break;
            case 7:
                SheepBasket_6.SetActive(false);
                SheepBasket_7.SetActive(true);
                break;
            case 8:
                SheepBasket_7.SetActive(false);
                SheepBasket_8.SetActive(true);
                break;
        }
    }

    #region FalseEvent
    public void FalseButton()
    {
        if (meattrue == false)
        {
            if (forCave)
            {
                Destroy(Choice_2_2.GetComponent<ER1C1_TouchManager>());
                Color color = Choice_2_2.GetComponent<Image>().color;
                color = new Color32(150, 150, 150, 255);
                Choice_2_2.GetComponent<Image>().color = color;
            }
            if (forPB)
            {
                Destroy(Choice_3_1.GetComponent<ER1C1_TouchManager>());
                Color color = Choice_3_1.GetComponent<Image>().color;
                color = new Color32(150, 150, 150, 255);
                Choice_3_1.GetComponent<Image>().color = color;
            }

        }
        else
        {
            if (forCave)
            {
                Color color = Choice_2_2.GetComponent<Image>().color;
                color = new Color32(255, 255, 255, 255);
                Choice_2_2.GetComponent<Image>().color = color;
                if (Choice_2_2.GetComponent<ER1C1_TouchManager>() == null)
                {
                    Choice_2_2.AddComponent<ER1C1_TouchManager>();
                }
                else
                {

                }
            }
            if (forPB)
            {
                Color color = Choice_3_1.GetComponent<Image>().color;
                color = new Color32(255, 255, 255, 255);
                Choice_3_1.GetComponent<Image>().color = color;
                if (Choice_3_1.GetComponent<ER1C1_TouchManager>() == null)
                {
                    Choice_3_1.AddComponent<ER1C1_TouchManager>();
                }
                else
                {

                }
            }

            if (honeyget == false || honeytrue == false)
            {
                if (forCave)
                {
                    Destroy(Choice_2_1.GetComponent<ER1C1_TouchManager>());
                    Color color = Choice_2_1.GetComponent<Image>().color;
                    color = new Color32(150, 150, 150, 255);
                    Choice_2_1.GetComponent<Image>().color = color;
                }
                if (forPB)
                {
                    Destroy(Choice_3_2.GetComponent<ER1C1_TouchManager>());
                    Color color = Choice_3_2.GetComponent<Image>().color;
                    color = new Color32(150, 150, 150, 255);
                    Choice_3_2.GetComponent<Image>().color = color;
                }
            }
            else
            {
                if (forCave)
                {
                    Color color = Choice_2_1.GetComponent<Image>().color;
                    color = new Color32(255, 255, 255, 255);
                    Choice_2_1.GetComponent<Image>().color = color;
                    if (Choice_2_1.GetComponent<ER1C1_TouchManager>() == null)
                    {
                        Choice_2_1.AddComponent<ER1C1_TouchManager>();
                    }
                    else
                    {

                    }
                }
                if (forPB)
                {
                    Color color = Choice_3_2.GetComponent<Image>().color;
                    color = new Color32(255, 255, 255, 255);
                    Choice_3_2.GetComponent<Image>().color = color;
                    if (Choice_3_2.GetComponent<ER1C1_TouchManager>() == null)
                    {
                        Choice_3_2.AddComponent<ER1C1_TouchManager>();
                    }
                    else
                    {

                    }
                }
            }
        }
    }
    #endregion

    public void ChapterStart()
    {
        GameObject.Find("ER1C1_1").GetComponent<ER1_InteractionController>().Text();
    }
    public void ChapterStart_1()
    {
        Black.SetActive(true);
        Meat_Big.SetActive(true);
        forMeat = true;
        meattrue = true;
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);

        GameObject.Find("ER1C1_2").GetComponent<ER1_InteractionController>().Text();
    }
    public void ChapterStart_2()
    {
        Black.SetActive(false);
        Meat_Big.SetActive(false);

        GameObject.Find("ER1C1_3").GetComponent<ER1_InteractionController>().Text();
    }
    public void ChapterStart_3()
    {
        Intro.SetActive(true); Icons.SetActive(false);
    }
    public void ClicktoMain()
    {
        ER1_Manager.Instance.EnableHintButton(1);
        Backbtn.SetActive(false);
        if (Hill.activeSelf)
        {
            Click_Hill_Main.SetActive(true);
            ToLC.SetActive(true);
            PinkBirdBasic.SetActive(false);
            BlackSheep.SetActive(false);
            forPB = false;
            if (blacksheep)
            {
                BlackSheep2.SetActive(true);
                BlackSheep.SetActive(false);
                BClick.SetActive(true);
                if (forRock)
                {
                    C_Rock.SetActive(false);
                    Rock_Before.SetActive(false);
                    Rock_After.SetActive(true);
                    C_Black.SetActive(false);
                }
            }
            else
            {
                BlackSheep2.SetActive(false);

                if (forRock)
                {
                    Destroy(C_Rock);
                    Destroy(Rock_Before);
                    Rock_After.SetActive(true);
                    forRock = false;
                }
            }

            if (Istree)
            {
                if (!gsheep)
                {
                    Destroy(C_Green);
                    Destroy(B_Green);
                    Destroy(GetGreen);
                    Istree = false;
                }
                else
                {
                    GetGreen.SetActive(false);
                    forGloves = false;
                }
            }

            if (birdsuccess)
            {
                Destroy(C_PinkBird);
                Destroy(B_PinkSheep);
                Destroy(C_PinkSheep);
                birdsuccess = false;
            }
        }
        else if (CaveandLake.activeSelf)
        {
            Click_LC_Main.SetActive(true);
            ToHill.SetActive(true);
            forCave = false;
            if (forBlue)
            {
                forBlue = false;
                Destroy(C_Blue);
                Destroy(B_Blue);
                Destroy(C_Lake);
            }
            if (honey)
            {
                honey = false;
                Destroy(C_Honey);
            }
            if (bearblock)
            {
                bearblock = false;
                C_Cave.SetActive(false);
                B_Bearrock.SetActive(true);
                BearRock.SetActive(false);
            }
            if (bearsuccess)
            {
                bearsuccess = false;
                BrownSheep.SetActive(false);
                Destroy(C_Cave);
            }
            if (caveCheck)
            {
                ClickCaveOut();
            }
        }
        if (SheepBasket == 5)
        {
            StartCliff();
            ToLC.SetActive(false);
            ToHill.SetActive(false);
        }
    }
    public void BackBtntrue()
    {
        Backbtn.SetActive(true);
    }

    #region Hill
    public void StartHill()
    {
        ER1_Manager.Instance.EnableHintButton(1);
        Icons.SetActive(true);
        Intro.SetActive(false);
        progress = 1;
        if (SheepBasket == -1)
        {
            SheepBasket = 0;
        }
        Pasture_M.SetActive(false);
        Hill.SetActive(true);
        Click_Hill_Main.SetActive(true);
        CaveandLake.SetActive(false);
        Click_LC_Main.SetActive(false);
        ToLC.SetActive(true);
        ToHill.SetActive(false);
        forHill = true;
        Maintext.text = "목초지 근처 언덕";
    }

    #region RockEvent
    public void ClickRock()
    {
        ToLC.SetActive(false);
        Click_Hill_Main.SetActive(false);
        forRock = true;

        GameObject.Find("ER1C1_4").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickRockAfter()
    {
        ToLC.SetActive(false);
        Click_Hill_Main.SetActive(false);
        BlackSheep2.SetActive(false);
        BClick.SetActive(false);
        C_Black.SetActive(true);
        BackBtntrue();
    }
    public void Rock_1()
    {
        Choice_2.SetActive(true);
        ReturnButtons();
        C_2_1.text = "그래도 밀어보기";
        C_2_2.text = "다른 곳 둘러보기";
    }
    public void Rock_2_2()
    {
        forRock = false;
        Choice_2.SetActive(false);

        GameObject.Find("ER1C1_5").GetComponent<ER1_InteractionController>().Text();
    }
    public void Rock_2_1()
    {
        Choice_2.SetActive(false);
        Rock_Before.SetActive(false);
        Rock_After.SetActive(true);
        C_Black.SetActive(true);

        GameObject.Find("ER1C1_6").GetComponent<ER1_InteractionController>().Text();
    }
    public void Rock_2_1_1()
    {
        ErdenSkill.SetActive(true);
    }
    public void AddSkill()
    {
        ErdenSkill.SetActive(false);
        Black.SetActive(true);
        EDSkillFX.SetActive(true);
        Icons.SetActive(false);
        SheepBasket__.SetActive(false);
        Invoke("SkillFX1", 6.5f);
    }
    public void SkillFX1()
    {
        Black.SetActive(false);
        Icons.SetActive(true);
        SheepBasket__.SetActive(true);
        C_Black.AddComponent<ER1C1_TouchManager>();
        blacksheep = true;
    }
    public void ClickBlack()
    {
        Destroy(C_Black);
        Black.SetActive(true);
        BlackSheep.SetActive(true);
        Backbtn.SetActive(false);

        Invoke("Black_1", 1f);
    }
    public void Black_1()
    {
        Black.SetActive(false);
        BlackSheep.SetActive(false);
        SheepBasket++; blacksheep = false;
        BClick.SetActive(false);

        GameObject.Find("ER1C1_7").GetComponent<ER1_InteractionController>().Text();
    }
    #endregion

    #region TreeEvent
    public void ClickGreenSheep()
    {
        ToLC.SetActive(false);
        Istree = true; gsheep = true; forGloves = false;
        Click_Hill_Main.SetActive(false);

        GameObject.Find("ER1C1_8").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickGreenSheepAfter()
    {
        ToLC.SetActive(false);
        Istree = true;
        Click_Hill_Main.SetActive(false);
        GetGreen.SetActive(true);
        forGloves = true;
        BackBtntrue();
    }
    public void Green_1()
    {
        ER1C1_BackgroundManager.Instance.ClickGreenSheep_1(); forGloves = false;

        GameObject.Find("ER1C1_9").GetComponent<ER1_InteractionController>().Text();
    }
    public void Green_2()
    {
        ER1C1_BackgroundManager.Instance.ClickGreenSheep();
        GetGreen.SetActive(true);
        forGloves = true;
        BackBtntrue();
    }
    public void ClickGetGreen()
    {
        GetGreen.SetActive(true);
        Backbtn.SetActive(false);
        green = true; forGloves = false;
        if (green == false)
        {
            GameObject.Find("ER1C1_10").GetComponent<ER1_InteractionController>().Text();
        }
        else
        {
            GameObject.Find("ER1C1_10").GetComponent<ER1_InteractionController>().Text();
        }
    }
    public void GlovesT()
    {
        forGloves = true;
        Backbtn.SetActive(true);
    }
    public void UsingGloves()
    {
        gsheep = false;
        GetGreen.SetActive(false);
        Backbtn.SetActive(false);

        GameObject.Find("ER1C1_11").GetComponent<ER1_InteractionController>().Text();
    }
    public void Gloves_1()
    {
        Black.SetActive(true);
        GreenSheep.SetActive(true);
        Invoke("Gloves_2", 1f);
    }
    public void Gloves_2()
    {
        Black.SetActive(false);
        GreenSheep.SetActive(false);
        B_Green.SetActive(false);
        SheepBasket++;

        GameObject.Find("ER1C1_12").GetComponent<ER1_InteractionController>().Text();
    }
    #endregion

    #region CloudEvent
    public void ClickPinkSheep()
    {
        ToLC.SetActive(false);
        Click_Hill_Main.SetActive(false);
        pinksheep = true;

        GameObject.Find("ER1C1_13").GetComponent<ER1_InteractionController>().Text();
    }
    #endregion

    #region BirdEvent
    public void ClickPinkBird()
    {
        ToLC.SetActive(false);
        Click_Hill_Main.SetActive(false);
        PinkBirdBasic.SetActive(true);

        GameObject.Find("ER1C1_14").GetComponent<ER1_InteractionController>().Text();
    }
    public void PinkBirdCheck()
    {
        if (pinksheep == false)
        {
            GameObject.Find("ER1C1_15").GetComponent<ER1_InteractionController>().Text();
        }
        else
        {
            Bird_1();
        }
    }
    public void Bird_1()
    {
        PinkBirdBasic.SetActive(false);
        PinkBirdAngry.SetActive(true);
        forPB = true;

        GameObject.Find("ER1C1_16").GetComponent<ER1_InteractionController>().Text();
    }
    public void Bird_2()
    {
        Choice_2.SetActive(true);
        ReturnButtons();
        C_2_1.text = "가서 마저 자라고 한다";
        C_2_2.text = "퐁신새에게 부탁을 해본다";
    }
    public void Bird_3_1()
    {
        Choice_2.SetActive(false);

        GameObject.Find("ER1C1_17").GetComponent<ER1_InteractionController>().Text();
    }
    public void Bird_3_2()
    {
        Choice_2.SetActive(false);

        GameObject.Find("ER1C1_18").GetComponent<ER1_InteractionController>().Text();
    }
    public void Bird_3_2_2()
    {
        PinkBirdBasic.SetActive(false);
        PinkBirdAngry.SetActive(false);
        Choice_3.SetActive(true);
        FalseButton();

        C_3_1.text = "고기를 준다";
        C_3_2.text = "꿀을 준다";
        C_3_3.text = "새모이를 준다";
    }
    public void Bird_3_2_2_3() // 새모이를 준다.
    {
        Choice_3.SetActive(false);
        PinkBirdAngry.SetActive(true);

        returnfeed = true;
        Used_Bird = true;

        GameObject.Find("ER1C1_19").GetComponent<ER1_InteractionController>().Text();
    }
    public void Bird_3_2_2_3_1()
    {
        PinkBirdAngry.SetActive(false);

        GameObject.Find("ER1C1_20").GetComponent<ER1_InteractionController>().Text();
    }
    public void Bird_3_2_2_2()
    {
        Choice_3.SetActive(false);
        PinkBirdAngry.SetActive(true);
        honeytrue = false;
        Used_Honey = true;

        GameObject.Find("ER1C1_21").GetComponent<ER1_InteractionController>().Text();
    }
    public void Bird_3_2_2_2_1()
    {
        PinkBirdAngry.SetActive(false);
        PinkBirdBasic.SetActive(true);

        GameObject.Find("ER1C1_22").GetComponent<ER1_InteractionController>().Text();
    }
    public void Bird_3_2_2_2_2()
    {
        if (meattrue == false && honeyget && honeytrue == false)
        {
            GameObject.Find("ER1C1_24").GetComponent<ER1_InteractionController>().Text();
            meattrue = true;
            honeytrue = true;
        }
        else
        {
            GameObject.Find("ER1C1_23").GetComponent<ER1_InteractionController>().Text();
        }
    }
    public void PinkBirdBasicOut()
    {
        PinkBirdBasic.SetActive(false);
        BackBtntrue();
    }
    public void Bird_3_2_2_1()
    {
        Choice_3.SetActive(false);
        PinkBirdAngry.SetActive(true);
        meattrue = false;
        Used_Meat = true;

        GameObject.Find("ER1C1_25").GetComponent<ER1_InteractionController>().Text();
    }
    public void Bird_3_2_2_1_1()
    {
        PinkBirdAngry.SetActive(false);
        PinkBirdBasic.SetActive(true);

        GameObject.Find("ER1C1_26").GetComponent<ER1_InteractionController>().Text();
    }
    public void Bird_3_2_2_1_2()
    {
        GameObject.Find("ER1C1_27").GetComponent<ER1_InteractionController>().Text();
    }
    public void Bird4()
    {
        PinkBirdBasic.SetActive(false);

        GameObject.Find("ER1C1_28").GetComponent<ER1_InteractionController>().Text();
    }
    public void Bird_3_2_2_1_3()
    {
        Black.SetActive(true);
        PinkSheep.SetActive(true);
        Invoke("Bird_3_2_2_1_4", 1f);
    }
    public void Bird_3_2_2_1_4()
    {
        Black.SetActive(false);
        PinkSheep.SetActive(false);
        birdsuccess = true;
        SheepBasket++;

        GameObject.Find("ER1C1_29").GetComponent<ER1_InteractionController>().Text();
    }
    #endregion

    #endregion

    #region LakeandCave
    public void ClickLakeandCave()
    {
        Hill.SetActive(false);
        Click_Hill_Main.SetActive(false);
        CaveandLake.SetActive(true);
        Click_LC_Main.SetActive(true);
        ToLC.SetActive(false);
        forHill = false;
        Maintext.text = "동굴과 호수";

        GameObject.Find("ER1C1_30").GetComponent<ER1_InteractionController>().Text();
    }
    public void ToMainBtn()
    {
        ToHill.SetActive(true);
    }

    #region LakeEvent
    public void ClickLake()
    {
        ToHill.SetActive(false);
        Click_LC_Main.SetActive(false);
        C_Blue.SetActive(true);
        B_Blue.SetActive(false);
        forBlue = true;

        GameObject.Find("ER1C1_31").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickBlueSheep()
    {
        SoundManager.instance.PlaySFX(Sfx.Water_Drop);
        C_LakeClick.SetActive(false);
        Black.SetActive(true);
        BlueSheep.SetActive(true);
        C_Blue.SetActive(false);
        Invoke("Blue_1", 1f);
    }
    public void Blue_1()
    {
        Black.SetActive(false);
        BlueSheep.SetActive(false);
        SheepBasket++;

        GameObject.Find("ER1C1_32").GetComponent<ER1_InteractionController>().Text();
    }
    #endregion

    #region HoneyEvent
    public void ClickHoney()
    {
        ToHill.SetActive(false);
        Click_LC_Main.SetActive(false);
        Bee.SetActive(true);
        honeytrue = true;
        forHoney = true;
        honey = true;
        honeyget = true;
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);

        GameObject.Find("ER1C1_33").GetComponent<ER1_InteractionController>().Text();
    }
    public void HoneyAdd()
    {
        Bee.SetActive(false);
        BackBtntrue();
    }
    #endregion

    #region CaveEvent
    public void ClickCave()
    {
        ER1_Manager.Instance.DisableHintButton();
        ToHill.SetActive(false);
        Click_LC_Main.SetActive(false);
        C_Picture.SetActive(true);
        C_Inside.SetActive(true); caveCheck = true;

        if (!JustOne)
        {
            JustOne = true;

            GameObject.Find("ER1C1_34").GetComponent<ER1_InteractionController>().Text();
        }
        else
        {
            BackBtntrue();
        }
    }
    public void ClickCaveOut()
    {
        ToHill.SetActive(true);
        Click_LC_Main.SetActive(true);
        C_Picture.SetActive(false);
        C_Inside.SetActive(false);
    }
    public void ClickPicture()
    {
        C_Picture.SetActive(false);
        C_Inside.SetActive(false);
        B_Inside.SetActive(true);
        Backbtn.SetActive(false);

        GameObject.Find("ER1C1_35").GetComponent<ER1_InteractionController>().Text();
    }
    public void Picture_1()
    {
        C_Picture.SetActive(true);
        C_Inside.SetActive(true);
        B_Inside.SetActive(false);
        ER1C1_BackgroundManager2.Instance.ClickCave();
        BackBtntrue();
    }
    public void ClickInside()
    {
        ER1_Manager.Instance.EnableHintButton(2);
        C_Picture.SetActive(false);
        C_Inside.SetActive(false);
        B_Inside.SetActive(true);
        Backbtn.SetActive(false);

        if (meattrue == false && honeytrue == false)
        {
            GameObject.Find("ER1C1_36").GetComponent<ER1_InteractionController>().Text();
        }
        else
        {
            forCave = true;
            FalseButton();
            Choice_2.SetActive(true);
            C_2_1.text = "꿀을 준다";
            C_2_2.text = "고기를 준다";
        }
    }
    public void CaveAgain()
    {
        ER1_Manager.Instance.EnableHintButton(2);
        forCave = true;
        honeytrue = true;
        FalseButton();
        BearRock.SetActive(false);
        Choice_2.SetActive(true);
        C_2_1.text = "꿀을 준다";
        C_2_2.text = "고기를 준다";
    }
    public void Inside_2()
    {
        Choice_2.SetActive(false);
        meattrue = false;

        GameObject.Find("ER1C1_37").GetComponent<ER1_InteractionController>().Text();

        Used_Meat = true;
    }
    public void Inside_2_1()
    {
        BearRock.SetActive(true);
        bearblock = true;

        GameObject.Find("ER1C1_38").GetComponent<ER1_InteractionController>().Text();
    }
    public void InsideFail()
    {
        ER1_Manager.Instance.DisableHintButton();
        if (honeyget && honeytrue == false && meattrue == false)
        {
            GameObject.Find("ER1C1_39").GetComponent<ER1_InteractionController>().Text();
            meattrue = true;
            honeytrue = true;
        }
        else
        {
            bearblock = true;
            BackBtntrue();
        }
    }
    public void Inside_1()
    {
        Choice_2.SetActive(false);
        honeytrue = false;

        GameObject.Find("ER1C1_40").GetComponent<ER1_InteractionController>().Text();

        Used_Honey = true;
    }
    public void Inside_1_1()
    {
        B_Inside.SetActive(false);
        Bear.SetActive(true);
        Invoke("Inside_1_2", 0.5f);
    }
    public void Inside_1_2()
    {
        GameObject.Find("ER1C1_41").GetComponent<ER1_InteractionController>().Text();
    }
    public void Inside_1_3()
    {
        Black.SetActive(true);
        BrownSheep.SetActive(true);
        Bear.SetActive(false);
        Invoke("Inside_1_4", 1f);
    }
    public void Inside_1_4()
    {
        Black.SetActive(false);
        BrownSheep.SetActive(false);
        bearsuccess = true;
        SheepBasket++;

        GameObject.Find("ER1C1_42").GetComponent<ER1_InteractionController>().Text();
    }
    #endregion

    #endregion

    #region CliffEvent
    public void StartCliff()
    {
        ER1_Manager.Instance.DisableHintButton();
        Used_Bird = true;
        Hill.SetActive(false);
        CaveandLake.SetActive(false);
        Click_LC_Main.SetActive(false);
        Click_Hill_Main.SetActive(false);
        Cliff_1.SetActive(true);
        Backbtn.SetActive(false);

        GameObject.Find("ER1C1_43").GetComponent<ER1_InteractionController>().Text();

        Maintext.text = "절벽";
    }
    public void CliffWolf()
    {
        Black.SetActive(true);
        Wolf.SetActive(true);
        Backbtn.SetActive(false);

        GameObject.Find("ER1C1_44").GetComponent<ER1_InteractionController>().Text();
    }
    public void CliffWolf_1()
    {
        Black.SetActive(false);
        Backbtn.SetActive(false);

        GameObject.Find("ER1C1_45").GetComponent<ER1_InteractionController>().Text();
    }
    public void CliffQuiz()
    {
        Wolf.SetActive(false);
        progress = 2;
        ER1_Manager.Instance.EnableHintButton(3);
        Cliff_1.SetActive(false);
        Cliff_2.SetActive(true);
        Cliff_Event.SetActive(true);
        Backbtn.SetActive(false);
    }
    public void ClickCliffExplain()
    {
        C_Explain.SetActive(false);
        C_GEx.SetActive(true);
    }
    public void ClickCliffGameExplain()
    {
        C_Explain.SetActive(true);
        C_GEx.SetActive(false);
    }
    public void CliffAgain()
    {

        C_Explain.SetActive(true);
        ER1C1_QuizStart.erdenatstart = 1;
        ER1C1_QuizAnswer.forfailwolfsheep = false;
        ER1C1_QuizAnswer.forfailsheepgrass = false;
        ER1C1_QuizAnswer.ww = false;
        ER1C1_QuizAnswer.ss = false;
        ER1C1_QuizAnswer.gg = false;
        Cliff_check = false;
        if (progress == 2)
        {
            ER1_Manager.Instance.EnableHintButton(3);
        }
    }
    public void CliffFail_SG()
    {
        if (Cliff_check == false)
        {
            Cliff_check = true;
            C_Explain.SetActive(false);
            C_GEx.SetActive(false);
            GameObject.Find("ER1C1_46").GetComponent<ER1_InteractionController>().Text();
        }
    }
    public void CliffFail_WS()
    {
        if (Cliff_check == false)
        {
            Cliff_check = true;
            C_Explain.SetActive(false);
            C_GEx.SetActive(false);
            GameObject.Find("ER1C1_47").GetComponent<ER1_InteractionController>().Text();
        }
    }
    public void CliffSuccess()
    {
        if (Cliff_check == false)
        {
            Cliff_check = true;
            C_Explain.SetActive(false);
            C_GEx.SetActive(false);
            GameObject.Find("ER1C1_48").GetComponent<ER1_InteractionController>().Text();
        }
    }
    #endregion

    #region Cottonfield
    public void StartCotton()
    {
        ER1_Manager.Instance.EnableHintButton(0);
        Maintext.text = "목화밭";
        progress = 3;
        Cliff_2.SetActive(false);
        Cliff_Event.SetActive(false);
        Cottonfield.SetActive(true);
        Click_Cotton_Main.SetActive(true);
        if (forGrandpa)
        {
            forGrandpa = false;
            Destroy(C_Grandpa);
            Destroy(B_Grandpa);
            Destroy(B_Glower);
        }
        if (cotton)
        {
            Destroy(C_Cotton);
            Destroy(B_Cotton);
        }
        if (ladder)
        {
            Destroy(C_Ladder);
            Destroy(B_Ladder);
        }
        if (cottonfield == false)
        {
            cottonfield = true;

            GameObject.Find("ER1C1_49").GetComponent<ER1_InteractionController>().Text();
        }
    }
    public void ReturnButtons()
    {
        Color color = Choice_2_1.GetComponent<Image>().color;
        color = new Color32(255, 255, 255, 255);
        Choice_2_1.GetComponent<Image>().color = color;
        if (Choice_2_1.GetComponent<ER1C1_TouchManager>() == null)
        {
            Choice_2_1.AddComponent<ER1C1_TouchManager>();
        }

        Color color2 = Choice_2_2.GetComponent<Image>().color;
        color2 = new Color32(255, 255, 255, 255);
        Choice_2_2.GetComponent<Image>().color = color;
        if (Choice_2_2.GetComponent<ER1C1_TouchManager>() == null)
        {
            Choice_2_2.AddComponent<ER1C1_TouchManager>();
        }
    }
    public void ClickCottonSheep()
    {
        Click_Cotton_Main.SetActive(false);
        cotton = true;
        Black.SetActive(true);
        CottonSheep.SetActive(true);
        C_Cotton.SetActive(false);
        Invoke("Cotton_1", 1f);
    }
    public void Cotton_1()
    {
        Black.SetActive(false);
        CottonSheep.SetActive(false);
        SheepBasket++;

        GameObject.Find("ER1C1_50").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickGrandpa()
    {
        Click_Cotton_Main.SetActive(false);
        B_Grandpa.SetActive(true);
        forGrandpa = true;

        GameObject.Find("ER1C1_51").GetComponent<ER1_InteractionController>().Text();
    }
    public void Grandpa_1()
    {
        Choice_2.SetActive(true);
        ReturnButtons();
        B_Grandpa.SetActive(true);
        B_Glower.SetActive(false);
        C_2_1.text = "인사한다";
        C_2_2.text = "몰래 수염만 뒤져본다";
    }
    public void Grandpa_1_2()
    {
        Choice_2.SetActive(false);
        B_Grandpa.SetActive(false);
        B_Glower.SetActive(true);

        GameObject.Find("ER1C1_52").GetComponent<ER1_InteractionController>().Text();
    }
    public void Grandpa_1_1()
    {
        Choice_2.SetActive(false);
        B_Grandpa.SetActive(false);
        B_Smile.SetActive(true);

        GameObject.Find("ER1C1_53").GetComponent<ER1_InteractionController>().Text();
    }
    public void Grandpa_1_1_1()
    {
        B_Smile.SetActive(true);
        Black.SetActive(true);
        YellowSheep.SetActive(true);
        Invoke("Grandpa_1_1_2", 1f);
    }
    public void Grandpa_1_1_2()
    {
        B_Smile.SetActive(true);
        Black.SetActive(false);
        YellowSheep.SetActive(false);
        SheepBasket++;

        GameObject.Find("ER1C1_54").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickLadder()
    {
        Click_Cotton_Main.SetActive(false);
        forLadder = true;
        if (forLadder == false)
        {
            forLadder = true;
        }
        ladder = true;
        ladderget = true;
        C_Ladder.SetActive(false);
        B_Ladder.SetActive(false);
        Black.SetActive(true);
        Ladder_B.SetActive(true);
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);

        GameObject.Find("ER1C1_55").GetComponent<ER1_InteractionController>().Text();
    }
    public void Ladder_1()
    {
        Black.SetActive(false);
        Ladder_B.SetActive(false);
        if (forLadder == false)
        {
            forLadder = true;
        }
        if (white == false)
        {

        }
        else
        {
            UsingLadder = true;
        }
        GameObject.Find("ER1C1_56").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickWhiteSheep()
    {
        Click_Cotton_Main.SetActive(false);

        GameObject.Find("ER1C1_57").GetComponent<ER1_InteractionController>().Text();
    }
    public void White_1()
    {
        white = true;
        if (UsingLadder == false)
        {
            UsingLadder = true;
        }
        GameObject.Find("ER1C1_58").GetComponent<ER1_InteractionController>().Text();
    }
    public void WhiteCross()
    {
        if (UsingLadder)
        {
            GameObject.Find("ER1C1_58").GetComponent<ER1_InteractionController>().Text();
        }
        else
        {
            StartCotton();
        }
    }
    public void White_2()
    {
        Destroy(FinishLadder);
        UsedLadder.SetActive(true);

        GameObject.Find("ER1C1_59").GetComponent<ER1_InteractionController>().Text();
    }
    public void White_3()
    {
        Click_Cotton_Main.SetActive(false);
        B_White.SetActive(false);
        C_White.SetActive(false);
        Black.SetActive(true);
        WhiteSheep.SetActive(true);
        Invoke("White_4", 1f);
    }
    public void White_4()
    {
        Black.SetActive(false);
        WhiteSheep.SetActive(false);
        SheepBasket++;
        ER1_Close.Instance.UsingItem = false;

        GameObject.Find("ER1C1_60").GetComponent<ER1_InteractionController>().Text();
    }
    #endregion
    public void Outro()
    {
        ER1_Manager.Instance.DisableHintButton();

        outro = true;
        Maintext.text = "목초지 앞";
        Cottonfield.SetActive(false);
        ER1C1_Icons.SetActive(false);
        Pasture_E.SetActive(true);

        GameObject.Find("ER1C1_61").GetComponent<ER1_InteractionController>().Text();
    }
    public void End()
    {
        er1c1 = false; progress = 0; SheepBasket = -1;
        Destroy(Choice_2_1.GetComponent<ER1C1_TouchManager>());
        Destroy(Choice_2_2.GetComponent<ER1C1_TouchManager>());
        Destroy(Choice_3_1.GetComponent<ER1C1_TouchManager>());
        Destroy(Choice_3_2.GetComponent<ER1C1_TouchManager>());
        Destroy(Choice_3_3.GetComponent<ER1C1_TouchManager>());
        Destroy(Backbtn.GetComponent<ER1C1_TouchManager>());
    }
}