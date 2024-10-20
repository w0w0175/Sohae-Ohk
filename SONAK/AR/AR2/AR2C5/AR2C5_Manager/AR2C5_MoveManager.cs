using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AR2C5_MoveManager : MonoBehaviour
{
    public static AR2C5_MoveManager Instance;
    public Timer timer;

    public TMP_Text MainText;
    public GameObject ClickEvent_R;
    public GameObject ClickEvent_D;
    public GameObject Black;
    public GameObject BackBtn;
    public GameObject Chan_key;
    public GameObject CutCurtain;
    public GameObject KeyEvent;
    public GameObject Underpic;
    public GameObject DeskBg;
    public GameObject RoomBg;
    public GameObject Gotodesk;
    public GameObject Chandelier;
    public GameObject Right;
    public GameObject Right_Dial;
    public GameObject DialLeft;
    public GameObject DialRight;
    public GameObject Right_Submit;
    public GameObject DL_water;
    public GameObject DR_sun;
    public GameObject RightContent;
    public GameObject Underbox;
    public GameObject LeftBG;
    public GameObject Left_Dial;
    public GameObject Left_Success;
    public GameObject Left_Submit;
    public GameObject CupSubmit;
    public GameObject CupSuccessBG;
    public GameObject Scissor_Click;
    public GameObject Scissor_Big;
    public GameObject DeskRight;
    public GameObject CeremonyBg;
    public GameObject RoomEvent;
    public GameObject Choice_3;
    public GameObject Choice_3_1, Choice_3_2, Choice_3_3;
    public GameObject ClickLake;
    public GameObject Skill1;
    public GameObject Skill1FX;
    public GameObject Skill2;
    public GameObject Skill2FX;
    public GameObject OutroBg;
    public GameObject Clickother;
    public GameObject ClicktoCurtain;
    public GameObject ClicktoChan;
    public GameObject OldQuizContent;
    public GameObject Icon;

    public TMP_InputField old;

    public Text L_1;
    public Text L_2;
    public Text L_3;
    public Text L_4;
    public Text Choice3_1;
    public Text Choice3_2;
    public Text Choice3_3;

    public Sprite RoomBG_Cut;

    public bool ar2c5 = false;
    public bool Getkey = false;
    public bool IsCut = false;
    public bool IsCurtain = false;
    public bool IsOld = false;
    public bool GetCurtain = false;
    public bool GetScissors = false;
    public bool IsKey = false;
    public bool UsedScissor = false;
    public bool UsedKey = false;
    public bool CupDrop1 = false;
    public bool CupDrop2 = false;
    public bool CupDrop3 = false;
    public bool OldEnd = false;
    public bool RemoveAll = false;
    public bool FailRight = false;
    public bool FailLeft = false;
    public bool FailCup = false;

    public int progress = 0;

    bool underboxfirst = false;
    bool underboxpic = false;
    bool IsDesk = false;
    bool IsRight = false;
    bool IsRightfirst = false;
    bool IsLeft = false;
    bool rightend = false;
    bool leftcup = false;
    bool lakeskill = false;
    bool IsLake = false;
    bool isgetkey = false;
    bool iscutcurtain = false;
    bool backbtncheck = false;
    bool todeskcheck = false;
    bool End0938 = false;
    bool oldfirst = false;
    bool leftfirst = false;

    int rightcheck = 0;
    int leftcheck = 0;
    int oldcheck = 0;
    int boxcheck = 0;

    int[] AR2C5_time = new int[] { 9, 0 };

    void OnEnable()
    {
        if (Instance == null)
            Instance = this;
        ar2c5 = true;

        BackBtn.AddComponent<AR2C5_TouchManager>();
        Choice_3_1.AddComponent<AR2C5_TouchManager>();
        Choice_3_2.AddComponent<AR2C5_TouchManager>();
        Choice_3_3.AddComponent<AR2C5_TouchManager>();
    }
    void OnDisable()
    {
        ar2c5 = false;
        Destroy(BackBtn.GetComponent<AR2C5_TouchManager>());

        Destroy(Choice_3_1.GetComponent<AR2C5_TouchManager>());
        Destroy(Choice_3_2.GetComponent<AR2C5_TouchManager>());
        Destroy(Choice_3_3.GetComponent<AR2C5_TouchManager>());
    }
    public void TimeStart()
    {
        timer.StartTimer(AR2C5_time[0], AR2C5_time[1]);
    }
    public void ChapterStart()
    {
        MainText.text = "존스티나 저택, 아이란의 방";
        GameObject.Find("AR2C5_1").GetComponent<AR2_InteractionController>().Text();
    }
    public void ToMain()
    {
        if (IsDesk)
        {
            if (IsRight || IsLeft)
            {
                Black.SetActive(false);
                ClickEvent_D.SetActive(true);


                if (IsRight)
                {
                    IsRight = false;
                    Right.SetActive(false);
                    Right_Dial.SetActive(false);
                    if (rightend)
                    {
                        RightContent.SetActive(false);
                    }
                }
                else
                {
                    IsLeft = false;
                    Left_Dial.SetActive(false);
                    Left_Submit.SetActive(false);
                    LeftBG.SetActive(false);
                    if (leftcup)
                    {
                        leftcup = false;
                        Left_Success.SetActive(false);
                        if (CupSuccessBG.activeSelf)
                        {
                            CupSuccessBG.SetActive(false);
                            Destroy(DeskRight);
                        }

                    }
                }
            }
            else
            {
                IsDesk = false;
                DeskBg.SetActive(false);
                ClickEvent_D.SetActive(false);
                RoomBg.SetActive(true);
                ClickEvent_R.SetActive(true);
                BackBtnFalse();
            }
        }
        else if (IsLake)
        {
            CeremonyBg.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            ClickLake.SetActive(false);
            BackBtnFalse();
            Ceremony_3();
        }
        else
        {
            ClickEvent_R.SetActive(true);
            Underbox.SetActive(false);
            IsKey = false;
            IsCut = false;
            IsCurtain = false;
            if (underboxpic)
            {
                CloseUnderpic();
            }
            if (iscutcurtain)
            {
                iscutcurtain = false;
                Destroy(ClicktoCurtain);
            }
            if (isgetkey)
            {
                isgetkey = false;
                Destroy(ClicktoChan);
            }
            BackBtnFalse();
        }
    }
    public void OldQuiz()
    {
        AR2_Manager.Instance.EnableHintButton(19);
        OldQuizContent.SetActive(true);
        if (BackBtn.activeSelf)
        {
            BackBtn.SetActive(false);
            backbtncheck = true;
        }
        if (Gotodesk.activeSelf)
        {
            Gotodesk.SetActive(false);
            todeskcheck = true;
        }

        if (oldfirst)
        {

        }
        else
        {
            oldfirst = true;
            progress++;
        }
    }
    public void CloseOld()
    {
        AR2_Close.UsingItem = false;
        OldQuizContent.SetActive(false);
        old.text = "";
        ArrowCheck();
        AR2_Manager.Instance.DisableHintButton();
    }
    public void OldResult()
    {
        AR2_Manager.Instance.DisableHintButton();
        AR2_Close.UsingItem = false;
        OldQuizContent.SetActive(false);


        if (old.text == "53")
        {
            OldEnd = true;
            GameObject.Find("AR2C5_24").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            ++oldcheck;
            old.text = "";
            GameObject.Find("AR2C5_25").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void ArrowCheck()
    {
        if (backbtncheck)
        {
            backbtncheck = false;
            BackBtn.SetActive(true);
        }
        if (todeskcheck)
        {
            todeskcheck = false;
            Gotodesk.SetActive(true);
        }
    }
    public void ClickChandelier()
    {
        ClickEvent_R.SetActive(false);

        GameObject.Find("AR2C5_2").GetComponent<AR2_InteractionController>().Text();
    }
    public void Chan_1()
    {
        Black.SetActive(true);
        Chan_key.SetActive(true);
        Getkey = true;
        isgetkey = true;

        GameObject.Find("AR2C5_3").GetComponent<AR2_InteractionController>().Text();
    }
    public void Chan_2()
    {
        Black.SetActive(false);
        Chan_key.SetActive(false);
        BackBtn.SetActive(true);
    }
    public void ClickWindow()
    {
        ClickEvent_R.SetActive(false);

        GameObject.Find("AR2C5_4").GetComponent<AR2_InteractionController>().Text();
    }
    public void Window_1()
    {
        BackBtn.SetActive(true);
        IsCurtain = true;
    }
    public void Window_Tie()
    {
        BackBtn.SetActive(false);
        GameObject.Find("AR2C5_5").GetComponent<AR2_InteractionController>().Text();
    }
    public void ClickCurtain()
    {
        ClickEvent_R.SetActive(false);

        GameObject.Find("AR2C5_6").GetComponent<AR2_InteractionController>().Text();
    }
    public void Curtain_1()
    {
        BackBtn.SetActive(true);
        IsCut = true;
    }
    public void UsingScissor()
    {
        BackBtn.SetActive(false);
        RoomBg.GetComponent<Image>().sprite = RoomBG_Cut;
        Chandelier.SetActive(false);

        GameObject.Find("AR2C5_7").GetComponent<AR2_InteractionController>().Text();
    }
    public void Scissor_1()
    {
        Black.SetActive(true);
        CutCurtain.SetActive(true);
        GetCurtain = true;
        iscutcurtain = true;

        GameObject.Find("AR2C5_8").GetComponent<AR2_InteractionController>().Text();
    }
    public void Scissor_2()
    {
        Black.SetActive(false);
        CutCurtain.SetActive(false);
        BackBtn.SetActive(true);
    }
    public void ClickUnderBed()
    {
        boxcheck++;
        Underbox.SetActive(true);
        ClickEvent_R.SetActive(false);
        if (underboxfirst == false)
        {
            underboxfirst = true;

            GameObject.Find("AR2C5_9").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            if (underboxpic)
            {
                UnderBedKey_1();
            }
            else
            {
                if (boxcheck > 1)
                {
                    GameObject.Find("AR2C5_38").GetComponent<AR2_InteractionController>().Text();
                }
                else
                {
                    UnderBed_1();
                }
            }
        }
    }
    public void UnderBed_1()
    {
        GameObject.Find("AR2C5_37").GetComponent<AR2_InteractionController>().Text();
    }
    public void UnderBed_2()
    {
        IsKey = true;
        BackBtn.SetActive(true);
    }
    public void UnderBedKey()
    {
        Underbox.SetActive(false);
        KeyEvent.SetActive(false);

        GameObject.Find("AR2C5_10").GetComponent<AR2_InteractionController>().Text();
    }
    public void UnderBedKey_1()
    {
        Underbox.SetActive(false);
        UsedKey = true;
        Black.SetActive(true);
        Underpic.SetActive(true);
        underboxpic = true;
        AR2_Detail.Instance.CloseC5Key();

        GameObject.Find("AR2C5_11").GetComponent<AR2_InteractionController>().Text();
    }
    public void CloseUnderpic()
    {
        Black.SetActive(false);
        Underpic.SetActive(false);
    }
    public void ToDesk()
    {
        IsDesk = true;
        RoomBg.SetActive(false);
        ClickEvent_R.SetActive(false);
        DeskBg.SetActive(true);
        ClickEvent_D.SetActive(true);
        BackBtn.SetActive(false);

        GameObject.Find("AR2C5_12").GetComponent<AR2_InteractionController>().Text();
    }
    public void ClickRIght()
    {
        ClickEvent_D.SetActive(false);
        if (rightend)
        {
            IsRight = true;
            RightContent.SetActive(true);
        }
        else
        {
            Right.SetActive(true);
            Black.SetActive(true);
            Right_Dial.SetActive(true);

            if (IsRightfirst == false)
            {
                IsRightfirst = true;
                BackBtn.SetActive(false);
                progress++;

                GameObject.Find("AR2C5_13").GetComponent<AR2_InteractionController>().Text();
            }
            else
            {
                Right_1();
            }
        }
    }
    public void Right_1()
    {
        IsRight = true;
        Right_Submit.SetActive(true);
        BackBtn.SetActive(true);
        AR2_Manager.Instance.EnableHintButton(16);
    }
    public void RightResult()
    {
        if (DL_water.activeSelf && DR_sun.activeSelf)
        {
            Right.SetActive(false);
            Black.SetActive(false);
            Right_Dial.SetActive(false);
            RightContent.SetActive(true);
            rightend = true;
            BackBtn.SetActive(false);
            AR2_Manager.Instance.DisableHintButton();

            GameObject.Find("AR2C5_14").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            if (rightcheck == 1)
            {
                Right_Submit.SetActive(false);
                BackBtn.SetActive(false);
                FailRight = true;
                AR2_Manager.Instance.DisableHintButton();

                GameObject.Find("AR2C5_15").GetComponent<AR2_InteractionController>().Text();
            }
            else
            {
                AR2C5_RightDialLeft.Instance.ResetDial();
                AR2C5_RightDialRight.Instance.ResetDial();
                rightcheck++;
            }
        }
    }
    public void RightAgain()
    {
        AR2_Manager.Instance.EnableHintButton(16);
        Right_Submit.SetActive(true);
        AR2C5_RightDialLeft.Instance.ResetDial();
        AR2C5_RightDialRight.Instance.ResetDial();
        rightcheck = 0;
    }
    public void ClickLeft()
    {
        ClickEvent_D.SetActive(false);
        IsLeft = true;
        if (End0938)
        {
            leftcup = true;
            Left_Success.SetActive(true);
            AR2_Close.UsingItem = true;
            AR2_Manager.Instance.EnableHintButton(18);
        }
        else
        {
            LeftBG.SetActive(true);
            Left_Dial.SetActive(true);
            BackBtn.SetActive(false);

            GameObject.Find("AR2C5_16").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void Left_1()
    {
        if (OldEnd)
        {
            GameObject.Find("AR2C5_17").GetComponent<AR2_InteractionController>().Text();
        }
        else if (OldEnd == false && oldcheck > 0)
        {
            GameObject.Find("AR2C5_18").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            GameObject.Find("AR2C5_19").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void Left_2()
    {
        Left_Submit.SetActive(true);
        BackBtn.SetActive(true);
        AR2_Manager.Instance.EnableHintButton(17);
        if (leftfirst)
        {

        }
        else
        {
            leftfirst = true;
            progress++;
        }
    }
    public void LeftResult()
    {
        if (L_1.text == "0" && L_2.text == "9" && L_3.text == "4" && L_4.text == "8")
        {
            LeftBG.SetActive(false);
            Left_Dial.SetActive(false);
            Left_Success.SetActive(true);
            leftcup = true;
            End0938 = true;
            AR2_Close.UsingItem = true;
            BackBtn.SetActive(false);
            AR2_Manager.Instance.DisableHintButton();

            GameObject.Find("AR2C5_20").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            if (leftcheck == 1)
            {
                Left_Submit.SetActive(false);
                FailLeft = true;
                BackBtn.SetActive(false);
                AR2_Manager.Instance.DisableHintButton();

                GameObject.Find("AR2C5_15").GetComponent<AR2_InteractionController>().Text();
            }
            else
            {
                L_1.text = "0";
                L_2.text = "0";
                L_3.text = "0";
                L_4.text = "0";
                AR2C5_LeftDial.Instance.ResetGame();
                leftcheck++;
            }
        }
    }
    public void LeftAgain()
    {
        leftcheck = 0;
        Left_Submit.SetActive(true);
        L_1.text = "0";
        L_2.text = "0";
        L_3.text = "0";
        L_4.text = "0";
        AR2C5_LeftDial.Instance.ResetGame();
        AR2_Manager.Instance.EnableHintButton(17);
    }
    public void Cup_1()
    {
        progress++;
        CupSubmit.SetActive(true);
        BackBtn.SetActive(true);
        AR2_Manager.Instance.EnableHintButton(18);
    }
    public void CupResult()
    {
        AR2_Manager.Instance.DisableHintButton();
        AR2_Close.UsingItem = false;
        BackBtn.SetActive(false);
        Debug.Log("1:" + CupDrop1);
        Debug.Log("2:" + CupDrop2);
        Debug.Log("3:" + CupDrop3);
        if (CupDrop1 && CupDrop2 && CupDrop3)
        {
            CupSuccess();
        }
        else
        {
            CupSubmit.SetActive(false);
            FailCup = true;

            GameObject.Find("AR2C5_21").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void CupFail()
    {
        GameObject.Find("AR2C5_39").GetComponent<AR2_InteractionController>().Text();
    }
    public void CupFail_1()
    {
        GameObject.Find("AR2C5_40").GetComponent<AR2_InteractionController>().Text();
    }
    public void CupSuccess()
    {
        Left_Success.SetActive(false);
        CupSuccessBG.SetActive(true);
        Scissor_Click.SetActive(true);

        GameObject.Find("AR2C5_22").GetComponent<AR2_InteractionController>().Text();
    }
    public void CupAgain()
    {
        AR2_Manager.Instance.EnableHintButton(18);

        CupSubmit.SetActive(true);
        BackBtn.SetActive(true);
    }
    public void ClickScissors()
    {
        GetScissors = true;
        Scissor_Click.SetActive(false);
        Black.SetActive(true);
        Scissor_Big.SetActive(true);

        GameObject.Find("AR2C5_23").GetComponent<AR2_InteractionController>().Text();
    }
    public void Scissors_1()
    {
        Black.SetActive(false);
        Scissor_Big.SetActive(false);
        BackBtn.SetActive(true);
    }
    public void Ceremony()
    {
        RemoveAll = true;
        IsLake = true;
        BackBtn.SetActive(false);
        RoomBg.SetActive(false);
        ClickEvent_R.SetActive(false);
        RoomEvent.SetActive(false);
        CeremonyBg.SetActive(true);
        MainText.text = "존스티나 공작가 뒤뜰, 아이란의 성인식";
        GameObject.Find("AR2C5_26").GetComponent<AR2_InteractionController>().Text();
    }
    public void Ceremony_1()
    {
        Choice_3.SetActive(true);
        Choice3_1.text = "죄송해요";
        Choice3_2.text = "누가 문을 잠갔더라고요";
        Choice3_3.text = "......";
    }
    public void Ceremony_1_1()
    {
        Choice_3.SetActive(false);

        GameObject.Find("AR2C5_27").GetComponent<AR2_InteractionController>().Text();
    }
    public void Ceremony_1_2()
    {
        Choice_3.SetActive(false);

        GameObject.Find("AR2C5_28").GetComponent<AR2_InteractionController>().Text();
    }
    public void Ceremony_1_3()
    {
        Choice_3.SetActive(false);

        GameObject.Find("AR2C5_29").GetComponent<AR2_InteractionController>().Text();
    }
    public void LastClickEvent()
    {
        progress = 5;
        ClickLake.SetActive(true);
        Clickother.SetActive(true);

        AR2_Manager.Instance.EnableHintButton(20);
    }
    public void ClickEventfalse()
    {
        ClickLake.SetActive(false);
        Clickother.SetActive(false);
    }
    public void Ceremony_2()
    {
        GameObject.Find("AR2C5_30").GetComponent<AR2_InteractionController>().Text();
    }
    public void Ceremony_3()
    {
        ClickEventfalse();
        GameObject.Find("AR2C5_31").GetComponent<AR2_InteractionController>().Text();
    }
    public void Ceremony_4()
    {
        Skill2.SetActive(true);
    }
    public void ClickSkill2()
    {
        Skill2.SetActive(false);
        Icon.SetActive(false);
        Black.SetActive(true);
        Skill2FX.SetActive(true);
        Invoke("Skill2_1", 8.0f);
    }
    public void Skill2_1()
    {
        Icon.SetActive(true);
        Skill2FX.SetActive(false);
        Black.SetActive(false);
        if (lakeskill)
        {
            GameObject.Find("AR2C5_32").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            GameObject.Find("AR2C5_33").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void ClicktoLake()
    {
        ClickEventfalse();
        CeremonyBg.GetComponent<RectTransform>().localScale = new Vector3(2, 2, 2);
        ClickLake.SetActive(false);
        BackBtnFalse();

        GameObject.Find("AR2C5_34").GetComponent<AR2_InteractionController>().Text();
    }
    public void Lake_1()
    {
        Skill1.SetActive(true);
    }
    public void ClickSkill1()
    {
        Skill1.SetActive(false);
        lakeskill = true;
        Icon.SetActive(false);
        Black.SetActive(true);
        Skill1FX.SetActive(true);
        Invoke("Skill1_1", 5.5f);
    }
    public void Skill1_1()
    {
        Icon.SetActive(true);
        Black.SetActive(false);
        GameObject.Find("AR2C5_35").GetComponent<AR2_InteractionController>().Text();
    }
    public void Outro()
    {
        AR2_Manager.Instance.DisableHintButton();
        CeremonyBg.SetActive(false);
        OutroBg.SetActive(true);
        Destroy(Choice_3_1.GetComponent<AR2C5_TouchManager>());
        Destroy(Choice_3_2.GetComponent<AR2C5_TouchManager>());
        Destroy(Choice_3_3.GetComponent<AR2C5_TouchManager>());
        Destroy(BackBtn.GetComponent<AR2C5_TouchManager>());
        MainText.text = "왕립 아카데미";

        GameObject.Find("AR2C5_36").GetComponent<AR2_InteractionController>().Text();
    }

    public void BackBtnTrue()
    {
        BackBtn.SetActive(true);
    }
    public void BackBtnFalse()
    {
        BackBtn.SetActive(false);

    }
}
