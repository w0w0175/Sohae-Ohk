using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class ER1C3_MoveManager : MonoBehaviour
{
    public static ER1C3_MoveManager Instance;
    public Timer timer;

    public TMP_InputField Q3_Answer;
    public TMP_Text MainText;

    public GameObject Icon;
    public GameObject TownBasicBG;
    public GameObject TownLeftBG;
    public GameObject TownRIghtBG;
    public GameObject OldCaseBG;
    public GameObject GrasslandBG;
    public GameObject CaveBG;
    public GameObject CaveinsideBG;
    public GameObject CaveQuizBG;
    public GameObject FootPrintBG;
    public GameObject DeadWolfBG;
    public GameObject LaboratoryBG;
    public GameObject HealthyBigWolfBG;
    public GameObject HealthySmallWolfBG;
    public GameObject LakeBG;
    public GameObject CrossroadBG;
    public GameObject FlamenBG;
    public GameObject PasturelandBG;
    public GameObject FactoryBG;
    public GameObject Black;
    public GameObject Arrows;
    public GameObject BackBtn;
    public GameObject RightBtn;
    public GameObject LeftBtn;
    public GameObject Town_C;
    public GameObject Cave_C;
    public GameObject Laboratory_C;
    public GameObject Medal_Big;
    public GameObject Medal_C;
    public GameObject Medal_Empty;
    public GameObject Medalitem;
    public GameObject Medalfront;
    public GameObject Medalback;
    public GameObject Q1Intro;
    public GameObject Quiz1;
    public GameObject Q2MapBG;
    public GameObject Q2Explain;
    public GameObject Q2Ex_2;
    public GameObject Q2FailBack;
    public GameObject Quiz3Intro;
    public GameObject Quiz3;
    public GameObject Q3_Answers;
    public GameObject Q3_Submit;
    public GameObject LockedGlass;
    public GameObject Glass_C;
    public GameObject Q4Intro;
    public GameObject Q4_Answers;
    public GameObject Q4Btn;
    public GameObject Q4Image;
    public GameObject OpenGlass;
    public GameObject Q4Paper;
    public GameObject FireFX;
    public GameObject Lab_Intro;
    public GameObject LockerQuiz;
    public GameObject LeavesLocker;
    public GameObject LeafImage;
    public GameObject Locker1_C;
    public GameObject Locker2_C;
    public GameObject Locker3_C;
    public GameObject Block1;
    public GameObject Block2;
    public GameObject Block3;
    public GameObject LockerOpenBtn;
    public GameObject EDSkill;
    public GameObject SkillFX;

    public Sprite leaf1;
    public Sprite leaf2;
    public Sprite leaf3;
    public Sprite Remember1;
    public Sprite Remember2;
    public Sprite Remember3;
    public Sprite Remember4;

    public Text Case_1;
    public Text Case_2;
    public Text Case_3;
    public Text Case_4;
    public Text Medaltext;
    public Text Leaftext;
    public Text Q4Text1;
    public Text Q4Text2;
    public Text Q4Text3;
    public Text Q4Text4;

    public bool GetMedal = false;
    public bool Q2Check = false;

    public int progress = 0;

    bool isOldfirst = false;
    bool Q5_1 = false;
    bool Q5_2 = false;
    bool Q5_3 = false;

    int townbg = 0;
    int Q1fail = 0;

    int[] ER1C3_time = new int[] { 8, 0 };

    void Awake()
    {
        if (Instance == null)
            Instance = this;

        BackBtn.AddComponent<ER1C3_TouchManager>();
    }
    void OnDisable()
    {
        Destroy(BackBtn.GetComponent<ER1C3_TouchManager>());
    }
    public void TimeStart()
    {
        timer.StartTimer(ER1C3_time[0], ER1C3_time[1]);
    }
    public void ChapterStart()
    {
        RightBtn.SetActive(true);
        LeftBtn.SetActive(true);
        MainText.text = "터이럼 마을, 마을 회관";
        townbg = 0;
    }
    public void ToMain()
    {
        if (LeavesLocker.activeSelf)
        {
            LeavesLocker.SetActive(false);
            LockerQuiz.SetActive(true);
        }
        else if (LockerQuiz.activeSelf)
        {
            LockerQuiz.SetActive(false);
            Black.SetActive(false);
            Laboratory_C.SetActive(true);
            BackBtn.SetActive(false);
        }
        else
        {
            LaboratoryBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            LaboratoryBG.transform.localScale = new Vector2(1, 1);
            BackBtn.SetActive(false);
            Laboratory_C.SetActive(true);
        }
    }
    public void ClickRightBtn()
    {
        if (townbg == 0)
        {
            TownBasicBG.SetActive(false);
            TownRIghtBG.SetActive(true);
            RightBtn.SetActive(false);
            townbg = 2;
        }
        else
        {
            TownLeftBG.SetActive(false);
            TownBasicBG.SetActive(true);
            LeftBtn.SetActive(true);
            Town_C.SetActive(false);
            townbg = 0;
        }

    }
    public void ClickLeftBtn()
    {
        if (townbg == 0)
        {
            TownBasicBG.SetActive(false);
            TownLeftBG.SetActive(true);
            LeftBtn.SetActive(false);
            Town_C.SetActive(true);
            townbg = 1;
        }
        else
        {
            TownRIghtBG.SetActive(false);
            TownBasicBG.SetActive(true);
            RightBtn.SetActive(true);
            townbg = 0;
        }
    }
    public void ClickMedal()
    {
        Town_C.SetActive(false);
        Black.SetActive(true);
        Medal_Big.SetActive(true);
        Arrows.SetActive(false);
        GetMedal = true;
        Destroy(Medal_C);
        Medal_Empty.SetActive(true);

        GameObject.Find("ER1C3_2").GetComponent<ER1_InteractionController>().Text();
    }
    public void Medal_1()
    {
        Town_C.SetActive(true);
        Black.SetActive(false);
        Medal_Big.SetActive(false);
        Arrows.SetActive(true);
    }
    public void ViewMedal()
    {
        Medalitem.SetActive(true);
        Arrows.SetActive(false);
        Medaltext.text = "뒷면 보기";
    }
    public void CloseMedal()
    {
        ER1_Close.Instance.UsingItem = false;
        Medalback.SetActive(false);
        Medalfront.SetActive(true);
        Medalitem.SetActive(false);
        Arrows.SetActive(true);
    }
    public void TurnMedal()
    {
        if (Medaltext.text == "앞면 보기")
        {
            Medalback.SetActive(false);
            Medalfront.SetActive(true);
            Medaltext.text = "뒷면 보기";
        }
        else
        {
            Medalback.SetActive(true);
            Medalfront.SetActive(false);
            Medaltext.text = "앞면 보기";
        }
    }
    public void ClickCalendar()
    {
        TownLeftBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(600, -1260);
        TownLeftBG.transform.localScale = new Vector3(3, 3, 3);
        Town_C.SetActive(false);
        Arrows.SetActive(false);

        GameObject.Find("ER1C3_7").GetComponent<ER1_InteractionController>().Text();
    }
    public void Calendar_1()
    {
        TownLeftBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        TownLeftBG.transform.localScale = new Vector3(1, 1, 1);
        Town_C.SetActive(true);
        Arrows.SetActive(true);
    }
    public void ClickOldCase()
    {
        OldCaseBG.SetActive(true);
        Town_C.SetActive(false);
        Arrows.SetActive(false);

        if (isOldfirst && progress == 1)
        {
            Quiz1Start();
        }
        else if (isOldfirst && progress == 2)
        {
            Q2MapBG.SetActive(true);
            Black.SetActive(true);
            Q2Ex_2.SetActive(true);
        }
        else
        {
            GameObject.Find("ER1C3_3").GetComponent<ER1_InteractionController>().Text();
            isOldfirst = true;
        }
    }
    public void OldCase_1()
    {
        Q1Intro.SetActive(true);
    }
    public void Quiz1Start()
    {
        Q1Intro.SetActive(false);
        Black.SetActive(true);
        Quiz1.SetActive(true);
        MainText.text = "Quiz 1.";
        progress = 1;
        ER1_Manager.Instance.EnableHintButton(10);
    }
    public void ClickQ1Back()
    {
        Black.SetActive(false);
        Quiz1.SetActive(false);
        OldCaseBG.SetActive(false);
        Town_C.SetActive(true);
        Arrows.SetActive(true);
    }
    public void Q1Result()
    {
        ER1_Manager.Instance.DisableHintButton();
        if (Case_1.text == "S" && Case_2.text == "A" && Case_3.text == "F" && Case_4.text == "E")
        {
            Q2MapBG.SetActive(true);
            Quiz1.SetActive(false);
            MainText.text = "터이럼 마을, 마을 회관";

            GameObject.Find("ER1C3_8").GetComponent<ER1_InteractionController>().Text();
        }
        else
        {
            Black.SetActive(false);
            Quiz1.SetActive(false);
            if (Q1fail == 1)
            {
                GameObject.Find("ER1C3_5").GetComponent<ER1_InteractionController>().Text();
            }
            else
            {
                Q1fail++;
                GameObject.Find("ER1C3_4").GetComponent<ER1_InteractionController>().Text();
            }
        }
    }
    public void Q1Again()
    {
        ER1_Manager.Instance.EnableHintButton(10);
        Case_1.text = "A"; Case_2.text = "A"; Case_3.text = "A"; Case_4.text = "A";
        Black.SetActive(true);
        Quiz1.SetActive(true);
        ER1C3_Q1Manager.Instance.ResetGame();
        if (GrasslandBG.activeSelf)
        {
            GrasslandBG.SetActive(false);
            Q1fail = 0;
        }
    }
    public void Q1Fail()
    {
        GrasslandBG.SetActive(true);

        GameObject.Find("ER1C3_6").GetComponent<ER1_InteractionController>().Text();
    }
    public void BeforeQ2()
    {
        Q2MapBG.SetActive(true);
        Q2Explain.SetActive(true);
    }
    public void Quiz2_1()
    {
        Q2Explain.SetActive(false);

        GameObject.Find("ER1C3_9").GetComponent<ER1_InteractionController>().Text();
    }
    public void Quiz2_2()
    {
        Q2MapBG.AddComponent<ER1C3_Q2Manager>();

        Q2Ex_2.SetActive(true);
        progress = 2;
        ER1_Manager.Instance.EnableHintButton(11);
        MainText.text = "Quiz 2.";
    }
    public void ClickQ2BacktoHall()
    {
        Q2MapBG.SetActive(false);
        Black.SetActive(false);
        Q2Ex_2.SetActive(false);
        OldCaseBG.SetActive(false);
        Town_C.SetActive(true);
        Arrows.SetActive(true);
    }
    public void ClickQ2Confirm()
    {
        if (Q2Check)
        {
            Q2Success();
        }
        else
        {
            Q2Fail();
        }
    }
    public void Q2Success()
    {
        OldCaseBG.SetActive(false);
        Black.SetActive(false);
        Q2MapBG.SetActive(false);
        Q2Ex_2.SetActive(false);
        GrasslandBG.SetActive(true);
        MainText.text = "터이럼 마을";
        ER1_Manager.Instance.DisableHintButton();

        GameObject.Find("ER1C3_38").GetComponent<ER1_InteractionController>().Text();
    }
    public void Q2Success_1()
    {
        GameObject.Find("ER1C3_11").GetComponent<ER1_InteractionController>().Text();
    }
    public void Q2Fail()
    {
        Black.SetActive(false);
        Q2MapBG.SetActive(false);
        Q2Ex_2.SetActive(false);
        GrasslandBG.SetActive(true);
        ER1_Manager.Instance.DisableHintButton();

        GameObject.Find("ER1C3_10").GetComponent<ER1_InteractionController>().Text();
    }
    public void Q2Back()
    {
        Q2FailBack.SetActive(true);
    }
    public void ClickQ2Back()
    {
        ER1_Manager.Instance.EnableHintButton(11);
        GrasslandBG.SetActive(false);
        Q2FailBack.SetActive(false);
        Black.SetActive(true);
        Q2MapBG.SetActive(true);
        Q2Ex_2.SetActive(true);
        Arrows.SetActive(false);
    }
    public void BeforeQ3()
    {
        MainText.text = "터이럼 마을 정중앙, 동굴 입구";
        TownLeftBG.SetActive(false);
        CaveBG.SetActive(true);

        GameObject.Find("ER1C3_12").GetComponent<ER1_InteractionController>().Text();
    }
    public void Q3Intro()
    {
        Quiz3Intro.SetActive(true);
    }
    public void ClickQ3Look()
    {
        Quiz3Intro.SetActive(false);
        Cave_C.SetActive(true);
    }
    public void ClickCaveMark()
    {
        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-315, -353);
        CaveBG.transform.localScale = new Vector3(2, 2, 2);
        Cave_C.SetActive(false);

        GameObject.Find("ER1C3_13").GetComponent<ER1_InteractionController>().Text();
    }
    public void Q3Start()
    {
        Quiz3.SetActive(true);

        GameObject.Find("ER1C3_14").GetComponent<ER1_InteractionController>().Text();
    }
    public void Quiz3_1()
    {
        Q3_Answers.SetActive(true);
        Q3_Submit.SetActive(true);
        progress = 3;
        MainText.text = "Quiz 3.";
        ER1_Manager.Instance.EnableHintButton(12);
    }
    public void Q3Result()
    {
        ER1_Manager.Instance.DisableHintButton();
        if (Q3_Answer.text.ToUpper() == "100BC" || Q3_Answer.text.ToUpper() == "BC100")
        {
            CaveBG.SetActive(false);
            Quiz3.SetActive(false);
            CaveinsideBG.SetActive(true);
            Glass_C.SetActive(true);
            MainText.text = "터이럼 마을, 동굴 내부";

            GameObject.Find("ER1C3_18").GetComponent<ER1_InteractionController>().Text();
        }
        else
        {
            Q3Fail_1();
        }
    }
    public void Q3Again()
    {
        ER1_Manager.Instance.EnableHintButton(12);
        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-315, -353);
        CaveBG.transform.localScale = new Vector3(2, 2, 2);
        Quiz3.SetActive(true);
        Q3_Answer.text = "";
    }
    public void Q3Fail_1()
    {
        Quiz3.SetActive(false);

        GameObject.Find("ER1C3_15").GetComponent<ER1_InteractionController>().Text();
    }
    public void Q3Fail_2()
    {
        StartCoroutine("forShake");
        SoundManager.instance.PlaySFX(Sfx.Blast);
        GameObject.Find("ER1C3_16").GetComponent<ER1_InteractionController>().Text();
    }
    IEnumerator forShake()
    {
        yield return new WaitForSeconds(0.3f);

        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-365, -353);

        yield return new WaitForSeconds(0.1f);

        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-265, -353);

        yield return new WaitForSeconds(0.1f);

        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-365, -353);

        yield return new WaitForSeconds(0.1f);

        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-265, -353);

        yield return new WaitForSeconds(0.1f);

        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-365, -353);

        yield return new WaitForSeconds(0.1f);

        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-265, -353);

        yield return new WaitForSeconds(0.1f);

        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-365, -353);

        yield return new WaitForSeconds(0.1f);

        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-265, -353);

        yield return new WaitForSeconds(0.1f);

        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-365, -353);

        yield return new WaitForSeconds(0.5f);

        CaveBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        CaveBG.transform.localScale = new Vector3(1, 1, 1);

        yield return new WaitForSeconds(0.5f);
        GameObject.Find("ER1C3_17").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickGlass()
    {
        Black.SetActive(true);
        LockedGlass.SetActive(true);

        GameObject.Find("ER1C3_19").GetComponent<ER1_InteractionController>().Text();
    }
    public void CaveInside_1()
    {
        Black.SetActive(false);
        LockedGlass.SetActive(false);
        Glass_C.SetActive(false);
        CaveQuizBG.SetActive(true);
        Q4Intro.SetActive(true);
    }
    public void ClickQ4Confirm()
    {
        Q4Intro.SetActive(false);
        Q4Btn.SetActive(true);
        Q4_Answers.SetActive(true);
        MainText.text = "Quiz 4.";
        progress = 4;
        ER1_Manager.Instance.EnableHintButton(13);
    }
    public void ClickQ4Remember()
    {
        CaveQuizBG.SetActive(false);
        Q4Btn.SetActive(false);
        Q4_Answers.SetActive(false);
        Black.SetActive(true);
        Q4Image.SetActive(true);
        Q4Image.GetComponent<Image>().sprite = Remember1;
        Invoke("Q4Remember_1", 1);
    }
    public void Q4Remember_1()
    {
        Q4Image.GetComponent<Image>().sprite = Remember2;
        Invoke("Q4Remember_2", 1);
    }
    public void Q4Remember_2()
    {
        Q4Image.GetComponent<Image>().sprite = Remember3;
        Invoke("Q4Remember_3", 1);
    }
    public void Q4Remember_3()
    {
        Q4Image.GetComponent<Image>().sprite = Remember4;
        Invoke("Q4Remember_4", 1);
    }
    public void Q4Remember_4()
    {
        Q4Image.SetActive(false);
        Black.SetActive(false);
        CaveQuizBG.SetActive(true);
        Q4Btn.SetActive(true);
        Q4_Answers.SetActive(true);
    }
    public void ClickQ4Submit()
    {
        CaveQuizBG.SetActive(false);
        Q4Btn.SetActive(false);
        Q4_Answers.SetActive(false);
        ER1_Manager.Instance.DisableHintButton();
        if (Q4Text1.text == "8" && Q4Text2.text == "4" && Q4Text3.text == "1" && Q4Text4.text == "1")
        {
            Black.SetActive(true);
            OpenGlass.SetActive(true);
            MainText.text = "터이럼 마을, 동굴 내부";

            GameObject.Find("ER1C3_21").GetComponent<ER1_InteractionController>().Text();
        }
        else
        {
            Black.SetActive(true);
            LockedGlass.SetActive(true);

            GameObject.Find("ER1C3_20").GetComponent<ER1_InteractionController>().Text();
        }
    }
    public void Q4Again()
    {
        ER1_Manager.Instance.EnableHintButton(13);
        Black.SetActive(false);
        LockedGlass.SetActive(false);
        CaveQuizBG.SetActive(true);
        Q4Btn.SetActive(true);
        Q4_Answers.SetActive(true);
        Q4Text1.text = "0"; Q4Text2.text = "0"; Q4Text3.text = "0"; Q4Text4.text = "0";
    }
    public void Q4Paper_1()
    {
        OpenGlass.SetActive(false);
        Q4Paper.SetActive(true);

        GameObject.Find("ER1C3_22").GetComponent<ER1_InteractionController>().Text();
    }
    public void Q4Paper_2()
    {
        FireFX.SetActive(true);
        SoundManager.instance.PlaySFX(Sfx.Magic_Use);
        Icon.SetActive(false);
        Invoke("Q4Paper_3", 0.2f);
    }
    public void Q4Paper_3()
    {
        Q4Paper.SetActive(false);
        Invoke("Q4Paper_4", 2.2f);
    }
    public void Q4Paper_4()
    {
        Black.SetActive(false);
        FireFX.SetActive(false);
        Icon.SetActive(true);

        GameObject.Find("ER1C3_23").GetComponent<ER1_InteractionController>().Text();
    }
    public void BeforeLaboratory()
    {
        CaveinsideBG.SetActive(false);
        FootPrintBG.SetActive(true);
        MainText.text = "터이럼 마을 외곽, 실험실";

        GameObject.Find("ER1C3_24").GetComponent<ER1_InteractionController>().Text();
    }
    public void Investigate()
    {
        FootPrintBG.SetActive(false);
        DeadWolfBG.SetActive(true);

        GameObject.Find("ER1C3_25").GetComponent<ER1_InteractionController>().Text();
    }
    public void LaboratoryStart()
    {
        DeadWolfBG.SetActive(false);
        LaboratoryBG.SetActive(true);

        GameObject.Find("ER1C3_26").GetComponent<ER1_InteractionController>().Text();
    }
    public void Laboratory_1()
    {
        Lab_Intro.SetActive(true);
    }
    public void ClickQ5Make()
    {
        Lab_Intro.SetActive(false);
        Laboratory_C.SetActive(true);
        MainText.text = "Quiz 5.";
        progress = 5;
        ER1_Manager.Instance.EnableHintButton(14);
    }
    public void ClickBookcase()
    {
        Laboratory_C.SetActive(false);
        Black.SetActive(true);
        LockerQuiz.SetActive(true);
        BackBtn.SetActive(true);
    }
    public void ClickResult1()
    {
        Laboratory_C.SetActive(false);
        BackBtn.SetActive(true);
        LaboratoryBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(657, 70);
        LaboratoryBG.transform.localScale = new Vector2(2.5f, 2.5f);
    }
    public void ClickResult2()
    {
        Laboratory_C.SetActive(false);
        BackBtn.SetActive(true);
        LaboratoryBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 529);
        LaboratoryBG.transform.localScale = new Vector2(2.5f, 2.5f);
    }
    public void ClickResult3()
    {
        Laboratory_C.SetActive(false);
        BackBtn.SetActive(true);
        LaboratoryBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-730, 70);
        LaboratoryBG.transform.localScale = new Vector2(2.5f, 2.5f);
    }
    public void ClickLockerLeaf1()
    {
        LeafImage.GetComponent<Image>().sprite = leaf1;
        LockerQuiz.SetActive(false);
        LeavesLocker.SetActive(true);
        Leaftext.text = "";
    }
    public void ClickLockerLeaf2()
    {
        LeafImage.GetComponent<Image>().sprite = leaf2;
        LockerQuiz.SetActive(false);
        LeavesLocker.SetActive(true);
        Leaftext.text = "";
    }
    public void ClickLockerLeaf3()
    {
        LeafImage.GetComponent<Image>().sprite = leaf3;
        LockerQuiz.SetActive(false);
        LeavesLocker.SetActive(true);
        Leaftext.text = "";
    }
    public void Q5Input()
    {
        LockerQuiz.SetActive(true);
        LeavesLocker.SetActive(false);
        if (LeafImage.GetComponent<Image>().sprite == leaf2)
        {
            Locker2_C.SetActive(false);
            Block2.SetActive(true);
            if (Leaftext.text == "7")
            {
                Q5_2 = true;
            }
            else
            {
                Q5_2 = false;
            }
        }
        else if (LeafImage.GetComponent<Image>().sprite == leaf3)
        {
            Locker3_C.SetActive(false);
            Block3.SetActive(true);
            if (Leaftext.text == "5")
            {
                Q5_3 = true;
            }
            else
            {
                Q5_3 = false;
            }
        }
        else
        {
            Locker1_C.SetActive(false);
            Block1.SetActive(true);
            if (Leaftext.text == "3")
            {
                Q5_1 = true;
            }
            else
            {
                Q5_1 = false;
            }
        }
        if (Block1.activeSelf && Block2.activeSelf && Block3.activeSelf)
        {
            LockerOpenBtn.SetActive(true);
        }
    }
    public void Q5Result()
    {
        ER1_Manager.Instance.DisableHintButton();
        if (Q5_1 && Q5_2 && Q5_3)
        {
            Black.SetActive(false);
            BackBtn.SetActive(false);
            LockerQuiz.SetActive(false);
            MainText.text = "터이럼 마을 외곽, 실험실";

            GameObject.Find("ER1C3_28").GetComponent<ER1_InteractionController>().Text();
        }
        else
        {
            Black.SetActive(false);
            BackBtn.SetActive(false);
            LockerQuiz.SetActive(false);

            GameObject.Find("ER1C3_27").GetComponent<ER1_InteractionController>().Text();
        }
    }
    public void Q5Again()
    {
        ER1_Manager.Instance.EnableHintButton(14);
        Black.SetActive(true);
        LockerQuiz.SetActive(true);
        BackBtn.SetActive(true);
        Q5_1 = false; Q5_2 = false; Q5_3 = false;
        Block1.SetActive(false); Block2.SetActive(false); Block3.SetActive(false);
        LockerOpenBtn.SetActive(false);
        Locker1_C.SetActive(true); Locker2_C.SetActive(true); Locker3_C.SetActive(true);
        Leaftext.text = "";
    }
    public void Q5Success()
    {
        LaboratoryBG.SetActive(false);
        HealthyBigWolfBG.SetActive(true);
        EDSkill.SetActive(true);
    }
    public void ClickUseSkill()
    {
        EDSkill.SetActive(false);
        Black.SetActive(true);
        SkillFX.SetActive(true);
        Icon.SetActive(false);
        Invoke("Skill_1", 5.5f);
    }
    public void Skill_1()
    {
        Icon.SetActive(true);
        Black.SetActive(false);
        HealthySmallWolfBG.SetActive(true);
        StartCoroutine("FadeInEffect");
        Invoke("Skill_2", 1.5f);
    }
    IEnumerator FadeInEffect()
    {
        for (float f = 1f; f > 0; f -= 0.01f)
        {
            Color c = HealthyBigWolfBG.GetComponent<Image>().color;
            c.a = f;
            HealthyBigWolfBG.GetComponent<Image>().color = c;

            yield return null;
        }
        HealthyBigWolfBG.SetActive(false);
    }
    public void Skill_2()
    {
        GameObject.Find("ER1C3_29").GetComponent<ER1_InteractionController>().Text();
    }
    public void Outro_1()
    {
        HealthySmallWolfBG.SetActive(false);
        LakeBG.SetActive(true);
        Destroy(BackBtn.GetComponent<ER1C3_TouchManager>());
        MainText.text = "모험의 시작";

        GameObject.Find("ER1C3_30").GetComponent<ER1_InteractionController>().Text();
    }
    public void Outro_2()
    {
        LakeBG.SetActive(false);
        FlamenBG.SetActive(true);

        GameObject.Find("ER1C3_31").GetComponent<ER1_InteractionController>().Text();
    }
    public void Outro_3()
    {
        FlamenBG.SetActive(false);
        PasturelandBG.SetActive(true);

        GameObject.Find("ER1C3_32").GetComponent<ER1_InteractionController>().Text();
    }
    public void Outro_4()
    {
        PasturelandBG.SetActive(false);
        LakeBG.SetActive(true);

        GameObject.Find("ER1C3_33").GetComponent<ER1_InteractionController>().Text();
    }
    public void Outro_5()
    {
        LakeBG.SetActive(false);
        FactoryBG.SetActive(true);

        GameObject.Find("ER1C3_34").GetComponent<ER1_InteractionController>().Text();
    }
    public void Outro_6()
    {
        FactoryBG.SetActive(false);
        LakeBG.SetActive(true);

        GameObject.Find("ER1C3_35").GetComponent<ER1_InteractionController>().Text();
    }
    public void Outro_7()
    {
        LakeBG.SetActive(false);
        CrossroadBG.SetActive(true);

        GameObject.Find("ER1C3_36").GetComponent<ER1_InteractionController>().Text();
    }
}
