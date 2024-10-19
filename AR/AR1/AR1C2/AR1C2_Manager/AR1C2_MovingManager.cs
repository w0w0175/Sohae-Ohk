using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AR1C2_MovingManager : MonoBehaviour
{
    public static AR1C2_MovingManager Instance;
    public Timer timer;

    public GameObject Intro1;
    public GameObject Intro2;
    public GameObject onClick;
    public GameObject FimStreetBg;
    public GameObject Choice1;
    public GameObject Choice1_1;
    public GameObject Choice2;
    public GameObject Choice2_1;
    public GameObject Choice2_2;
    public GameObject InformBg;
    public GameObject AR1C2_Q1;
    public GameObject EmptyBg;
    public GameObject ARSeated;
    public GameObject ARSeated_Shadow;
    public GameObject Lipstic;
    public GameObject AR1C2_Q2;
    public GameObject AR1C2_Q2Btn;
    public GameObject SuspectA;
    public GameObject SuspectB;
    public GameObject AR1C2_Q2Man;
    public GameObject AR1C2_Q2Woman;
    public GameObject AR1C2_Q2_Btn;
    public GameObject Q2Toggle;
    public GameObject Black;
    public GameObject ARSkill_2;
    public GameObject Skill2FX;
    public GameObject AR1C2_Q3;
    public GameObject Skill3FX;
    public GameObject ARSkill_3;
    public GameObject AR_Shot;
    public GameObject AR1C2_Q4;
    public GameObject HideoutBg;
    public GameObject AR1C2_Q5;
    public GameObject Q5_Select;
    public GameObject Icon;

    public Text Choice1text;
    public Text C2text_1;
    public Text C2text_2;
    public Text Q5text;
    public TMP_Text Maintext;

    public Button Q2Btn_Control;

    [SerializeField] GameObject SystemTextbox_Default;
    [SerializeField] GameObject TextBox_System_Btn;

    public bool forQ2 = false;
    public bool forQ4 = false;
    public bool forQ2point5 = false;
    public bool forQ1 = false;
    public bool CheckQ2 = false;

    public int progress = 0;

    bool CheckQ2_W = false, CheckQ2_M = false;
    int CheckQ5 = 0;

    int[] AR1C2_time = new int[] { 9, 0 };

    private void OnDisable()
    {
        progress = 0;
        Destroy(Choice1_1.GetComponent<AR1C2_TouchManager>());
        Destroy(Choice2_1.GetComponent<AR1C2_TouchManager>());
        Destroy(Choice2_2.GetComponent<AR1C2_TouchManager>());
    }
    void OnEnable()
    {
        if (Instance == null)
            Instance = this;

        Intro_1();

        Choice1_1.AddComponent<AR1C2_TouchManager>();
        Choice2_1.AddComponent<AR1C2_TouchManager>();
        Choice2_2.AddComponent<AR1C2_TouchManager>();
    }
    private void Update()
    {
        if (CheckQ2_W == true && CheckQ2_M == true)
        {
            CheckQ2 = true;
        }

        if (CheckQ2)
        {
            Q2Btn_Control.interactable = true;
        }
        else
        {
            Q2Btn_Control.interactable = false;
        }

        if (AR1C2_Intro.formaintext)
        {
            AR1C2_Intro.formaintext = false;
            Maintext.text = "핌브리아 거리의 골목";
        }
    }
    public void TimeStart()
    {
        timer.StartTimer(AR1C2_time[0], AR1C2_time[1]);
    }
    public void Intro()
    {
        Intro1.SetActive(false);
        Intro2.SetActive(true);
        onClick.SetActive(false);
    }
    public void Intro_1()
    {
        Intro2.SetActive(false);
        FimStreetBg.SetActive(true);
        onClick.SetActive(true);
    }
    public void Intro_2()
    {
        onClick.SetActive(false);
        GameObject.Find("AR1C2_2").GetComponent<AR1_InteractionController>().Text();
    }
    public void ToInform()
    {
        Choice1.SetActive(true);
        Choice1text.text = "정보상으로 이동하기";
    }
    public void Inform_1()
    {
        Choice1.SetActive(false);
        InformBg.SetActive(true);
        SoundManager.instance.PlaySFX(Sfx.Door_Bell);

        GameObject.Find("AR1C2_3").GetComponent<AR1_InteractionController>().Text();
    }
    public void Inform_2()
    {
        Choice2.SetActive(true);
        C2text_1.text = "말없이 신분증을 보여준다.";
        C2text_2.text = "내가 누군지 모르냐고\n화를 낸다.";
    }
    public void ShowID()
    {
        Choice2.SetActive(false);

        GameObject.Find("AR1C2_5").GetComponent<AR1_InteractionController>().Text();
    }
    public void Pissedoff()
    {
        Choice2.SetActive(false);

        GameObject.Find("AR1C2_4").GetComponent<AR1_InteractionController>().Text();
    }
    public void AR1C2_Q1Start()
    {
        AR1C2_Q1.SetActive(true);
        progress = 1;
        Maintext.text = "Quiz 1";
        forQ1 = true;
        AR1_Manager.Instance.EnableHintButton(10);

        GameObject.Find("AR1C2_6").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q1_134A()
    {
        AR1C2_Q1.SetActive(false);
        InformBg.SetActive(false);
        FimStreetBg.SetActive(true);
        EmptyBg.SetActive(true);
        AR1_Manager.Instance.DisableHintButton();

        GameObject.Find("AR1C2_8").GetComponent<AR1_InteractionController>().Text();
        ARBlackSeating();
    }
    public void Q1_Fail()
    {
        TextBox_System_Btn.SetActive(false);
        AR1_Manager.Instance.DisableHintButton();

        GameObject.Find("AR1C2_7").GetComponent<AR1_InteractionController>().Text();

        AR1_Result.Instance.FailStatue();
    }
    public void Q1_Again()
    {
        GameObject.Find("AR1C2_33").GetComponent<AR1_InteractionController>().Text();
        AR1_Manager.Instance.EnableHintButton(10);
    }
    public void ARBlackSeating()
    {
        Maintext.text = "핌브리아 거리의 골목";
        forQ1 = false;
        ARSeated_Shadow.SetActive(true);
        forQ2 = true;
    }
    public void Q2_Choice2()
    {
        forQ2point5 = true;
        Choice2.SetActive(true);
        C2text_1.text = "노크하고 들어간다.";
        C2text_2.text = "대화를 몰래 엿듣는다.";
    }
    public void Q2_WalkIn()
    {
        Choice2.SetActive(false);
        ARSeated_Shadow.SetActive(false);

        GameObject.Find("AR1C2_9").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q2_Listening()
    {
        Choice2.SetActive(false);
        forQ2point5 = false;
        GameObject.Find("AR1C2_10").GetComponent<AR1_InteractionController>().Text();
    }
    public void ARSeating1()
    {
        ARSeated.SetActive(true);
        ARSeated_Shadow.SetActive(false);

        GameObject.Find("AR1C2_11").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q2_Listening2()
    {
        ARSeated.SetActive(false);
        ARSeated_Shadow.SetActive(true);
        Lipstic.SetActive(true);

        GameObject.Find("AR1C2_12").GetComponent<AR1_InteractionController>().Text();
    }
    public void ARSeating2()
    {
        ARSeated.SetActive(true);
        ARSeated_Shadow.SetActive(false);

        GameObject.Find("AR1C2_13").GetComponent<AR1_InteractionController>().Text();
    }
    public void AR1C2_Q2Start()
    {
        progress = 2;
        Maintext.text = "Quiz 2";
        Lipstic.SetActive(false);
        ARSeated_Shadow.SetActive(true);
        ARSeated.SetActive(false);
        AR1C2_Q2.SetActive(true);
        AR1C2_Q2Btn.GetComponent<Image>().raycastTarget = false;

        GameObject.Find("AR1C2_14").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q2_ClickWoman()
    {
        SuspectA.SetActive(true);
        ARSeated.SetActive(true);
        ARSeated_Shadow.SetActive(false);
        CheckQ2_W = true;

        GameObject.Find("AR1C2_15").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q2_ClickMan()
    {
        SuspectB.SetActive(true);
        ARSeated.SetActive(true);
        ARSeated_Shadow.SetActive(false);
        CheckQ2_M = true;

        GameObject.Find("AR1C2_16").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q2SuspectActivefalse()
    {
        SuspectA.SetActive(false);
        SuspectB.SetActive(false);
    }
    public void AR1C2_Q2Answer()
    {
        AR1C2_Q2Man.SetActive(false);
        AR1C2_Q2Woman.SetActive(false);
        AR1C2_Q2_Btn.SetActive(false);
        Q2Toggle.SetActive(true);
        ARSeated.SetActive(false);
        ARSeated_Shadow.SetActive(false);
        SystemTextbox_Default.SetActive(false);
        AR1_Manager.Instance.EnableHintButton(11);
    }
    public void AR1C2_Q2Again()
    {
        Q2Toggle.SetActive(false);
        ARSeated_Shadow.SetActive(true);
        AR1C2_Q2Man.SetActive(true);
        AR1C2_Q2Woman.SetActive(true);
        AR1C2_Q2_Btn.SetActive(true);
        AR1C2_Q2.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(11);

        GameObject.Find("AR1C2_14").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q2_SelectMan()
    {
        AR1C2_Q2.SetActive(false);
        EmptyBg.SetActive(false);
        AR1_Manager.Instance.DisableHintButton();
        Maintext.text = "핌브리아 거리의 골목";

        GameObject.Find("AR1C2_18").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q2_SelectWoman()
    {
        GameObject.Find("AR1C2_17").GetComponent<AR1_InteractionController>().Text();
        AR1_Manager.Instance.DisableHintButton();
    }
    public void AddARSkill2()
    {
        ARSkill_2.SetActive(true);
    }
    public void UseARSkill2()
    {
        ARSkill_2.SetActive(false);
        Black.SetActive(true);
        Skill2FX.SetActive(true);
        Icon.SetActive(false);
        SoundManager.instance.PlaySFX(Sfx.Magic_Use);

        Invoke("UseARSkill2_1", 6.5f);
    }
    public void UseARSkill2_1()
    {
        Skill2FX.SetActive(false);
        Black.SetActive(false);
        Icon.SetActive(true);

        GameObject.Find("AR1C2_19").GetComponent<AR1_InteractionController>().Text();
    }
    public void AR1C2_Q3Start()
    {
        progress = 3;
        SoundManager.instance.PlayBGM("AR1C2_Running");
        Maintext.text = "Quiz 3";
        AR1C2_Q3.SetActive(true);

        GameObject.Find("AR1C2_20").GetComponent<AR1_InteractionController>().Text();
    }
    public void AR1C2_Q3Again()
    {
        GameObject.Find("AR1C2_20").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q3_Fail()
    {
        GameObject.Find("AR1C2_21").GetComponent<AR1_InteractionController>().Text();

        //AR1_Result.Instance.IFFail(); + AR1C2_Q3Start() 호출
    }
    public void Q3_Success()
    {
        AR1C2_Q3.SetActive(false);
        Maintext.text = "핌브리아 거리의 골목";

        GameObject.Find("AR1C2_22").GetComponent<AR1_InteractionController>().Text();
    }
    public void AddARSkill3()
    {
        ARSkill_3.SetActive(true);
    }
    public void UseARSkill3()
    {
        ARSkill_3.SetActive(false);
        Skill3FX.SetActive(true);
        Black.SetActive(true);
        Icon.SetActive(false);
        SoundManager.instance.PlaySFX(Sfx.Magic_Use);

        Invoke("UseARSkill3_1", 4.5f);
    }
    public void UseARSkill3_1()
    {
        Skill3FX.SetActive(false);
        AR_Shot.SetActive(true);
        Black.SetActive(false);
        Icon.SetActive(true);
        SoundManager.instance.PlaySFX(Sfx.Blast);

        GameObject.Find("AR1C2_23").GetComponent<AR1_InteractionController>().Text();
    }
    public void AR1C2_Q4Start()
    {
        progress = 4;
        Maintext.text = "Quiz 4";
        AR_Shot.SetActive(false);
        AR1C2_Q4.SetActive(true);

        GameObject.Find("AR1C2_24").GetComponent<AR1_InteractionController>().Text();
    }
    public void AR1C2_Q4Again()
    {
        GameObject.Find("AR1C2_24").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q4_Fail()
    {
        GameObject.Find("AR1C2_25").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q4_Success()
    {
        forQ4 = true;
        AR1C2_Q4.SetActive(false);
        SoundManager.instance.PlayBGM("AR1C2");
        Maintext.text = "핌브리아 거리의 골목";

        GameObject.Find("AR1C2_26").GetComponent<AR1_InteractionController>().Text();
    }
    public void WalkorRun()
    {
        Choice2.SetActive(true);
        C2text_1.text = "여유가 생겼으니 걸어간다.";
        C2text_2.text = "한시가 급하니 뛰어간다.";
    }
    public void ClickWalk()
    {
        Choice2.SetActive(false);

        GameObject.Find("AR1C2_27").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickRun()
    {
        Choice2.SetActive(false);

        GameObject.Find("AR1C2_28").GetComponent<AR1_InteractionController>().Text();
    }
    public void ArriveatHideout()
    {
        GameObject.Find("AR1C2_29").GetComponent<AR1_InteractionController>().Text();
    }
    public void AR1C2_Q5Start()
    {
        AR1C2_Q5.SetActive(true);
        progress = 5;
        Maintext.text = "Quiz 5";
        AR1_Manager.Instance.EnableHintButton(12);

        GameObject.Find("AR1C2_30").GetComponent<AR1_InteractionController>().Text();
    }
    public void ChoiceRedDoor()
    {
        Q5_Select.SetActive(true);
        CheckQ5 = 1;
        Q5text.text = "정말 '빨간색 문'을 선택하시겠습니까?";
    }
    public void ChoiceBlueDoor()
    {
        Q5_Select.SetActive(true);
        CheckQ5 = 2;
        Q5text.text = "정말 '파란색 문'을 선택하시겠습니까?";
    }
    public void ChoiceGreenDoor()
    {
        Q5_Select.SetActive(true);
        CheckQ5 = 3;
        Q5text.text = "정말 '초록색 문'을 선택하시겠습니까?";
    }
    public void ChoiceYellowDoor()
    {
        Q5_Select.SetActive(true);
        CheckQ5 = 4;
        Q5text.text = "정말 '노란색 문'을 선택하시겠습니까?";
    }
    public void Q5Answer()
    {
        AR1_Manager.Instance.DisableHintButton();
        if (CheckQ5 == 1)
        {
            GameObject.Find("AR1C2_32").GetComponent<AR1_InteractionController>().Text();

            Destroy(Choice1_1.GetComponent<AR1C2_TouchManager>());
            Destroy(Choice2_1.GetComponent<AR1C2_TouchManager>());
            Destroy(Choice2_2.GetComponent<AR1C2_TouchManager>());
        }
        if (CheckQ5 == 2 || CheckQ5 == 3 || CheckQ5 == 4)
        {
            Q5_Select.SetActive(false);

            GameObject.Find("AR1C2_31").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void Q5Return()
    {
        CheckQ5 = 0;
        Q5_Select.SetActive(false);
        AR1_Manager.Instance.EnableHintButton(12);
    }
    public void End()
    {
        AR1C2_Q5.SetActive(false);
        FimStreetBg.SetActive(false);
        HideoutBg.SetActive(true);
        Maintext.text = "핌브리아 거리의 골목";
    }
}