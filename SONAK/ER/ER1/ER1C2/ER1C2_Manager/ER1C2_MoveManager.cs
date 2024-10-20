using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ER1C2_MoveManager : MonoBehaviour
{
    public static ER1C2_MoveManager Instance;
    public Timer timer;

    public TMP_InputField food_1;
    public TMP_InputField food_2;
    public TMP_InputField food_3;

    public TMP_Text MainText;

    public GameObject Icon;
    public GameObject Backbtn;
    public GameObject Rightbtn;
    public GameObject Leftbtn;
    public GameObject Arrows;
    public GameObject HallBasicBG;
    public GameObject HallRightBG;
    public GameObject HerbShopBG;
    public GameObject Kitchen_LeftBG;
    public GameObject Kitchen_RightBG;
    public GameObject BackyardBG;
    public GameObject MountainBG;
    public GameObject FootLeftBG;
    public GameObject FootRightBG;
    public GameObject Black;
    public GameObject Quest1;
    public GameObject Quest2;
    public GameObject Quest3;
    public GameObject Quest4;
    public GameObject Hall_C;
    public GameObject HorseLeft;
    public GameObject KitchenL_C;
    public GameObject BackL_C;
    public GameObject BackR_C;
    public GameObject FootLeft_C;
    public GameObject FootRight_C;
    public GameObject DoorEye_Basic;
    public GameObject DoorEye_Answer;
    public GameObject DoorQuiz;
    public GameObject DrawerQuiz;
    public GameObject BoxQuiz;
    public GameObject Box_Confirm;
    public GameObject TreeQuiz;
    public GameObject TreeEx;
    public GameObject Lake_C;
    public GameObject BoxOpen;
    public GameObject BoxFood;
    public GameObject Box_C;
    public GameObject DrawerOpen;
    public GameObject Kettle;
    public GameObject Drawer_C;
    public GameObject Flower1;
    public GameObject Flower2image;
    public GameObject Flower2_C;
    public GameObject Kit_Woods;
    public GameObject Kit_Fire;
    public GameObject Kit_Smoke;
    public GameObject Big_Bow;
    public GameObject Skill_1;
    public GameObject Skill1FX;
    public GameObject BlackWolf;
    public GameObject DeadWolf;
    public GameObject SkillARFX;


    public bool GetFood = false;
    public bool GetKettle = false;
    public bool GetWoods = false;
    public bool GetWater = false;
    public bool KitRight = false;
    public bool UseWater = false;
    public bool UsedWoods = false;
    public bool UsedKettle = false;
    public bool UseFood = false;
    public bool UsedPotFood = false;
    public bool FireEnd = false;
    public bool isBoxFirst = false;
    public bool FailTree = false;
    public bool FailBox = false;
    public bool FailStew = false;
    public bool isKitchen = false;
    public bool GotWater = false;

    public int progress = 0;
    public static int Q5select = 0;

    bool isDoor = false;
    bool isDoorFirst = false;
    bool isDrawer = false;
    bool isBox = false;
    bool isKettle = false;
    bool isforest = false;
    bool isBackFirst = false;
    bool isWood = false;
    bool WoodEnd = false;
    bool isDrawerFirst = false;
    bool isFlower = false;
    bool FlowerEnd = false;
    bool isPot = false;
    bool isFire = false;
    bool isLake = false;

    int[] ER1C2_time = new int[] { 8, 0 };

    int ForKitchen = 0;
    void Awake()
    {
        if (Instance == null)
            Instance = this;

        Backbtn.AddComponent<ER1C2_TouchManager>();
    }
    void OnDisable()
    {
        Destroy(Backbtn.GetComponent<ER1C2_TouchManager>());
        Q5select = 0;
    }

    public void TimeStart()
    {
        timer.StartTimer(ER1C2_time[0], ER1C2_time[1]);
    }
    public void ToMain()
    {
        if (isDoor)
        {
            isDoor = false;
            HallBasicBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            HallBasicBG.transform.localScale = new Vector3(1, 1, 1);
            DoorQuiz.SetActive(false);
            DoorEye_Basic.SetActive(true);
            Hall_C.SetActive(true);
            Backbtn.SetActive(false);
            MainText.text = "터이럼 마을, 마을 회관";
        }
        else if (isBox)
        {
            isBox = false;
            KitchenL_C.SetActive(true);
            Arrows.SetActive(true);
            Black.SetActive(false);
            BoxQuiz.SetActive(false);
            Backbtn.SetActive(false);
            food_1.text = "";
            food_2.text = "";
            food_3.text = "";
            MainText.text = "에르덴 여관, 부엌";
        }
        else if (isDrawer)
        {
            isDrawer = false;
            KitchenL_C.SetActive(true);
            Arrows.SetActive(true);
            Black.SetActive(false);
            DrawerQuiz.SetActive(false);
            Backbtn.SetActive(false);
        }
        else if (isFlower)
        {
            isFlower = false;
            Backbtn.SetActive(false);
            BackyardBG.transform.localScale = new Vector3(1, 1, 1);
            BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(412, 6);
            Arrows.SetActive(true);
            GetWater = false;
        }
        else if (isPot)
        {
            isPot = false;
            Backbtn.SetActive(false);
            Kitchen_RightBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            Kitchen_RightBG.transform.localScale = new Vector2(1, 1);
            Arrows.SetActive(true);
        }
        else if (isLake)
        {
            isLake = false;
            GetWater = false;
            Backbtn.SetActive(false);
            BackL_C.SetActive(true);
            BackyardBG.transform.localScale = new Vector3(1, 1, 1);
            BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(412, 6);
            Arrows.SetActive(true);
        }
    }
    public void ToRight()
    {
        if (isKitchen)
        {
            switch (ForKitchen)
            {
                case 0:
                    MainText.text = "에르덴 여관, 부엌";
                    ForKitchen = 1;
                    Kitchen_LeftBG.SetActive(false);
                    Kitchen_RightBG.SetActive(true);
                    KitchenL_C.SetActive(false);
                    Leftbtn.SetActive(true);
                    KitRight = true;
                    break;
                case 1:
                    MainText.text = "에르덴 여관, 뒷마당";
                    ForKitchen = 2;
                    Kitchen_RightBG.SetActive(false);
                    BackyardBG.SetActive(true);
                    BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(412, 6);
                    BackL_C.SetActive(true);
                    BackConversation();
                    KitRight = false;
                    break;
                case 2:
                    MainText.text = "에르덴 여관, 뒷마당";
                    ForKitchen = 3;
                    BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-412, 6);
                    BackL_C.SetActive(false);
                    if (BackR_C != null)
                    {
                        BackR_C.SetActive(true);
                    }
                    Rightbtn.SetActive(false);
                    KitRight = false;
                    break;
            }
        }
        else if (isforest)
        {
            FootLeftBG.SetActive(false);
            FootLeft_C.SetActive(false);
            FootRightBG.SetActive(true);
            FootRight_C.SetActive(true);
            Rightbtn.SetActive(false);
            Leftbtn.SetActive(true);
        }
    }
    public void ToLeft()
    {
        if (isKitchen)
        {
            switch (ForKitchen)
            {
                case 1:
                    MainText.text = "에르덴 여관, 부엌";
                    ForKitchen = 0;
                    Kitchen_LeftBG.SetActive(true);
                    Kitchen_RightBG.SetActive(false);
                    KitchenL_C.SetActive(true);
                    Leftbtn.SetActive(false);
                    KitRight = false;
                    break;
                case 2:
                    MainText.text = "에르덴 여관, 부엌";
                    ForKitchen = 1;
                    BackyardBG.SetActive(false);
                    BackL_C.SetActive(false);
                    Kitchen_RightBG.SetActive(true);
                    KitRight = true;
                    if (isFire)
                    {
                        isFire = false;
                        Kitchen_RightBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
                        Kitchen_RightBG.transform.localScale = new Vector2(1, 1);
                    }
                    break;
                case 3:
                    MainText.text = "에르덴 여관, 뒷마당";
                    ForKitchen = 2;
                    BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(412, 6);
                    BackL_C.SetActive(true);
                    Rightbtn.SetActive(true);
                    BackConversation();
                    KitRight = false;
                    if (BackR_C != null)
                    {
                        BackR_C.SetActive(false);
                    }
                    break;
            }
        }
        else if (isforest)
        {
            FootLeftBG.SetActive(true);
            FootLeft_C.SetActive(true);
            FootRightBG.SetActive(false);
            FootRight_C.SetActive(false);
            Rightbtn.SetActive(true);
            Leftbtn.SetActive(false);
        }
    }
    public void ChapterStart()
    {
        MainText.text = "터이럼 마을, 마을 회관";
        Icon.SetActive(true);
        GameObject.Find("ER1C2_1").GetComponent<ER1_InteractionController>().Text();
    }
    public void ChapterStart_1()
    {
        Quest1.SetActive(true);
    }
    public void ChapStart_1()
    {
        Quest1.SetActive(false);
        Hall_C.SetActive(true);
    }
    public void ClickDoor()
    {
        ER1_Manager.Instance.EnableHintButton(5);
        progress = 1;
        MainText.text = "Quiz 1";
        Hall_C.SetActive(false);
        HallBasicBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(89, -723);
        HallBasicBG.transform.localScale = new Vector3(2, 2, 2);
        if (isDoorFirst)
        {
            Door_1();
        }
        else
        {
            GameObject.Find("ER1C2_2").GetComponent<ER1_InteractionController>().Text();
            isDoorFirst = true;
        }
        
    }
    public void Door_1()
    {
        Backbtn.SetActive(true);
        isDoor = true;
        DoorEye_Basic.SetActive(false);
        DoorQuiz.SetActive(true);
    }
    public void DoorSuccess()
    {
        MainText.text = "터이럼 마을, 마을 회관";
        ER1_Manager.Instance.DisableHintButton();

        DoorQuiz.SetActive(false);
        DoorEye_Answer.SetActive(true);
        Backbtn.SetActive(false);

        GameObject.Find("ER1C2_4").GetComponent<ER1_InteractionController>().Text();
    }
    public void HerbshopThink()
    {
        isDoor = false;
        HallBasicBG.SetActive(false);
        Hall_C.SetActive(false);
        HerbShopBG.SetActive(true);

        GameObject.Find("ER1C2_4_1").GetComponent<ER1_InteractionController>().Text();
    }
    public void ArriveHouse()
    {
        MainText.text = "에르덴 여관, 부엌";

        HerbShopBG.SetActive(false);
        Kitchen_LeftBG.SetActive(true);

        GameObject.Find("ER1C2_5").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickHorse()
    {
        HallBasicBG.SetActive(false);
        HallRightBG.SetActive(true);
        Hall_C.SetActive(false);

        GameObject.Find("ER1C2_3").GetComponent<ER1_InteractionController>().Text();
    }
    public void Horse_1()
    {
        HorseLeft.SetActive(true);
    }
    public void HorsetoMain()
    {
        HorseLeft.SetActive(false);
        HallRightBG.SetActive(false);
        HallBasicBG.SetActive(true);
        Hall_C.SetActive(true);
        Backbtn.SetActive(false);
    }
    public void Quest2Start()
    {
        Quest2.SetActive(true);
    }
    public void ClickKitchen()
    {
        isKitchen = true;
        ForKitchen = 0;
        Quest2.SetActive(false);
        KitchenL_C.SetActive(true);
        Arrows.SetActive(true);
        
    }
    public void ClickDrawer()
    {
        ER1_Manager.Instance.EnableHintButton(7);
        KitchenL_C.SetActive(false);
        Arrows.SetActive(false);
        Black.SetActive(true);
        DrawerQuiz.SetActive(true);
        isDrawer = true;

        if (isDrawerFirst)
        {
            Backbtn.SetActive(true);
        }
        else
        {
            GameObject.Find("ER1C2_6").GetComponent<ER1_InteractionController>().Text();
            isDrawerFirst = true;
        }
    }
    public void DrawerSuccess()
    {
        isDrawer = false;
        Backbtn.SetActive(false);
        ER1_Manager.Instance.DisableHintButton();

        GameObject.Find("ER1C2_7").GetComponent<ER1_InteractionController>().Text();
    }
    public void Drawer_1()
    {
        Black.SetActive(false);
        DrawerQuiz.SetActive(false);
        DrawerOpen.SetActive(true);
        Kettle.SetActive(true);
    }
    public void ClickKettle()
    {
        Kettle.SetActive(false);
        GetKettle = true;
        isKettle = true;
        KitchenL_C.SetActive(true);
        Destroy(Drawer_C);

        GameObject.Find("ER1C2_8").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickBox()
    {
        KitchenL_C.SetActive(false);
        Arrows.SetActive(false);
        Black.SetActive(true);
        BoxQuiz.SetActive(true);
        isBox = true;
        MainText.text = "Quiz 3";
        ER1_Manager.Instance.EnableHintButton(8);
        if (isBoxFirst)
        {
            Backbtn.SetActive(true);
        }
        else
        {
            isBoxFirst = true;
            progress++;
            GameObject.Find("ER1C2_9").GetComponent<ER1_InteractionController>().Text();
        }

    }
    public void BoxResult()
    {
        ER1_Manager.Instance.DisableHintButton();
        if (food_1.text == "2" && food_2.text == "6" && food_3.text == "3")
        {
            Black.SetActive(false);
            BoxQuiz.SetActive(false);
            BoxOpen.SetActive(true);
            BoxFood.SetActive(true);
            Backbtn.SetActive(false);
            isBox = false;
            MainText.text = "에르덴 여관, 부엌";

            GameObject.Find("ER1C2_10").GetComponent<ER1_InteractionController>().Text();
        }
        else
        {
            Black.SetActive(false);
            BoxQuiz.SetActive(false);
            Backbtn.SetActive(false);
            FailBox = true;

            GameObject.Find("ER1C2_11").GetComponent<ER1_InteractionController>().Text();
        }
    }
    public void BoxAgain()
    {
        ER1_Manager.Instance.EnableHintButton(8);
        FailBox = false;
        Black.SetActive(true);
        BoxQuiz.SetActive(true);
        Backbtn.SetActive(true);
        food_1.text = "";
        food_2.text = "";
        food_3.text = "";
    }
    public void ClickFood()
    {
        BoxFood.SetActive(false);
        GetFood = true;
        Arrows.SetActive(true);
        KitchenL_C.SetActive(true);
        Destroy(Box_C);
    }
    public void ClickPot()
    {
        Kitchen_RightBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -235);
        Kitchen_RightBG.transform.localScale = new Vector2(1.5f, 1.5f);
        isPot = true;
        if (WoodEnd)
        {
            Backbtn.SetActive(true);
            Arrows.SetActive(false);
        }
        else
        {
            GameObject.Find("ER1C2_12").GetComponent<ER1_InteractionController>().Text();
        }
    }
    public void ClickBackyard()
    {
        MainText.text = "에르덴 여관, 뒷마당";

        isKitchen = true;
        Quest2.SetActive(false);
        BackyardBG.SetActive(true);
        BackL_C.SetActive(true);
        Arrows.SetActive(true);
        Leftbtn.SetActive(true);
        ForKitchen = 2;
        BackConversation();
        if (isBackFirst)
        {
        }
        else
        {
            isBackFirst = true;
        }
    }
    public void BackConversation()
    {
        if (FireEnd)
        {
            Arrows.SetActive(true);
        }
        else
        {
            if (isWood)
            {
                Arrows.SetActive(false);
                GameObject.Find("ER1C2_13").GetComponent<ER1_InteractionController>().Text();
            }
            else
            {
                Arrows.SetActive(true);
            }
        }
    }
    public void BackC_1()
    {
        BackL_C.SetActive(false);
        BackyardBG.SetActive(false);
        Kitchen_RightBG.SetActive(true);
        Kit_Fire.SetActive(true);
        Kitchen_RightBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, 414);
        Kitchen_RightBG.transform.localScale = new Vector2(1.5f, 1.5f);
        isFire = true;
        FireEnd = true;

        GameObject.Find("ER1C2_15").GetComponent<ER1_InteractionController>().Text();
    }
    public void BackC_2()
    {
        BackL_C.SetActive(true);
        BackyardBG.SetActive(true);
        Arrows.SetActive(true);
        Kitchen_RightBG.SetActive(false);
    }
    public void ClickTree()
    {
        BackyardBG.transform.localScale = new Vector2(2, 2);
        BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-1328, -766);
        BackR_C.SetActive(false);
        Arrows.SetActive(false);

        GameObject.Find("ER1C2_16").GetComponent<ER1_InteractionController>().Text();
    }
    public void Tree_1()
    {
        Black.SetActive(true);
        TreeQuiz.SetActive(true);
        MainText.text = "Quiz 2";
        progress++;
        ER1_Manager.Instance.EnableHintButton(6);
        TreeEx.SetActive(true);
    }
    public void TreeSuccess()
    {
        ER1_Manager.Instance.DisableHintButton();
        BackyardBG.transform.localScale = new Vector2(1, 1);
        BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-412, 6);
        TreeQuiz.SetActive(false);
        Black.SetActive(false);
        Destroy(BackR_C);
        GetWoods = true;
        WoodEnd = true;

        GameObject.Find("ER1C2_17").GetComponent<ER1_InteractionController>().Text();
    }
    public void TreeFail()
    {
        ER1_Manager.Instance.DisableHintButton();
        TreeQuiz.SetActive(false);
        Black.SetActive(false);
        FailTree = true;

        GameObject.Find("ER1C2_18").GetComponent<ER1_InteractionController>().Text();
    }
    public void TreeAgain()
    {
        ER1_Manager.Instance.EnableHintButton(6);
        FailTree = false;
        TreeQuiz.SetActive(true);
        Black.SetActive(true);
        ER1C2_TreeManager.Instance.ResetGame();
    }
    public void ClickFish()
    {
        Arrows.SetActive(false);
        GameObject.Find("ER1C2_19").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickLake()
    {
        BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(23, 931);
        BackyardBG.transform.localScale = new Vector2(2, 2);
        Arrows.SetActive(false);
        BackL_C.SetActive(false);
        isLake = true;
        if (isKettle)
        {
            GetWater = true;
            Backbtn.SetActive(true);
        }
        else
        {
            GameObject.Find("ER1C2_21").GetComponent<ER1_InteractionController>().Text();
        }
    }
    public void LakeWater()
    {
        GetWater = false;
        GotWater = true;
        if (Backbtn.activeSelf)
        {
            Backbtn.SetActive(false);
        }
        Destroy(Lake_C);
        GameObject.Find("ER1C2_20").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickFlower()
    {
        Destroy(Flower1);
        Flower2image.SetActive(true);
        Arrows.SetActive(false);
        BackyardBG.transform.localScale = new Vector2(2, 2);
        BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(731, 958);
        FlowerEnd = true;

        GameObject.Find("ER1C2_22").GetComponent<ER1_InteractionController>().Text();
    }
    public void ClickAfterFlower()
    {
        Arrows.SetActive(false);
        BackyardBG.transform.localScale = new Vector2(2, 2);
        BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(731, 958);
        Backbtn.SetActive(true);
        isFlower = true;
        if (isKettle)
        {
            GetWater = true;
        }
        else
        {

        }
    }
    public void UseWoods()
    {
        Kit_Woods.SetActive(true);
        UseWater = true;
        UsedWoods = true;
        isWood = true;
        Arrows.SetActive(false);
        if (Backbtn.activeSelf)
        {
            Backbtn.SetActive(false);
        }

        GameObject.Find("ER1C2_23").GetComponent<ER1_InteractionController>().Text();
    }
    public void UseKettleWater()
    {
        UsedKettle = true;
        Kit_Smoke.SetActive(true);
        UseFood = true;
        if (Backbtn.activeSelf)
        {
            Backbtn.SetActive(false);
        }
    }
    public void UsePotFood()
    {
        isKitchen = false;
        Arrows.SetActive(false);
        UsedPotFood = true;
        if (Backbtn.activeSelf)
        {
            Backbtn.SetActive(false);
        }

        GameObject.Find("ER1C2_24").GetComponent<ER1_InteractionController>().Text();
    }

    public void AfterStew()
    {
        Black.SetActive(true);
        Big_Bow.SetActive(true);

        GameObject.Find("ER1C2_25").GetComponent<ER1_InteractionController>().Text();
    }
    public void AfterStew_1()
    {
        Black.SetActive(false);
        Big_Bow.SetActive(false);

        GameObject.Find("ER1C2_26").GetComponent<ER1_InteractionController>().Text();
    }
    public void ToForest()
    {
        MainText.text = "터이럼 마을 뒷산";

        Kitchen_RightBG.SetActive(false);
        Black.SetActive(false);
        Big_Bow.SetActive(false);
        MountainBG.SetActive(true);
        Arrows.SetActive(false);

        GameObject.Find("ER1C2_27").GetComponent<ER1_InteractionController>().Text();
    }
    public void Forest_1()
    {
        MountainBG.transform.localScale = new Vector3(2, 2, 2);

        GameObject.Find("ER1C2_28").GetComponent<ER1_InteractionController>().Text();
    }
    public void Forest_2()
    {
        MountainBG.transform.localScale = new Vector3(1, 1, 1);
        Quest3.SetActive(true);
    }
    public void UseBow()
    {
        MainText.text = "Quiz 4";
        progress = 4;

        Quest3.SetActive(false);
        Skill_1.SetActive(true);
    }
    public void UseSkill1()
    {
        Skill_1.SetActive(false);
        Black.SetActive(true);
        Skill1FX.SetActive(true);
        Icon.SetActive(false);
        Invoke("Skill1_1", 5.0f);
    }
    public void Skill1_1()
    {
        Icon.SetActive(true);
        Black.SetActive(false);
        MainText.text = "터이럼 마을 뒷산";

        GameObject.Find("ER1C2_29").GetComponent<ER1_InteractionController>().Text();
    }
    public void Quest4Start()
    {
        Quest4.SetActive(true);
    }
    public void Quest4Confirm()
    {
        progress = 5;
        MainText.text = "Quiz 5";
        ER1_Manager.Instance.EnableHintButton(9);
        Quest4.SetActive(false);
        FootLeftBG.SetActive(true);
        FootLeft_C.SetActive(true);
        Arrows.SetActive(true);
        Leftbtn.SetActive(false);
        Rightbtn.SetActive(true);
        isforest = true;
    }
    public void FootSuccess()
    {
        FootLeft_C.SetActive(false);
        Rightbtn.SetActive(false);
        FootLeftBG.transform.localScale = new Vector2(2, 2);
        FootLeftBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(142, -938);
        MainText.text = "터이럼 마을 뒷산";

        GameObject.Find("ER1C2_38").GetComponent<ER1_InteractionController>().Text();
    }
    public void FootSuccess_1()
    {
        ER1_Manager.Instance.DisableHintButton();
        GameObject.Find("ER1C2_31").GetComponent<ER1_InteractionController>().Text();
    }
    public void FootFail()
    {
        ER1_Manager.Instance.DisableHintButton();
        Arrows.SetActive(false);
        if (Q5select == 1)
        {
            FootLeftBG.transform.localScale = new Vector2(2, 2);
            FootLeftBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(381, 835);
        }
        else if (Q5select == 2)
        {
            FootRightBG.transform.localScale = new Vector2(2, 2);
            FootRightBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-114, -955);
        }
        else
        {
            FootRightBG.transform.localScale = new Vector2(2, 2);
            FootRightBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(-489, 596);
        }
        GameObject.Find("ER1C2_37").GetComponent<ER1_InteractionController>().Text();
    }
    public void FootFail_1()
    {
        ER1_Manager.Instance.DisableHintButton();
        Arrows.SetActive(true);
        if (Q5select == 1)
        {
            FootLeftBG.transform.localScale = new Vector2(1, 1);
            FootLeftBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        }
        else
        {
            FootRightBG.transform.localScale = new Vector2(1, 1);
            FootRightBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        }
        GameObject.Find("ER1C2_30").GetComponent<ER1_InteractionController>().Text();
    }
    public void BeforeOutro()
    {
        Black.SetActive(true);
        BlackWolf.SetActive(true);

        GameObject.Find("ER1C2_39").GetComponent<ER1_InteractionController>().Text();
    }
    public void Outro()
    {
        GameObject.Find("ER1C2_32").GetComponent<ER1_InteractionController>().Text();
    }
    public void Outro_1()
    {
        Icon.SetActive(false);
        Black.SetActive(false);
        SkillARFX.SetActive(true);
        Invoke("Outro_2", 4.5f);
    }
    public void Outro_2()
    {
        Icon.SetActive(true);
        BlackWolf.SetActive(false);
        DeadWolf.SetActive(true);

        GameObject.Find("ER1C2_33").GetComponent<ER1_InteractionController>().Text();
    }
    public void Outro_3()
    {
        BlackWolf.SetActive(true);
        DeadWolf.SetActive(false);

        GameObject.Find("ER1C2_34").GetComponent<ER1_InteractionController>().Text();
    }
    public void Outro_4()
    {
        BlackWolf.SetActive(false);

        GameObject.Find("ER1C2_35").GetComponent<ER1_InteractionController>().Text();
    }
    public void BackBtnTrue()
    {
        Backbtn.SetActive(true);
        if (isBox)
        {
            Box_Confirm.SetActive(true);
        }
    }
    public void ArrowsTrue()
    {
        Arrows.SetActive(true);
        if (FlowerEnd && ForKitchen == 2)
        {
            Flower2_C.SetActive(true);
            BackyardBG.transform.localScale = new Vector3(1, 1, 1);
            BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(412, 6);
        }
        if (isPot)
        {
            isPot = false;
            Kitchen_RightBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            Kitchen_RightBG.transform.localScale = new Vector2(1, 1);
        }
        if (isLake)
        {
            isLake = false;
            BackyardBG.transform.localScale = new Vector3(1, 1, 1);
            BackyardBG.GetComponent<RectTransform>().anchoredPosition = new Vector2(412, 6);
            BackL_C.SetActive(true);
        }
    }
}
