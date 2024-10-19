using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AR1C3_MoveManager : MonoBehaviour
{
    public static AR1C3_MoveManager Instance;
    public Timer timer;

    public GameObject E_Button;
    public GameObject Choice2;
    public GameObject Choice2_1;
    public GameObject Choice2_2;
    public GameObject Intro4;
    public GameObject Intro3;
    public GameObject Quiz1;
    public GameObject ar1c3_bg;
    public GameObject Q1;
    public GameObject Q1_Choice;
    public GameObject SkillUse;
    public GameObject SkillEffect;
    public GameObject Icon;

    public GameObject Quiz2;
    public GameObject Q2;
    public GameObject Q2_Button;
    public GameObject Q2_Canvas;
    public GameObject Q2_Carpet;
    public GameObject Q2_Closet;
    public GameObject Q2_Closet1;
    public GameObject Q2_Closet2;
    public GameObject Q2_Picture;
    public GameObject Q2_Plant;
    public GameObject P_black;
    public GameObject P_key;
    public GameObject Q2_Closet_Close;
    public GameObject Q2_Closet_Open;

    public GameObject Quiz3;
    public GameObject Q3;
    public GameObject Q3_key;
    public GameObject Q3_Button;
    public GameObject Q3_1, Q3_2, Q3_3, Q3_4, Q3_5;
    public GameObject S3_1, S3_2, S3_3, S3_4, S3_5;
    public GameObject Q3_ButtonSelected;
    public GameObject Q3_Answer;
    public GameObject Q3_Explain;
    public GameObject Q3_Confirm;

    public GameObject Quiz4;
    public GameObject Q4;
    public GameObject HeartKey;
    public GameObject DiaKey;
    public GameObject Q4Answer;

    public GameObject Quiz5;
    public GameObject Q5;
    public GameObject Q5_1;
    public GameObject Q5_2;
    public GameObject BA;
    public GameObject BW;
    public GameObject WA;
    public GameObject WW;
    public GameObject Q5Fire;
    public GameObject Q5Power;
    public GameObject Q5Obj;

    public GameObject OutroBG;
    public GameObject Outro;

    public GameObject FailBG;

    public bool forkey = false;
    public bool AR1C3_choice = false;
    public bool IsRightSelected = false;
    public bool ForQ4 = false;
    public bool RemoveKeys = false;
    public bool UsingKeys = false;

    public int forQ4 = 0;
    public int progress = 0;

    public Text C2_1text;
    public Text C2_2text;
    public TMP_Text Maintext;

    bool Q2ClosetCheck = false;
    bool Q4_Fail_Check = false;

    int[] AR1C3_time = new int[] { 9, 0 };

    void OnDisable()
    {
        progress = 0;
        Destroy(Choice2_1.GetComponent<AR1C3_TouchManager>());
        Destroy(Choice2_2.GetComponent<AR1C3_TouchManager>());

        AR1C3_Amoving.Amove = false;
        AR1C3_Wmoving.Wmove = false;
        AR1C3_Fire.isadrop = false;
        AR1C3_Fire.iswdrop = false;
        AR1C3_Power.isadrop = false;
        AR1C3_Power.iswdrop = false;
        AR1_Slot.dia = false;
        AR1_Slot.heart = false;
        AR1_Slot.fordetail = 0;
    }
    void OnEnable()
    {
        AR1_Block.UsingItem = false;

        if (Instance == null)
        {
            Instance = this;
        }

        Choice2_1.AddComponent<AR1C3_TouchManager>();
        Choice2_2.AddComponent<AR1C3_TouchManager>();
    }
    void Update()
    {
        if (forQ4 == 2)
        {
            forQ4 = 0;
            Invoke("Q4_Success", 0.2f);
        }
        if (forQ4 == 1)
        {
            forQ4 = 0;
            Invoke("Q4_Fail", 0.2f);
        }
        if (Q4_Fail_Check && FailBG.activeSelf == true)
        {
            Q4_Fail_Check = false;
        }
    }
    public void TimeStart()
    {
        timer.StartTimer(AR1C3_time[0], AR1C3_time[1]);
    }
    public void BeforeQuiz1()
    {
        Maintext.text = "핌브리아 거리, 은신처 내부";
        AR1C3_choice = true;
    }
    public void LeftorRight()
    {
        Choice2.SetActive(true);
        C2_1text.text = "왼쪽으로 간다";
        C2_2text.text = "오른쪽으로 간다";
    }
    public void Quiz1Start()
    {
        progress = 1;
        Maintext.text = "Quiz 1";
        Choice2.SetActive(false);
        Intro4.SetActive(false);
        ar1c3_bg.SetActive(true);
        Q1.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(13);

        GameObject.Find("AR1C3_2").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q1_Select()
    {
        Q1_Choice.SetActive(true);
    }
    public void ReturnQ1()
    {
        SkillEffect.SetActive(false);
        Q1.SetActive(true);
        Q1_Choice.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(13);
    }
    public void Quiz1FindKey()
    {
        ar1c3_bg.SetActive(false);
        Q1.SetActive(false);
        Q1_Choice.SetActive(false);
        Q2.SetActive(true);
        Q2_Button.SetActive(true);
        AR1_Manager.Instance.DisableHintButton();

        BacktoQuiz2();
    }
    public void Quiz1BurnDoor()
    {
        ar1c3_bg.SetActive(false);
        Q1.SetActive(false);
        Q1_Choice.SetActive(false);
        SkillUse.SetActive(true);
        AR1_Manager.Instance.DisableHintButton();
    }
    public void Quiz1SkillUse()
    {
        Icon.SetActive(false);
        SkillUse.SetActive(false);
        SkillEffect.SetActive(true);
        SoundManager.instance.PlaySFX(Sfx.Magic_Use);

        Invoke("Q1_Fail", 0.8f);
    }
    public void Q1_Fail()
    {
        Icon.SetActive(true);
        SoundManager.instance.PlaySFX(Sfx.Steam_Burst);
        GameObject.Find("AR1C3_3").GetComponent<AR1_InteractionController>().Text();
    }
    public void BacktoQuiz2()
    {
        progress = 2;
        Maintext.text = "Quiz 2";
        Q2.SetActive(true);
        Q2_Button.SetActive(true);
        Q2_Canvas.SetActive(false);
        Q2_Carpet.SetActive(false);
        Q2_Closet.SetActive(false);
        Q2_Picture.SetActive(false);
        AR1_Manager.Instance.EnableHintButton(14);

        if (Q2ClosetCheck)
        {
            Q2_Closet_Close.SetActive(false);
            Q2_Closet_Open.SetActive(true);
        }

        GameObject.Find("AR1C3_4").GetComponent<AR1_InteractionController>().Text();
    }
    public void RightSelected()
    {
        Choice2.SetActive(false);
        Intro4.SetActive(false);

        IsRightSelected = true;
    }
    public void Quiz2Canvas()
    {
        Q2.SetActive(false);
        Q2_Button.SetActive(false);
        Q2_Canvas.SetActive(true);

        GameObject.Find("AR1C3_5").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz2Carpet()
    {
        Q2.SetActive(false);
        Q2_Button.SetActive(false);
        Q2_Carpet.SetActive(true);

        GameObject.Find("AR1C3_6").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz2Closet()
    {
        Q2.SetActive(false);
        Q2_Button.SetActive(false);
        Q2_Closet.SetActive(true);
        Q2_Closet2.SetActive(false);

        GameObject.Find("AR1C3_7").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz2Closet2()
    {
        Q2_Closet1.SetActive(false);
        Q2_Closet2.SetActive(true);

        Q2ClosetCheck = true;

        GameObject.Find("AR1C3_8").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz2Picture()
    {
        Q2.SetActive(false);
        Q2_Button.SetActive(false);
        Q2_Picture.SetActive(true);

        GameObject.Find("AR1C3_9").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz2Plant()
    {
        Q2.SetActive(false);
        Q2_Button.SetActive(false);
        Q2_Plant.SetActive(true);
        P_black.SetActive(false);
        P_key.SetActive(false);

        GameObject.Find("AR1C3_10").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz2Plant2()
    {
        P_black.SetActive(!false);
        P_key.SetActive(!false);
        forkey = true;
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);


        GameObject.Find("AR1C3_11").GetComponent<AR1_InteractionController>().Text();
    }
    public void toQuiz3()
    {
        AR1_Manager.Instance.DisableHintButton();
        Maintext.text = "핌브리아 거리, 은신처 내부";
        Q2_Plant.SetActive(false);
        Intro4.SetActive(true);

        GameObject.Find("AR1C3_12").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz3Start()
    {
        progress = 3;
        Maintext.text = "Quiz 3";
        Quiz2.SetActive(false);
        Intro4.SetActive(false);
        Q3.SetActive(true);

        GameObject.Find("AR1C3_13").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz3_1()
    {
        Q3_key.SetActive(true);

        GameObject.Find("AR1C3_14").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz3_2()
    {
        Q3_key.SetActive(false);

        GameObject.Find("AR1C3_15").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz3_3()
    {
        Q3_Button.SetActive(true);
        Q3_Explain.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(15);

        GameObject.Find("AR1C3_16").GetComponent<AR1_InteractionController>().Text();
    }
    public void Quiz3Confirm()
    {
        Q3_ButtonSelected.SetActive(true);
        Q3_Confirm.SetActive(true);
        Destroy(Q3_1.GetComponent<AR1C3_TouchManager>());
        Destroy(Q3_2.GetComponent<AR1C3_TouchManager>());
        Destroy(Q3_3.GetComponent<AR1C3_TouchManager>());
        Destroy(Q3_4.GetComponent<AR1C3_TouchManager>());
        Destroy(Q3_5.GetComponent<AR1C3_TouchManager>());
    }
    public void Quiz3Cancel()
    {
        //Q3_Confirm.SetActive(false);
        Q3_ButtonSelected.SetActive(false);
        if (Q3_1.GetComponent<AR1C3_TouchManager>() == null)
        {
            Q3_1.AddComponent<AR1C3_TouchManager>();
        }
        if (Q3_2.GetComponent<AR1C3_TouchManager>() == null)
        {
            Q3_2.AddComponent<AR1C3_TouchManager>();
        }
        if (Q3_3.GetComponent<AR1C3_TouchManager>() == null)
        {
            Q3_3.AddComponent<AR1C3_TouchManager>();
        }
        if (Q3_4.GetComponent<AR1C3_TouchManager>() == null)
        {
            Q3_4.AddComponent<AR1C3_TouchManager>();
        }
        if (Q3_5.GetComponent<AR1C3_TouchManager>() == null)
        {
            Q3_5.AddComponent<AR1C3_TouchManager>();
        }
        Q3_1.SetActive(true);
        Q3_2.SetActive(true);
        Q3_3.SetActive(true);
        Q3_4.SetActive(true);
        Q3_5.SetActive(true);
    }
    public void ReturnQ3()
    {
        S3_1.SetActive(false);
        S3_2.SetActive(false);
        S3_3.SetActive(false);
        S3_4.SetActive(false);
        S3_5.SetActive(false);
        AR1_Manager.Instance.EnableHintButton(15);
    }

    public void Quiz3Answer()
    {
        AR1_Manager.Instance.DisableHintButton();
        if (Q3_Answer.activeSelf == true)
        {
            GameObject.Find("AR1C3_18").GetComponent<AR1_InteractionController>().Text();

            Quiz3.SetActive(false);
            Intro4.SetActive(true);
            Maintext.text = "핌브리아 거리, 은신처 내부";
        }
        else
        {
            GameObject.Find("AR1C3_17").GetComponent<AR1_InteractionController>().Text();
            //Quiz3_3();
        }
    }
    public void Quiz4Start()
    {
        progress = 4;
        Maintext.text = "Quiz 4";
        Intro4.SetActive(false);
        Q4.SetActive(true);
        ForQ4 = true;
        UsingKeys = true;
        AR1_Manager.Instance.EnableHintButton(16);


        GameObject.Find("AR1C3_19").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q4_Fail()
    {
        DiaKey.SetActive(false);
        HeartKey.SetActive(false);
        Q4Answer.SetActive(false);
        AR1_Manager.Instance.DisableHintButton();

        GameObject.Find("AR1C3_20").GetComponent<AR1_InteractionController>().Text();
        Q4_Fail_Check = true;
    }
    public void ReturnQ4()
    {
        AR1_Block.UsingItem = false;
        Q4Answer.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(16);
    }
    public void Q4_Success()
    {
        DiaKey.SetActive(false);
        Q4Answer.SetActive(false);
        RemoveKeys = true;
        AR1_Manager.Instance.DisableHintButton();

        GameObject.Find("AR1C3_21").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q4Dialogue()
    {

        AR1_Block.UsingItem = false;
        Q4.SetActive(false);
        Intro4.SetActive(true);
        Maintext.text = "핌브리아 거리, 은신처 내부";

        GameObject.Find("AR1C3_22").GetComponent<AR1_InteractionController>().Text();
    }
    public void DoorCheck()
    {
        if (IsRightSelected) // 오른쪽
        {
            GameObject.Find("AR1C3_23").GetComponent<AR1_InteractionController>().Text();
        }
        else // 왼쪽
        {
            GameObject.Find("AR1C3_24").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void Q4Dialogue_1()
    {
        Intro4.SetActive(false);
        Intro3.SetActive(true);
        GameObject.Find("AR1C3_25").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q4Dialogue_2()
    {
        SoundManager.instance.PlaySFX(Sfx.Door_Bang);
        GameObject.Find("AR1C3_25_").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q5Start()
    {
        progress = 5;
        Maintext.text = "Quiz 5";
        Intro3.SetActive(false);
        Q5.SetActive(true);
        Q5_1.SetActive(true);
        BA.SetActive(true);
        BW.SetActive(true);
        Q5Fire.SetActive(true);
        Q5Power.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(17);

        GameObject.Find("AR1C3_26").GetComponent<AR1_InteractionController>().Text();
    }
    public void ReturnQ5()
    {
        AR1_Manager.Instance.EnableHintButton(17);
        Q5.SetActive(true);
        Q5_1.SetActive(true);
        Q5_2.SetActive(false);
        Q5Fire.SetActive(true);
        Q5Power.SetActive(true);
        WA.SetActive(false);
        WW.SetActive(false);

        AR1C3_Fire.isadrop = false;
        AR1C3_Fire.iswdrop = false;
        AR1C3_Power.isadrop = false;
        AR1C3_Power.iswdrop = false;
        AR1C3_Amoving.Amove = false;
        AR1C3_Wmoving.Wmove = false;
        AR1C3_Q5Manager.Instance.Q5Again = false;

        Color color = BA.GetComponent<Image>().color;
        color.a = 255;
        BA.GetComponent<Image>().color = color;

        Color color1 = BW.GetComponent<Image>().color;
        color1.a = 255;
        BW.GetComponent<Image>().color = color;

        BA.GetComponent<RectTransform>().anchoredPosition = new Vector2(-351.25f, -158.69f);
        BW.GetComponent<RectTransform>().anchoredPosition = new Vector2(-196.18f, -153.74f);

        BA.GetComponent<BoxCollider2D>().isTrigger = true;
        BW.GetComponent<BoxCollider2D>().isTrigger = true;

        GameObject.Find("AR1C3_26").GetComponent<AR1_InteractionController>().Text();
    }
    public void AR1C3_outro()
    {
        Maintext.text = "핌브리아 거리, 은신처 내부";
        SoundManager.instance.PlaySFX(Sfx.Door_Bang);

        Q5Obj.SetActive(false);
        OutroBG.SetActive(true);
    }
    public void OutroBoxIn()
    {
        Outro.SetActive(true);
    }
    public void OutroBoxOut()
    {
        Outro.SetActive(false);

        GameObject.Find("AR1C3_33").GetComponent<AR1_InteractionController>().Text();
    }
}