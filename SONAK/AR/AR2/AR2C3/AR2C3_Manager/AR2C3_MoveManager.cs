using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using UnityEngine.EventSystems;

public class AR2C3_MoveManager : MonoBehaviour
{
    public static AR2C3_MoveManager Instance;
    public Timer timer;

    public TMP_Text Maintext;
    public TMP_Text tx;

    public string writerText = "";

    public GameObject Choice_1_1, Choice_2_1, Choice_2_2, Choice_3_1, Choice_3_2, Choice_3_3;
    public GameObject Quest_Select_1, Quest_Select_2;

    public GameObject Choice_3;
    public GameObject Choice_2;
    public GameObject Choice_1;
    public GameObject Icons;
    public GameObject Room;
    public GameObject Hallway;
    public GameObject Garden;
    public GameObject Black;
    public GameObject Library;
    public GameObject Quest;
    public GameObject Quest_Title;
    public GameObject Quest_BgShort;
    public GameObject Quest_BgLong;
    public GameObject Quest_textbox;
    public GameObject Quest_4;
    public GameObject Quest_4C_1;
    public GameObject Quest_4C_2;
    public GameObject Quest_4C_3;
    public GameObject Quest_4C_4;
    public GameObject Quest_5;
    public GameObject Quest_Selected;
    public GameObject Inventory;
    public GameObject Ballroom;
    public GameObject Poor;
    public GameObject Prince;
    public GameObject Prince_Shadow;
    public GameObject Chess;
    public GameObject Chess_Queen;
    public GameObject PopupTextbox;
    public GameObject Jstn1;
    public GameObject Jstn2;
    public GameObject JstnMom;
    public GameObject Wall;
    public GameObject Title;
    public GameObject Skill;
    public GameObject OutroClick;

    public Text Choice3_1;
    public Text Choice3_2;
    public Text Choice3_3;
    public Text Choice2_1;
    public Text Choice2_2;
    public Text Choice1_1;
    public Text Quest_Text;
    public Text Quest_4_1;
    public Text Quest_4_2;
    public Text Quest_4_3;
    public Text Quest_4_4;
    public Text Quest_S_1;
    public Text Quest_S_2;

    public bool LastCheck = false;
    public bool forNextChap = false;

    bool KitchenEnd = false;
    bool RoomEnd = false;
    bool HallwayEnd = false;
    bool GirlSuccess = false;
    bool SecondSuccess = false;
    bool FirstSuccess = false;
    bool FirstEnd = false;
    bool SecondEnd = false;
    bool First0 = false;
    bool Again = false;
    bool chapstart = false;
    bool kitchentour = false;
    bool butler = false;

    int Girlpoint = 0;
    int Secondpoint = 0;
    int Firstpoint = 0;
    int Num = 0;
    int Num2 = 0;

    bool TextCheck = false;
    bool IntroCheck = false;

    bool TextCheck2 = false;
    bool IntroCheck2 = false;

