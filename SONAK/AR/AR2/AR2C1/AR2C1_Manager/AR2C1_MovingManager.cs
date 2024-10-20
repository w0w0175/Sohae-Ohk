using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AR2C1_MovingManager : MonoBehaviour
{
    public static AR2C1_MovingManager Instance;
    public Timer timer;

    public GameObject Choice_1, Choice2_1, Choice2_2;

    public GameObject BackBtn;
    public GameObject Quiz1;
    public GameObject IntroRoom;
    public GameObject Black;
    public GameObject Hallway;
    public GameObject Room;
    public GameObject Clickbookcase;
    public GameObject ChoiceBtn_1;
    public GameObject BasicCarpet;
    public GameObject OpenCarpetCard;
    public GameObject OpenCarpet;
    public GameObject Clover2;
    public GameObject ClosedLetter;
    public GameObject LetterBtn;
    public GameObject OpenLetterCard;
    public GameObject Spade5;
    public GameObject Desk;
    public GameObject I_Window;
    public GameObject I_BookCase;
    public GameObject I_BookCase_No;
    public GameObject I_BookCase_Yes;
    public GameObject putthere;
    public GameObject I_Key;
    public GameObject OldEtiqutte;
    public GameObject Locker;
    public GameObject Map;
    public GameObject Lampoff;
    public GameObject LampwithKey;
    public GameObject Lampon;
    public GameObject Rm_Lampon;
    public GameObject OpenBoxGun;
    public GameObject ClosedBox;
    public GameObject OpenBox;
    public GameObject I_Drawer;
    public GameObject Heart3;
    public GameObject Heart_3;
    public GameObject Rm_Heart3;
    public GameObject Dia7;
    public GameObject Dia_7;
    public GameObject BasicFrame;
    public GameObject MovedFrame;
    public GameObject ChoiceBtn_2;
    public GameObject ARStuff;
    public GameObject ClosedAdopt;
    public GameObject OpenAdopt;
    public GameObject AdoptContent;
    public GameObject ARDiary;
    public GameObject DiaryContent;
    public GameObject OpenHallway;
    public GameObject Bookcase;
    public GameObject clickmap;
    public GameObject HiddenNotice;
    public GameObject Close_Content;

    public bool forkey;
    public bool isheart;
    public bool isdia;
    public bool isspade;
    public bool isclover;
    public bool isadopt;
    public bool iskey;
    public bool isold;
    public bool isgun;
    public bool isdiary;
    public bool ismap;
    public bool isusing;
    public bool iseventb;
    public bool GunAdd;
    public bool ar2c1;
    public bool end;

    bool ishallway = false;
    bool isMap = false;
    bool getkey = false;

    int forCards = 0;
    int forEvent = 0;

    public int progress = 0;

    public TMP_Text Maintext;

    public Text C_1;
    public Text C_2_1;
    public Text C_2_2;

    bool Q2progress = false;
    public bool WindowON = false;
    public bool BoxON = false;
    public bool CarpetON = false;
    public bool HQprogress = false;

    bool QHOK = false;
    bool Q3OK = false;
    bool Q2OK = false;

    int[] AR2C1_time = new int[] { 7, 0 };
    private void OnDisable()
    {
        ar2c1 = false; //end = true;
        progress = 0;
        Destroy(Choice_1.GetComponent<AR2C1_TouchManager>());
        Destroy(Choice2_1.GetComponent<AR2C1_TouchManager>());
        Destroy(Choice2_2.GetComponent<AR2C1_TouchManager>());
        Destroy(BackBtn.GetComponent<AR2C1_TouchManager>());
        Destroy(Close_Content.GetComponent<AR2C1_TouchManager>());
    }
    void OnEnable()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        Choice_1.AddComponent<AR2C1_TouchManager>();
        Choice2_1.AddComponent<AR2C1_TouchManager>();
        Choice2_2.AddComponent<AR2C1_TouchManager>();
        BackBtn.AddComponent<AR2C1_TouchManager>();
        Close_Content.AddComponent<AR2C1_TouchManager>();

        forkey = false;
        isheart = false;
        isdia = false;
        isspade = false;
        isclover = false;
        isadopt = false;
        iskey = false;
        isold = false;
        isgun = false;
        isdiary = false;
        ismap = false;
        isusing = false;
        iseventb = false;
        end = false;
        WindowON = false;
        BoxON = false;
        CarpetON = false;
        HQprogress = false;

        ar2c1 = true; //얘는 트루여야함니다~~ false로 초기화하지 말아주세요
        AR2C1_Drop.isusedkey = false;
        AR2_Slot.Openold = false;
        AR2_Slot.oldq5 = false;
        AR2_Slot.IsGod = false;
        AR2_Slot.Ispaper = false;
        AR2_Slot.Isplan = false;
        AR2_Slot.Isdiary = false;

        progress = 0;
    }
    void Update()
    {
        if (forEvent == 3)
        {
            forEvent = 0;
            Invoke("EventStart", 0.3f);
        }
        if (forCards == 4)
        {
            if (BackBtn.activeSelf == true)
            {
                forCards = 100;
                Notice4cards();
            }
        }
        if (AR2C1_Drop.isusedkey)
        {
            I_Key.SetActive(false);
            putthere.SetActive(false);
        }
    }
    public void TimeStart()
    {
        timer.StartTimer(AR2C1_time[0], AR2C1_time[1]);
    }
    public void BackBtntrue()
    {
        BackBtn.SetActive(true);

        if (Q3OK)
        {
            Q3OK = false;
            forEvent += 1;
        }
        else if (Q2OK)
        {
            Q2OK = false;
            forEvent += 1;
        }
        else if (QHOK)
        {
            QHOK = false;
            forEvent += 1;
        }

        if (ishallway)
        {
            if (isMap)
            {
                Maintext.text = "제 1장 : 존스티나 공작가, 아이란의 방";
            }
            else
            {
                Maintext.text = "제 1장 : OOOO OOO, 아이란의 방";
            }

        }
        else
        {
            if (isMap)
            {
                Maintext.text = "제 1장 : 존스티나 공작가, OOO의 방";
            }
            else
            {
                Maintext.text = "제 1장 : OOOO OOO, OOO의 방";
            }

        }
    }
    public void BackBtnfalse()
    {
        BackBtn.SetActive(false);
    }
    public void ClicktoRoom()
    {
        if (ishallway)
        {
            ChoiceBtn_1.SetActive(false);
            Hallway.SetActive(false);
            Room.SetActive(true);
            Maintext.text = "제 1장 : OOOO OOO, 아이란의 방";
        }
        else
        {
            Quiz1.SetActive(false);
            IntroRoom.SetActive(false);
            Black.SetActive(false);
            Room.SetActive(true);
            Maintext.text = "제 1장 : OOOO OOO, OOO의 방";
        }

    }
    public void ClicktoMain()
    {
        isusing = false;
        BackBtnfalse();
        Desk.SetActive(false);
        if (isgun)
        {
            OpenBoxGun.SetActive(false);
            Destroy(ClosedBox);
            OpenBox.SetActive(true);
        }
        if (isclover)
        {
            Destroy(BasicCarpet);
            OpenCarpet.SetActive(true);
        }
    }
    public void ClicktoHallway()
    {
        Quiz1.SetActive(false);
        IntroRoom.SetActive(false);
        Black.SetActive(false);
        Hallway.SetActive(true);
        Maintext.text = "제 1장 : OOOO OOO의 복도";

        GameObject.Find("AR2C1_1").GetComponent<AR2_InteractionController>().Text();
    }
    public void ClicktoHallwayEnd()
    {
        ChoiceBtn_1.SetActive(true);
        C_1.text = "방으로 돌아가기";
        ishallway = true;
    }
    public void ClickCarpet()
    {
        isusing = true;
        BoxON = true; CarpetON = true;
        BasicCarpet.SetActive(false);
        OpenCarpetCard.SetActive(true);

        GameObject.Find("AR2C1_2").GetComponent<AR2_InteractionController>().Text();
    }
    public void Carpet_1()
    {
        OpenCarpetCard.SetActive(false);
        OpenCarpet.SetActive(true);
        Black.SetActive(true);
        Black.GetComponent<Image>().raycastTarget = true;
        Clover2.SetActive(true);
        isclover = true;
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);

        GameObject.Find("AR2C1_3").GetComponent<AR2_InteractionController>().Text();
    }
    public void Carpet_2()
    {
        forCards += 1;
        BackBtntrue();
        Black.SetActive(false);
        Clover2.SetActive(false);
    }
    public void ClickLetter()
    {
        isusing = true;
        BoxON = true;

        GameObject.Find("AR2C1_4").GetComponent<AR2_InteractionController>().Text();
    }
    public void Letter_1()
    {
        Destroy(LetterBtn);
        Black.SetActive(true);
        Black.GetComponent<Image>().raycastTarget = true;
        ClosedLetter.SetActive(true);
    }
    public void Letter_2()
    {
        ClosedLetter.SetActive(false);
        OpenLetterCard.SetActive(true);

        GameObject.Find("AR2C1_5").GetComponent<AR2_InteractionController>().Text();
    }
    public void Letter_3()
    {
        OpenLetterCard.SetActive(false);
        Spade5.SetActive(true);
        isspade = true;
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);

        GameObject.Find("AR2C1_6").GetComponent<AR2_InteractionController>().Text();
    }
    public void Letter_4()
    {
        forCards += 1;
        Spade5.SetActive(false);
        Black.SetActive(false);
        BackBtntrue();
    }
    public void ClickWindow()
    {
        WindowON = true;
        BackBtnfalse();

        GameObject.Find("AR2C1_7").GetComponent<AR2_InteractionController>().Text();
    }
    public void ClickBookCase()
    {
        BackBtnfalse();

        GameObject.Find("AR2C1_8").GetComponent<AR2_InteractionController>().Text();
    }
    public void BookCase_1()
    {
        if (getkey == true)
        {
            forkey = true;
            progress += 1;
            Clickbookcase.SetActive(false);
            Maintext.text = "Quiz 3";
            AR2_Manager.Instance.EnableHintButton(2);
        }
        else
        {
            GameObject.Find("AR2C1_9").GetComponent<AR2_InteractionController>().Text();
            AR2_Manager.Instance.EnableHintButton(3);
        }
    }
    public void ClickDesk()
    {
        Desk.SetActive(true);

        GameObject.Find("AR2C1_10").GetComponent<AR2_InteractionController>().Text();
    }
    public void ClickDrawer()
    {
        BackBtnfalse();

        GameObject.Find("AR2C1_11").GetComponent<AR2_InteractionController>().Text();
    }
    public void ClickHeart3()
    {
        Black.SetActive(true);
        Black.GetComponent<Image>().raycastTarget = true;
        Heart3.SetActive(true);
        Destroy(Heart_3);
        Destroy(Rm_Heart3);
        isheart = true;
        BackBtnfalse();
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);

        GameObject.Find("AR2C1_12").GetComponent<AR2_InteractionController>().Text();
    }
    public void Heart3_1()
    {
        Black.SetActive(false);
        Heart3.SetActive(false); isheart = true;
        BackBtntrue(); forCards += 1;
    }
    public void ClickLamp()
    {
        isusing = true;
        Destroy(Lampoff);
        LampwithKey.SetActive(true);
        BackBtnfalse();

        GameObject.Find("AR2C1_13").GetComponent<AR2_InteractionController>().Text();
    }
    public void Lamp_1()
    {
        isusing = false;
        Destroy(LampwithKey);
        Lampon.SetActive(true);
        iskey = true;
        getkey = true;
        Rm_Lampon.SetActive(true);
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);

        GameObject.Find("AR2C1_14").GetComponent<AR2_InteractionController>().Text();
    }
    public void BookCase_2()
    {
        AR2_Close.UsingItem = false;

        GameObject.Find("AR2C1_15").GetComponent<AR2_InteractionController>().Text();
    }
    public void BookCase_3()
    {
        Destroy(Clickbookcase);
        Black.SetActive(true);
        Black.GetComponent<Image>().raycastTarget = true;
        OldEtiqutte.SetActive(true);
        isold = true;
        AR2_Manager.Instance.DisableHintButton();

        GameObject.Find("AR2C1_16").GetComponent<AR2_InteractionController>().Text();
    }
    public void BookCase_4()
    {
        Black.SetActive(false);
        OldEtiqutte.SetActive(false);
        Q3OK = true;
        BackBtntrue();
    }
    public void ClickFrame()
    {
        isusing = true;
        BackBtnfalse();

        GameObject.Find("AR2C1_17").GetComponent<AR2_InteractionController>().Text();
    }
    public void Frame_1()
    {
        Black.SetActive(true);
        Black.GetComponent<Image>().raycastTarget = true;
        Dia7.SetActive(true);
        Destroy(Dia_7);
        isdia = true;
        Destroy(BasicFrame);
        MovedFrame.SetActive(true);
        BackBtnfalse();
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);

        GameObject.Find("AR2C1_18").GetComponent<AR2_InteractionController>().Text();
    }
    public void Frame_2()
    {
        isusing = false;
        Black.SetActive(false);
        Dia7.SetActive(false);
        forCards += 1;
        BackBtntrue();
    }
    public void Notice4cards()
    {
        BackBtnfalse();

        GameObject.Find("AR2C1_19").GetComponent<AR2_InteractionController>().Text();
    }
    public void ClickMap()
    {
        BackBtnfalse();
        Black.SetActive(true);
        Black.GetComponent<Image>().raycastTarget = true;
        Map.SetActive(true);

        GameObject.Find("AR2C1_20").GetComponent<AR2_InteractionController>().Text();

        if (!Q2progress)
        {
            Q2progress = true;
            progress += 1;
            Maintext.text = "Quiz 2";
            AR2_Manager.Instance.EnableHintButton(1);
        }
    }
    public void ReturnMap()
    {
        AR2_Manager.Instance.EnableHintButton(1);
        GameObject.Find("AR2C1_20").GetComponent<AR2_InteractionController>().Text();
    }
    public void BacktoRoom()
    {
        AR2_Manager.Instance.DisableHintButton();
        Black.SetActive(false);
        Map.SetActive(false);
        BackBtntrue();
    }
    public void MapFail()
    {
        AR2_Manager.Instance.DisableHintButton();
        GameObject.Find("AR2C1_21").GetComponent<AR2_InteractionController>().Text();
    }
    public void MapSuccess()
    {
        AR2_Manager.Instance.DisableHintButton();
        Destroy(clickmap.GetComponent<AR2C1_TouchManager>());

        GameObject.Find("AR2C1_22").GetComponent<AR2_InteractionController>().Text();
    }
    public void MapSuccessEvent()
    {
        BacktoRoom();
        Hallway.SetActive(true);
        BackBtnfalse();
        isMap = true;

        if (ishallway)
        {
            Maintext.text = "제 1장 : 존스티나 대저택, 아이란의 방";
        }
        else
        {
            Maintext.text = "제 1장 : 존스티나 대저택, OOO의 방";
        }

        GameObject.Find("AR2C1_23").GetComponent<AR2_InteractionController>().Text();
    }
    public void AfterMapSuccess()
    {
        Hallway.SetActive(false);
        Q2OK = true;
        BackBtntrue();
    }
    public void ClickBox()
    {
        BoxON = true;
        BackBtnfalse();

        GameObject.Find("AR2C1_24").GetComponent<AR2_InteractionController>().Text();

    }
    public void Box_1()
    {
        if (forCards == 100)
        {
            Black.SetActive(true);
            Locker.SetActive(true);
            HiddenNotice.SetActive(true);
            progress += 1;
            Maintext.text = "Hidden Quiz";

        }
        else
        {
            BackBtntrue();
        }
    }
    public void BoxResult()
    {
        HiddenNotice.SetActive(false);
    }
    public void LockerFail()
    {
        HQprogress = true;
        Black.SetActive(false);
        Locker.SetActive(false);
        QHOK = true;

        GameObject.Find("AR2C1_25").GetComponent<AR2_InteractionController>().Text();
    }
    public void LockerSuccess()
    {
        HQprogress = true;
        Black.SetActive(false);
        Locker.SetActive(false);
        ClosedBox.SetActive(false);
        OpenBoxGun.SetActive(true);

        GameObject.Find("AR2C1_26").GetComponent<AR2_InteractionController>().Text();
    }
    public void GunGet()
    {
        isgun = true;
        GunAdd = true;
        QHOK = true;
        BackBtntrue();
        OpenBoxGun.SetActive(false);
        OpenBox.SetActive(true);
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);

    }
    public void EventStart()
    {
        Desk.SetActive(false);
        BackBtnfalse();
        ClicktoMain();
        AR2C1_BackGroundManager.Instance.ClicktoMain();

        GameObject.Find("AR2C1_27").GetComponent<AR2_InteractionController>().Text();
    }
    public void Event_1()
    {
        Debug.Log("ㄸ");
        if (ishallway == true)
        {
            EventA(); Debug.Log("1");
        }
        else if (ishallway == false)
        {
            EventB(); Debug.Log("2");
            iseventb = true;
        }
    }
    public void EventA()
    {
        ChoiceBtn_2.SetActive(true);
        C_2_1.text = "문 열기";
        C_2_2.text = "누구냐고 물어보기";
    }
    public void A_OpenDoor()
    {
        ChoiceBtn_2.SetActive(false);
        Room.SetActive(false);
        Hallway.SetActive(true);
        Invoke("A_OpenDoor_1", 0.5f);
    }
    public void A_OpenDoor_1()
    {
        Hallway.SetActive(false);
        OpenHallway.SetActive(true);
        Invoke("A_OpenDoor_2", 0.5f);
    }
    public void A_OpenDoor_2()
    {
        GameObject.Find("AR2C1_28").GetComponent<AR2_InteractionController>().Text();
    }
    public void A_OpenDoor_3()
    {
        GameObject.Find("AR2C1_29").GetComponent<AR2_InteractionController>().Text();
    }
    public void A_Asking()
    {
        ChoiceBtn_2.SetActive(false);

        GameObject.Find("AR2C1_30").GetComponent<AR2_InteractionController>().Text();
    }
    public void A2_OpenDoor()
    {
        Room.SetActive(false);
        Hallway.SetActive(true);
        Invoke("A2_OpenDoor_1", 0.5f);
    }
    public void A2_OpenDoor_1()
    {
        Hallway.SetActive(false);
        OpenHallway.SetActive(true);
        Invoke("A_Asking_1", 0.5f);
    }
    public void A_Asking_1()
    {
        GameObject.Find("AR2C1_31").GetComponent<AR2_InteractionController>().Text();
    }
    public void EventB()
    {
        ChoiceBtn_1.SetActive(true);
        C_1.text = "누구냐고 물어보기";
    }
    public void EventB_1()
    {
        ChoiceBtn_1.SetActive(false);

        GameObject.Find("AR2C1_32").GetComponent<AR2_InteractionController>().Text();
    }
    public void B_OpenDoor()
    {
        Room.SetActive(false);
        Hallway.SetActive(true);
        Invoke("B_OpenDoor_1", 0.5f);
    }
    public void B_OpenDoor_1()
    {
        Hallway.SetActive(false);
        OpenHallway.SetActive(true);
        Invoke("EventB_2", 0.5f);
    }
    public void Name()
    {
        Maintext.text = "제 1장 : 존스티나 대저택, 아이란의 방";
    }
    public void EventB_2()
    {
        GameObject.Find("AR2C1_33").GetComponent<AR2_InteractionController>().Text();
    }
    public void EventAB()
    {
        OpenHallway.SetActive(false);
        Room.SetActive(true);
        ARStuff.SetActive(true);

        GameObject.Find("AR2C1_34").GetComponent<AR2_InteractionController>().Text();
    }
    public void EventAB_1()
    {
        Black.SetActive(true);
        ClosedAdopt.SetActive(true);
        isadopt = true;
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);

        GameObject.Find("AR2C1_35").GetComponent<AR2_InteractionController>().Text();
    }
    public void EventAB_2()
    {
        ClosedAdopt.SetActive(false);
        OpenAdopt.SetActive(true);
        Invoke("EventAB_3", 0.5f);
    }
    public void EventAB_3()
    {
        OpenAdopt.SetActive(false);
        AdoptContent.SetActive(true);

        GameObject.Find("AR2C1_36").GetComponent<AR2_InteractionController>().Text();
    }
    public void EventAB_4()
    {
        AdoptContent.SetActive(false);
        ARDiary.SetActive(true);
        isdiary = true;
        SoundManager.instance.PlaySFX(Sfx.Item_Pickup);

        GameObject.Find("AR2C1_37").GetComponent<AR2_InteractionController>().Text();
    }
    public void EventAB_5()
    {
        ARDiary.SetActive(false);
        DiaryContent.SetActive(true);

        GameObject.Find("AR2C1_38").GetComponent<AR2_InteractionController>().Text();
    }
    public void AfterEventAB()
    {
        Destroy(DiaryContent);
        Black.SetActive(false);
        ARStuff.SetActive(false);
        Room.SetActive(false);
        IntroRoom.SetActive(true);

        GameObject.Find("AR2C1_39").GetComponent<AR2_InteractionController>().Text();
    }
    public void Outro_OpenDoor()
    {
        Maintext.text = "제 1장 : 존스티나 대저택의 복도";

        IntroRoom.SetActive(false);
        Hallway.SetActive(true);
        Invoke("Outro_OpenDoor_1", 0.5f);
    }
    public void Outro_OpenDoor_1()
    {
        Hallway.SetActive(false);
        OpenHallway.SetActive(true);
        Invoke("Outro", 0.5f);
    }
    public void Outro()
    {
        GameObject.Find("AR2C1_40").GetComponent<AR2_InteractionController>().Text();
    }
    public void End()
    {
        ar2c1 = false; end = true;

        DataController.instance.localData.AR2C1Gun = GunAdd;
        DataController.instance.SaveLocalData();

        progress = 0;
        Destroy(Choice_1.GetComponent<AR2C1_TouchManager>());
        Destroy(Choice2_1.GetComponent<AR2C1_TouchManager>());
        Destroy(Choice2_2.GetComponent<AR2C1_TouchManager>());
        Destroy(BackBtn.GetComponent<AR2C1_TouchManager>());
        Destroy(Close_Content.GetComponent<AR2C1_TouchManager>());
    }
}