using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ER1C1_QuizDragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerClickHandler
{
    [SerializeField] private Canvas canvas;

    public static ER1C1_QuizDragAndDrop Instance;
    private RectTransform rect;
    private CanvasGroup canvasgroup;

    public GameObject sheep;
    public GameObject wolf;
    public GameObject grass;
    public GameObject erden;

    public Sprite erdensmile;

    Vector2 sheepposition;
    Vector2 wolfposition;
    Vector2 grassposition;
    Vector2 erdenposition;

    public bool ismoving = false;


    public static int sh, wo, gr, failgame = 0;
    int shs, wos, grs, success, wolfsheep, sheepgrass = 0;

    Vector2 erdenshpos;
    Vector2 erdenshpos2;
    Vector2 erdenwopos;
    Vector2 erdenwopos2;
    Vector2 erdengrpos;
    Vector2 erdengrpos2;

    Vector2 shplus = new Vector2(35, -92);
    Vector2 woplus = new Vector2(31, -78);
    Vector2 grplus = new Vector2(36, -81);

    bool ForExplain = false;
    bool GameOverCheck = false;

    void Awake()
    {
        sheepposition = sheep.GetComponent<RectTransform>().anchoredPosition;
        wolfposition = wolf.GetComponent<RectTransform>().anchoredPosition;
        grassposition = grass.GetComponent<RectTransform>().anchoredPosition;
        erdenposition = erden.GetComponent<RectTransform>().anchoredPosition;

        if (Instance == null)
            Instance = this;

        rect = erden.GetComponent<RectTransform>();
        canvasgroup = erden.GetComponent<CanvasGroup>();
    }
    void OnDisable()
    {
        ResetGame();
    }

    void Update()
    {
        if (ismoving)
        {
            sheep.GetComponent<Image>().raycastTarget = false;
            wolf.GetComponent<Image>().raycastTarget = false;
            grass.GetComponent<Image>().raycastTarget = false;
        }
        else
        {
            sheep.GetComponent<Image>().raycastTarget = true;
            wolf.GetComponent<Image>().raycastTarget = true;
            grass.GetComponent<Image>().raycastTarget = true;
        }

        if (sh == 1)
        {
           // erdenshpos = sheep.transform.position - erden.transform.position;
            erdenshpos = sheep.GetComponent<RectTransform>().anchoredPosition - erden.GetComponent<RectTransform>().anchoredPosition;

            sh = 2;
        }

        if (sh == 3)
        {
            erdenshpos2 = sheep.GetComponent<RectTransform>().anchoredPosition - erden.GetComponent<RectTransform>().anchoredPosition;

            sh = 4;
        }

        if (ismoving == true && sh == 2)
        {
            Vector2 shpos = new Vector2(erden.GetComponent<RectTransform>().anchoredPosition.x, erden.GetComponent<RectTransform>().anchoredPosition.y);

            sheep.GetComponent<RectTransform>().anchoredPosition = shpos + erdenshpos + shplus;
        }

        if (ismoving == true && sh == 4)
        {
            Vector2 shpos = new Vector2(erden.GetComponent<RectTransform>().anchoredPosition.x, erden.GetComponent<RectTransform>().anchoredPosition.y);

            sheep.GetComponent<RectTransform>().anchoredPosition = shpos + erdenshpos + shplus;
        }

        if (wo == 1)
        {
            erdenwopos = wolf.GetComponent<RectTransform>().anchoredPosition - erden.GetComponent<RectTransform>().anchoredPosition;

            wo = 2;
        }

        if (wo == 3)
        {
            erdenwopos2 = wolf.GetComponent<RectTransform>().anchoredPosition - erden.GetComponent<RectTransform>().anchoredPosition;

            wo = 4;
        }

        if (ismoving == true && wo == 2)
        {
            Vector2 shpos = new Vector2(erden.GetComponent<RectTransform>().anchoredPosition.x, erden.GetComponent<RectTransform>().anchoredPosition.y);

            wolf.GetComponent<RectTransform>().anchoredPosition = shpos + erdenwopos + woplus;
        }

        if (ismoving == true && wo == 4)
        {
            Vector2 shpos = new Vector2(erden.GetComponent<RectTransform>().anchoredPosition.x, erden.GetComponent<RectTransform>().anchoredPosition.y);

            wolf.GetComponent<RectTransform>().anchoredPosition = shpos + erdenwopos2 + woplus;
        }

        if (gr == 1)
        {
            erdengrpos = grass.GetComponent<RectTransform>().anchoredPosition - erden.GetComponent<RectTransform>().anchoredPosition;

            gr = 2;
        }

        if (gr == 3)
        {
            erdengrpos2 = grass.GetComponent<RectTransform>().anchoredPosition - erden.GetComponent<RectTransform>().anchoredPosition;

            gr = 4;
        }

        if (ismoving == true && gr == 2)
        {
            Vector2 shpos = new Vector2(erden.GetComponent<RectTransform>().anchoredPosition.x, erden.GetComponent<RectTransform>().anchoredPosition.y);

            grass.GetComponent<RectTransform>().anchoredPosition = shpos + erdengrpos + grplus;
        }

        if (ismoving == true && gr == 4)
        {
            Vector2 shpos = new Vector2(erden.GetComponent<RectTransform>().anchoredPosition.x, erden.GetComponent<RectTransform>().anchoredPosition.y);

            grass.GetComponent<RectTransform>().anchoredPosition = shpos + erdengrpos2 + grplus;
        }

        if (GameOverCheck == false)
        {
            if ((gr == 5 || gr == 4) && (wo == 5 || wo == 4) && (sh == 5 || sh == 4))
            {
                GameOverCheck = true;
                success = 1;
                GameOver();
                erden.GetComponent<Image>().sprite = erdensmile;

                //Invoke(nameof(GameOver), 1.0f);
            }
            else if (ER1C1_QuizAnswer.forfailwolfsheep == true)
            {
                GameOverCheck = true;
                wolfsheep = 1;
                GameOver();
                //Invoke(nameof(GameOver), 0.5f);

                Debug.Log("늑대가 양 쳐먹었네");
            }
            else if (ER1C1_QuizAnswer.forfailsheepgrass == true)
            {
                GameOverCheck = true;
                sheepgrass = 1;
                GameOver();
                //Invoke(nameof(GameOver), 0.5f);

                Debug.Log("양이 풀을 쳐먹었네");
            }
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        else
        {
            if (gameObject.name == "Cliff_Wolf")
            {
                OnClicktoSelectwolf();
            }
            else if (gameObject.name == "Cliff_Sheep")
            {
                OnClicktoSelectsheep();
            }
            else if (gameObject.name == "Cliff_Grass")
            {
                OnClicktoSelectgrass();
            }
        }
    }
    public void ResetGame()
    {
        ismoving = false;
        ForExplain = false;
        GameOverCheck = false;

        sh = 0;
        wo = 0;
        gr = 0;

        failgame = 0;

        shs = 0;
        wos = 0;
        grs = 0;

        success = 0;

        wolfsheep = 0;
        sheepgrass = 0;

        wolf.GetComponent<RectTransform>().anchoredPosition = wolfposition;
        sheep.GetComponent<RectTransform>().anchoredPosition = sheepposition;
        grass.GetComponent<RectTransform>().anchoredPosition = grassposition;
        erden.GetComponent<RectTransform>().anchoredPosition = erdenposition;
    }

    public void GameOver()
    {
        if (success == 1)
        {
            ER1C1_MovingManager.Instance.CliffSuccess();
        }
        else if (wolfsheep == 1)
        {
            wolfsheep = 0;
            ER1C1_MovingManager.Instance.CliffFail_WS();
        }
        else if (sheepgrass == 1)
        {
            sheepgrass = 0;
            ER1C1_MovingManager.Instance.CliffFail_SG();
        }
    }

    public void OnClicktoSelectsheep()
    {
        ForExplain = true;
        if (wo == 0 && sh == 0 && gr == 0)
        {
            if (ER1C1_QuizStart.erdenatstart == 0)
            {

            }
            else
            {
                sheep.GetComponent<RectTransform>().anchoredPosition = new Vector2(330, 147);
                sh = 1;
            }
        }
        else if (sh == 2)
        {
            sheep.GetComponent<RectTransform>().anchoredPosition = sheepposition;

            sh = 0;
        }
        else if (sh == 4)
        {
            sheep.GetComponent<RectTransform>().anchoredPosition = new Vector2(-271, 29);

            sh = 5;
            shs = 1;
        }
        else if (sh == 5)
        {
            if (ER1C1_QuizStart.erdenatstart == 1 || wo == 4 || gr == 4)
            {

            }
            else
            {
                sheep.transform.localPosition = new Vector2(-276, 121);

                sh = 4;
                shs = 0;
            }
        }
        else if (ER1C1_QuizStart.erdenatstart == 1 && (((wos == 1||wo==5) && (grs == 1||gr==5)) || ((wos == 1 || wo == 5) && gr == 0) || ((grs == 1 || gr == 5) && wo == 0) || (wo == 0 && gr == 0)))
        {
            sheep.GetComponent<RectTransform>().anchoredPosition = new Vector2(330, 147);

            sh = 1;
        }
    }

    public void OnClicktoSelectwolf()
    {
        ForExplain = true;
        if (wo == 0 && sh == 0 && gr == 0)
        {
            if (ER1C1_QuizStart.erdenatstart == 0)
            {

            }
            else
            {
                wolf.GetComponent<RectTransform>().anchoredPosition = new Vector2(336, 140);
                wo = 1;
            }

        }
        else if (wo == 2)
        {
            wolf.GetComponent<RectTransform>().anchoredPosition = wolfposition;

            wo = 0;
        }
        else if (wo == 4)
        {
            wolf.GetComponent<RectTransform>().anchoredPosition = new Vector2(-379, 43);

            wo = 5;
            wos = 1;
        }
        else if (wo == 5)
        {
            if (ER1C1_QuizStart.erdenatstart == 1 || sh == 4 || gr == 4)
            {

            }
            else
            {
                wolf.GetComponent<RectTransform>().anchoredPosition = new Vector2(-280, 135);

                wo = 4;
                wos = 0;
            }
        }
        else if (ER1C1_QuizStart.erdenatstart == 1 && (((grs == 1 || gr == 5) && (shs == 1||sh==5)) || ((shs == 1 || sh == 5) && gr == 0) || (gr == 0 && sh == 0) || ((grs == 1 || gr == 5) && sh == 0)))
        {
            wolf.GetComponent<RectTransform>().anchoredPosition = new Vector2(336, 140);

            wo = 1;
        }
        else
        {
        }
    }

    public void OnClicktoSelectgrass()
    {
        ForExplain = true;
        if (wo == 0 && sh == 0 && gr == 0)
        {
            if (ER1C1_QuizStart.erdenatstart == 0)
            {

            }
            else
            {
                grass.GetComponent<RectTransform>().anchoredPosition = new Vector2(324, 137);
                gr = 1;
            }
        }
        else if (gr == 2)
        {
            grass.GetComponent<RectTransform>().anchoredPosition = grassposition;

            gr = 0;
        }
        else if (gr == 4)
        {
            grass.GetComponent<RectTransform>().anchoredPosition = new Vector2(-478, 40);

            gr = 5;
            grs = 1;
        }
        else if (gr == 5)
        {
            if (ER1C1_QuizStart.erdenatstart == 1 || wo == 4 || sh == 4)
            {

            }
            else
            {
                grass.GetComponent<RectTransform>().anchoredPosition = new Vector2(-275, 132);

                gr = 4;
                grs = 0;
            }
        }
        else if (ER1C1_QuizStart.erdenatstart == 1 && (((wos == 1 || wo == 5) && (shs == 1 || sh == 5)) || ((wos == 1 || wo == 5) && sh == 0) || ((shs == 1 || sh == 5) && wo == 0) || (wo == 0 && sh == 0)))
        {
            grass.GetComponent<RectTransform>().anchoredPosition = new Vector2(324, 137);

            gr = 1;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasgroup.blocksRaycasts = false;
        ismoving = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rect.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasgroup.blocksRaycasts = true;
        Invoke(nameof(iismv), 0.1f);
    }

    public void iismv()
    {
        ismoving = false;
    }
}