    int[] AR2C3_time = new int[] { 7, 0 };

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    void Update()
    {
        if (chapstart)
        {
            if (kitchentour && butler == false)
            {
                AR2_Manager.Instance.EnableHintButton(120);
            }
            else if (butler)
            {
                AR2_Manager.Instance.EnableHintButton(110);
            }
            else
            {
                AR2_Manager.Instance.EnableHintButton(100);
            }
        }
        else
        {
            AR2_Manager.Instance.DisableHintButton();
        }
    }
    private void OnDisable()
    {
        Destroy(Choice_1_1.GetComponent<AR2C3_TouchManager>());
        Destroy(Choice_2_1.GetComponent<AR2C3_TouchManager>());
        Destroy(Choice_2_2.GetComponent<AR2C3_TouchManager>());
        Destroy(Choice_3_1.GetComponent<AR2C3_TouchManager>());
        Destroy(Choice_3_2.GetComponent<AR2C3_TouchManager>());
        Destroy(Choice_3_3.GetComponent<AR2C3_TouchManager>());
        chapstart = false;
        if (Inventory.GetComponent<AR_TouchManager>() == null)
        {
            Inventory.AddComponent<AR_TouchManager>();
        }
    }
    void OnEnable()
    {
        AR2_Close.UsingItem = true;

        Choice_1_1.AddComponent<AR2C3_TouchManager>();
        Choice_2_1.AddComponent<AR2C3_TouchManager>();
        Choice_2_2.AddComponent<AR2C3_TouchManager>();
        Choice_3_1.AddComponent<AR2C3_TouchManager>();
        Choice_3_2.AddComponent<AR2C3_TouchManager>();
        Choice_3_3.AddComponent<AR2C3_TouchManager>();
        Quest_Select_1.AddComponent<AR2C3_TouchManager>();
        Quest_Select_2.AddComponent<AR2C3_TouchManager>();
        Quest_4C_1.AddComponent<AR2C3_TouchManager>();
        Quest_4C_2.AddComponent<AR2C3_TouchManager>();
        Quest_4C_3.AddComponent<AR2C3_TouchManager>();
        Quest_4C_4.AddComponent<AR2C3_TouchManager>();
    }
    public void TimeStart()
    {
        timer.StartTimer(AR2C3_time[0], AR2C3_time[1]);
    }
    public void IntroExplain()
    {
        Black.SetActive(false);
        PopupTextbox.SetActive(true);
    }
    public void IntroEnd()
    {
        PopupTextbox.SetActive(false);
        Maintext.text = "존스티나 저택, 아이란의 방";
        chapstart = true;

        GameObject.Find("AR2C3_1").GetComponent<AR2_InteractionController>().Text();
    }

    public void ChapterStart()
    {
        BackgroundReset();

        if (KitchenEnd == false && HallwayEnd == false && RoomEnd == false)
        {
            Choice_3.SetActive(true);
            Choice3_1.text = "일단 밖으로 나간다";
            Choice3_2.text = "주방으로 가본다";
            Choice3_3.text = "방에 가만히 있는다";
        }
        else if (KitchenEnd && HallwayEnd == false && RoomEnd == false)
        {
            Choice_2.SetActive(true);
            Choice2_1.text = "일단 밖으로 나간다";
            Choice2_2.text = "방에 가만히 있는다";
        }
        else if (KitchenEnd == false && HallwayEnd && RoomEnd == false)
        {
            Choice_2.SetActive(true);
            Choice2_1.text = "주방으로 가본다";
            Choice2_2.text = "방에 가만히 있는다";
        }
        else if (KitchenEnd == false && HallwayEnd == false && RoomEnd)
        {
            Choice_2.SetActive(true);
            Choice2_1.text = "일단 밖으로 나간다";
            Choice2_2.text = "주방으로 가본다";
        }
        else if (KitchenEnd == false && HallwayEnd && RoomEnd)
        {
            Choice_1.SetActive(true);
            Choice1_1.text = "주방으로 가본다";
        }
        else if (KitchenEnd && HallwayEnd == false && RoomEnd)
        {
            Choice_1.SetActive(true);
            Choice1_1.text = "일단 밖으로 나간다";
        }
        else if (KitchenEnd && HallwayEnd && RoomEnd == false)
        {
            Choice_1.SetActive(true);
            Choice1_1.text = "방에 가만히 있는다";
        }
        else
        {
            Restaurant();
        }
    }
    public void BackgroundReset()
    {
        Hallway.SetActive(false);
        Library.SetActive(false);
        Garden.SetActive(false);
        Room.SetActive(true);
        JstnMom.SetActive(false);
    }

    public void ClickToRoom()
    {
        Choice_3.SetActive(false); Choice_2.SetActive(false); Choice_1.SetActive(false);

        GameObject.Find("AR2C3_2").GetComponent<AR2_InteractionController>().Text();
    }
    public void Room_1()
    {
        Choice_3.SetActive(true);
        Choice3_1.text = "무슨 일이야?";
        Choice3_2.text = "왜 찾아왔어?";
        Choice3_3.text = "반가워";
    }
    public void Room_1_1()
    {
        Choice_3.SetActive(false);

        GameObject.Find("AR2C3_3").GetComponent<AR2_InteractionController>().Text();
    }
    public void Room_1_2()
    {
        Choice_3.SetActive(false);
        Girlpoint -= 5;

        GameObject.Find("AR2C3_3").GetComponent<AR2_InteractionController>().Text();
    }
    public void Room_1_3()
    {
        Choice_3.SetActive(false);
        Girlpoint += 5;

        GameObject.Find("AR2C3_4").GetComponent<AR2_InteractionController>().Text();
    }
    public void Room__2()
    {
        GameObject.Find("AR2C3_5").GetComponent<AR2_InteractionController>().Text();
    }
    public void Room_2()
    {
        Choice_2.SetActive(true);
        Choice2_1.text = "매일 찾아오는 거 좀 부담스러워.";
        Choice2_2.text = "(부담스럽다는 걸 티내지 않는다.)";
    }
    public void Room_2_1()
    {
        Choice_2.SetActive(false);
        Girlpoint -= 5;

        GameObject.Find("AR2C3_6").GetComponent<AR2_InteractionController>().Text();
    }
    public void Room_2_2()
    {
        Choice_2.SetActive(false);
        Girlpoint += 5;

        GameObject.Find("AR2C3_7").GetComponent<AR2_InteractionController>().Text();
    }
    public void RoomResult()
    {
        RoomEnd = true;

        if (Girlpoint > -10 && Girlpoint < 10)
        {
            GameObject.Find("AR2C3_9").GetComponent<AR2_InteractionController>().Text();
            GirlSuccess = true;
        }
        else
        {
            GameObject.Find("AR2C3_8").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void ClickToHallway()
    {
        Maintext.text = "존스티나 저택, 복도";

        Choice_3.SetActive(false);
        Choice_2.SetActive(false);
        Choice_1.SetActive(false);
        Room.SetActive(false);
        Hallway.SetActive(true);

        GameObject.Find("AR2C3_10").GetComponent<AR2_InteractionController>().Text();
    }
    public void Hallway_1()
    {
        Choice_3.SetActive(true);
        Choice3_1.text = "할 게 없어서 걷는데";
        Choice3_2.text = "그건 왜?";
        Choice3_3.text = "......";
    }
    public void Hallway_1_1()
    {
        Choice_3.SetActive(false);
        Secondpoint += 5;

        GameObject.Find("AR2C3_11").GetComponent<AR2_InteractionController>().Text();
    }
    public void Hallway_1_2()
    {
        Choice_3.SetActive(false);
        HallwayEnd = true;

        GameObject.Find("AR2C3_12").GetComponent<AR2_InteractionController>().Text();
    }
    public void Hallway_1_3()
    {
        Choice_3.SetActive(false);
        Secondpoint -= 5;
        HallwayEnd = true;

        GameObject.Find("AR2C3_13").GetComponent<AR2_InteractionController>().Text();
    }
    public void Hallway_2()
    {
        Choice_3.SetActive(true);
        Choice3_1.text = "좋아";
        Choice3_2.text = "싫어";
        Choice3_3.text = "대답하지 않는다";
    }
    public void Hallway_2_1()
    {
        Choice_3.SetActive(false);
        Maintext.text = "존스티나 저택, 도서관";
        Hallway.SetActive(false);
        Library.SetActive(true);
        Secondpoint += 5;

        GameObject.Find("AR2C3_14").GetComponent<AR2_InteractionController>().Text();
    }
    public void Hallway_2_2()
    {
        Choice_3.SetActive(false);
        if (Again)
        {

        }
        else
        {
            Again = true;
            Secondpoint += 5;
        }

        GameObject.Find("AR2C3_15").GetComponent<AR2_InteractionController>().Text();
    }
    public void Hallway_2_3()
    {
        Choice_3.SetActive(false);
        if (Again)
        {
            Secondpoint -= 10;
        }
        else
        {
            Secondpoint -= 5;
        }
        HallwayEnd = true;

        GameObject.Find("AR2C3_16").GetComponent<AR2_InteractionController>().Text();
    }
    public void ArriveatLibrary()
    { 
        GameObject.Find("AR2C3_17").GetComponent<AR2_InteractionController>().Text();
    }
    public void Library_1()
    {
        Choice_2.SetActive(true);
        Choice2_1.text = "먼저 말을 붙여본다";
        Choice2_2.text = "각자 책만 읽는다";
    }
    public void Library_1_1()
    {
        Choice_2.SetActive(false);
        Firstpoint -= 5;
        HallwayEnd = true;

        GameObject.Find("AR2C3_18").GetComponent<AR2_InteractionController>().Text();
    }
    public void Library_1_2()
    {
        Choice_2.SetActive(false);
        Firstpoint += 5;

        GameObject.Find("AR2C3_19").GetComponent<AR2_InteractionController>().Text();
    }
    public void Library_2()
    {
        Skill.SetActive(true);
    }
    public void Library_3()
    {
        Skill.SetActive(false);
        Quest.SetActive(true);
        Quest_BgShort.SetActive(true);
        Quest_textbox.SetActive(true);
        Quest_4.SetActive(true);
        Quest_Text.text = "아이란은 종종 홍차를 권유받곤 했습니다.\n다음 중 정말로 홍차를 마셔도\n되는 상황은 무엇이었을까요?";
        Quest_4_1.text = "홍차 마실래?";
        Quest_4_2.text = "그렇게 바쁘게 가지 말고,\n홍차 한 잔 마시고 가.";
        Quest_4_3.text = "홍차로 괜찮을까?";
        Quest_4_4.text = "목이 마르네. 홍차는 어때?";

        if (KitchenEnd)
        {
            Quest_BgLong.SetActive(false);
            Quest_Selected.SetActive(false);
        }
    }
    public void LibraryQuestSuccess()
    {
        Firstpoint += 5;
        Quest.SetActive(false);
        HallwayEnd = true;

        GameObject.Find("AR2C3_20").GetComponent<AR2_InteractionController>().Text();
    }
    public void LibraryQuestFail()
    {
        Firstpoint -= 5;
        Quest.SetActive(false);
        HallwayEnd = true;

        GameObject.Find("AR2C3_21").GetComponent<AR2_InteractionController>().Text();
    }
    public void ClickToKitchen()
    {
        Maintext.text = "존스티나 저택, 복도";

        Choice_3.SetActive(false);
        Choice_2.SetActive(false);
        Choice_1.SetActive(false);
        Room.SetActive(false);
        Hallway.SetActive(true);
        kitchentour = true;

        GameObject.Find("AR2C3_22").GetComponent<AR2_InteractionController>().Text();
    }
    public void Kitchen_1()
    {
        Quest.SetActive(true);
        Quest_Title.SetActive(false);
        Quest_Selected.SetActive(true);
        Quest_BgLong.SetActive(true);
        Quest_textbox.SetActive(true);
        Quest_Text.text = "아이란은 집사에게 \"오른쪽 길로 가면\n여기를 벗어날 수 있나요?\"라고 물었습니다.\n집사는 고개를 끄덕거렸습니다.\n하지만 아이란은 귀족식 표현을 모르므로,\n고개를 끄덕거리는 것이\n아니라는 의미일지도 모릅니다.\n\n아이란이 고민하자\n하녀 첼리가 도와주겠다고 나섰습니다.\n\"고개를 끄덕이는 것은 '예'라는 의미예요.\n하지만 집사님은 아가씨가 싫어서\n거짓말을 한 게 틀림없어요.\"\n\n고민스럽게도 아이란은\n집사와 하녀 둘 다 신뢰할 수가 없습니다.\n아이란은 정말로 오른쪽 길로 가야 할까요?\n(거짓말을 하는 사람은 거짓말만 합니다.) ";
        Quest_S_1.text = "오른쪽으로 간다";
        Quest_S_2.text = "왼쪽으로 간다";
        butler = true;
        if (HallwayEnd)
        {
            Quest_BgShort.SetActive(false);
            Quest_4.SetActive(false);
        }
    }
    public void kitchenFail()
    {
        Quest.SetActive(false);
        WrongGarden();
        butler = false;
    }
    public void kitchenSuccess()
    {
        Quest.SetActive(false);
        butler = false;

        GameObject.Find("AR2C3_23").GetComponent<AR2_InteractionController>().Text();
    }
    public void Kitchen_2()
    {
        Maintext.text = "존스티나 저택, 주방";

        GameObject.Find("AR2C3_24").GetComponent<AR2_InteractionController>().Text();
    }
    public void Kitchen_3()
    {
        Choice_2.SetActive(true);
        Choice2_1.text = "무시한다";
        Choice2_2.text = "굶었냐고 물어본다";
    }
    public void Kitchen_3_1()
    {
        Choice_2.SetActive(false);
        KitchenEnd = true;
        kitchentour = false;

        GameObject.Find("AR2C3_25").GetComponent<AR2_InteractionController>().Text();
    }
    public void Kitchen_3_2()
    {
        Choice_2.SetActive(false);
        KitchenEnd = true;
        kitchentour = false;

        GameObject.Find("AR2C3_26").GetComponent<AR2_InteractionController>().Text();
    }
    public void Kitchen_3_2_1()
    {
        Library.SetActive(true);
        Jstn1.SetActive(true);

        GameObject.Find("AR2C3_27").GetComponent<AR2_InteractionController>().Text();
    }
    public void Kitchen_3_2_2()
    {
        Hallway.SetActive(true); Library.SetActive(false);
        Jstn1.SetActive(false); Jstn2.SetActive(true);

        GameObject.Find("AR2C3_28").GetComponent<AR2_InteractionController>().Text();
    }
    public void Kitchen_3_2_3()
    {
        Garden.SetActive(true); Hallway.SetActive(false);
        Jstn2.SetActive(false); JstnMom.SetActive(true);
        KitchenEnd = true;
        kitchentour = false;

        GameObject.Find("AR2C3_29").GetComponent<AR2_InteractionController>().Text();
    }
    public void WrongGarden()
    {
        Maintext.text = "존스티나 저택, 정원";

        Garden.SetActive(true);
        Quest.SetActive(false);

        GameObject.Find("AR2C3_30").GetComponent<AR2_InteractionController>().Text();
    }
    public void Garden_1()
    {
        Choice_2.SetActive(true);
        Choice2_1.text = "인사한다";
        Choice2_2.text = "못 본 척 도망친다";
    }
    public void Garden_1_1()
    {
        Choice_2.SetActive(false);

        GameObject.Find("AR2C3_31").GetComponent<AR2_InteractionController>().Text();
    }
    public void Garden_1_2()
    {
        Choice_2.SetActive(false);
        KitchenEnd = true;
        kitchentour = false;
        Garden.SetActive(false);
        Room.SetActive(true);
        ChapterStart();
    }
    public void Restaurant()
    {
        Maintext.text = "존스티나 공작가, 식당";
        Hallway.SetActive(true);

        Debug.Log("first = " + Firstpoint);
        Debug.Log("Second = " + Secondpoint);
        Debug.Log(GirlSuccess);

        GameObject.Find("AR2C3_32").GetComponent<AR2_InteractionController>().Text();
    }
    public void RestaurantStart()
    {
        if (FirstEnd == false && SecondEnd == false)
        {
            Choice_2.SetActive(true);
            Choice2_1.text = "테인 존스티나";
            Choice2_2.text = "알렉스 존스티나";
        }
        else if (SecondEnd && FirstEnd == false)
        {
            Choice_1.SetActive(true);
            Choice1_1.text = "테인 존스티나";
        }
        else if (SecondEnd == false && FirstEnd)
        {
            Choice_1.SetActive(true);
            Choice1_1.text = "알렉스 존스티나";
        }
        else
        {
            ChapterResult();
        }
    }
    public void ClickFirst()
    {
        Choice_1.SetActive(false);
        Choice_2.SetActive(false);

        if (Firstpoint > 0)
        {
            GameObject.Find("AR2C3_33").GetComponent<AR2_InteractionController>().Text();
        }
        else if (Firstpoint == 0)
        {
            FirstEnd = true;
            First0 = true;
            GameObject.Find("AR2C3_35").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            GameObject.Find("AR2C3_36").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void First_1()
    {
        Choice_2.SetActive(true);
        Choice2_1.text = "그러지 뭐.\n공부야 재밌으니까.";
        Choice2_2.text = "더 이상 별로\n공부하고 싶지 않아.";
    }
    public void First_1_1()
    {
        Choice_2.SetActive(false);
        Firstpoint += 5;
        FirstEnd = true;
        FirstSuccess = true;

        GameObject.Find("AR2C3_34").GetComponent<AR2_InteractionController>().Text();
    }
    public void First_1_2()
    {
        Choice_2.SetActive(false);
        Firstpoint -= 10;

        if (Firstpoint < 0)
        {
            GameObject.Find("AR2C3_36").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            GameObject.Find("AR2C3_35").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void ClickSecond()
    {
        Choice_1.SetActive(false);
        Choice_2.SetActive(false);

        if (Secondpoint < 0)
        {
            GameObject.Find("AR2C3_37").GetComponent<AR2_InteractionController>().Text();
        }
        else if (Secondpoint == 0)
        {
            GameObject.Find("AR2C3_38").GetComponent<AR2_InteractionController>().Text();
        }
        else
        {
            GameObject.Find("AR2C3_40").GetComponent<AR2_InteractionController>().Text();
            SecondSuccess = true;
        }
    }
    public void Second_1()
    {
        Choice_2.SetActive(true);
        Choice2_1.text = "말없이 고개를 숙인다";
        Choice2_2.text = "됐어. 가봤자 무시당해.";
    }
    public void Second_1_1()
    {
        Choice_2.SetActive(false);
        Secondpoint -= 5;

        if (SecondSuccess)
        {
            GameObject.Find("AR2C3_41").GetComponent<AR2_InteractionController>().Text();
            SecondEnd = true;
        }
        else
        {
            GameObject.Find("AR2C3_39").GetComponent<AR2_InteractionController>().Text();
        }
    }
    public void Second_1_2()
    {
        Choice_2.SetActive(false);
        Secondpoint += 5;
        SecondEnd = true;
        SecondSuccess = true;

        GameObject.Find("AR2C3_41").GetComponent<AR2_InteractionController>().Text();
    }
    public void ChapterResult()
    {
        if (GirlSuccess && FirstSuccess)
        {
            ChapterSucess();
        }
        else if (First0 && GirlSuccess)
        {
            GameObject.Find("AR2C3_43").GetComponent<AR2_InteractionController>().Text();
        }
        else if (First0 && GirlSuccess == false)
        {
            GameObject.Find("AR2C3_44").GetComponent<AR2_InteractionController>().Text();
        }
        else if (FirstSuccess && GirlSuccess == false)
        {
            GameObject.Find("AR2C3_42").GetComponent<AR2_InteractionController>().Text();
        }
    }
    #region 성공
    public void ChapterSucess()
    {
        Hallway.SetActive(false);
        Ballroom.SetActive(true);

        GameObject.Find("AR2C3_46").GetComponent<AR2_InteractionController>().Text();
    }
    public void outro()
    {
        Icons.SetActive(false);
        Title.SetActive(true);

        IntroCheck = true; OutroClick.SetActive(true);
        StartCoroutine(TextArr1_1());
    }
    public void Success_1()
    {
        Ballroom.SetActive(false);
        Poor.SetActive(true);
    }
    public void Success_2()
    {
        Poor.SetActive(false);
        Prince.SetActive(true);
    }
    public void Success_3()
    {
        OutroClick.SetActive(false); Title.SetActive(false);
        Prince.SetActive(false); Black.SetActive(false);
        Ballroom.SetActive(true); Icons.SetActive(true);

        GameObject.Find("AR2C3_47").GetComponent<AR2_InteractionController>().Text();
    }
    public void Success_4()
    {
        Ballroom.SetActive(false);
        Prince_Shadow.SetActive(true);

        GameObject.Find("AR2C3_48").GetComponent<AR2_InteractionController>().Text();
    }
    public void Success_5()
    {
        Prince_Shadow.SetActive(false);
        Ballroom.SetActive(true);

        GameObject.Find("AR2C3_49").GetComponent<AR2_InteractionController>().Text();
    }
    public void Success_6()
    {
        Ballroom.SetActive(false);
        Wall.SetActive(true);

        GameObject.Find("AR2C3_50").GetComponent<AR2_InteractionController>().Text();
    }
    public void Success_7()
    {
        Wall.SetActive(false);
        Chess.SetActive(true);

        GameObject.Find("AR2C3_51").GetComponent<AR2_InteractionController>().Text();
    }
    public void Success_8()
    {
        Chess.SetActive(false);
        Chess_Queen.SetActive(true);

        GameObject.Find("AR2C3_52").GetComponent<AR2_InteractionController>().Text();
    }
    public void Success_9()
    {
        Chess_Queen.SetActive(false);
        Wall.SetActive(true);
        LastCheck = true;

        Title.SetActive(true);
        Icons.SetActive(false);

        IntroCheck2 = true; OutroClick.SetActive(true);
        StartCoroutine(TextArrLast1_1());
    }
    public void Success_10()
    {
        Title.SetActive(false);
        Icons.SetActive(true);
        OutroClick.SetActive(false);

        GameObject.Find("AR2C3_53").GetComponent<AR2_InteractionController>().Text();
    }
    public void ResetButton()
    {
        Destroy(Choice_1_1.GetComponent<AR2C3_TouchManager>());
        Destroy(Choice_2_1.GetComponent<AR2C3_TouchManager>());
        Destroy(Choice_2_2.GetComponent<AR2C3_TouchManager>());
        Destroy(Choice_3_1.GetComponent<AR2C3_TouchManager>());
        Destroy(Choice_3_2.GetComponent<AR2C3_TouchManager>());
        Destroy(Choice_3_3.GetComponent<AR2C3_TouchManager>());
        if (Inventory.GetComponent<AR_TouchManager>() == null)
        {
            Inventory.AddComponent<AR_TouchManager>();
        }
    }
    #region 타이핑
    IEnumerator _typing(string narration)
    {
        bool t_ignore = false;

        writerText = "";

        for (int i = 0; i < narration.Length; i++)
        {
            if (TextCheck)
            {
                TextCheck = false;

                tx.text = narration;

                break;
            }
            else
            {
                string t_letter = narration[i].ToString();

                if (!t_ignore)
                {
                    writerText += t_letter;
                    tx.text = writerText;
                }
                t_ignore = false;

                yield return new WaitForSeconds(0.1f);
            }
        }

        Num++; IntroCheck = false;
    }

    IEnumerator _typing2(string narration)
    {
        bool t_ignore = false;

        writerText = "";

        for (int i = 0; i < narration.Length; i++)
        {
            if (TextCheck2)
            {
                TextCheck2 = false;

                tx.text = narration;

                break;
            }
            else
            {
                string t_letter = narration[i].ToString();

                if (!t_ignore)
                {
                    writerText += t_letter;
                    tx.text = writerText;
                }
                t_ignore = false;

                yield return new WaitForSeconds(0.1f);
            }
        }

        Num2++; IntroCheck2 = false;
    }

    IEnumerator TextArr1_1()
    {
        yield return StartCoroutine(_typing("그날 밤 무도회는 떠들썩했다."));
    }

    public void TextStart1()
    {
        if (IntroCheck && !TextCheck)
        {
            TextCheck = true;
        }
        else if (Num == 1 && !IntroCheck)
        {
            IntroCheck = true;
            Success_1();

            StartCoroutine(TextArr1_2());
        }
        else if (Num == 2 && !IntroCheck)
        {
            IntroCheck = true;
            Success_2();

            StartCoroutine(TextArr1_3());
        }
        else
        {
            Num = 0;
            Success_3();
        }
    }

    IEnumerator TextArr1_2()
    {
        yield return StartCoroutine(_typing("빈민가에서 자라난 왕자,\n뒤늦게 왕실의 일원이 된 왕자."));
    }

    IEnumerator TextArr1_3()
    {
        yield return StartCoroutine(_typing("버려진 제 3왕자가 처음으로\n공식 석상에 모습을\n드러내는 날이었기 때문이다."));
    }

    IEnumerator TextArrLast1_1()
    {
        yield return StartCoroutine(_typing2("제 3왕자는 아이란에게\n설명했습니다."));
    }

    public void TextStart2()
    {
        if (IntroCheck2 && !TextCheck2)
        {
            TextCheck2 = true;
        }
        else if (Num2 == 1 && !IntroCheck2)
        {
            IntroCheck2 = true;

            StartCoroutine(TextArrLast1_2());
        }
        else if (Num2 == 2 && !IntroCheck2)
        {
            IntroCheck2 = true;

            StartCoroutine(TextArrLast1_3());
        }
        else if (Num2 == 3)
        {
            LastCheck = false;
            Num2 = 0;
            Success_10();
        }
    }

    IEnumerator TextArrLast1_2()
    {
        yield return StartCoroutine(_typing2("사교계에 진입해\n 인맥을 쌓고, 살아남아서\n꼭 아카데미에 입학하라고."));
    }

    IEnumerator TextArrLast1_3()
    {
        yield return StartCoroutine(_typing2("나탈리스 왕립 아카데미는\n외부로부터 보호받는 곳이니까."));
    }
    #endregion

    #endregion
}