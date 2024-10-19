using UnityEngine;
using UnityEngine.EventSystems;

public class AR1C3_Wmoving : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler//, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Canvas canvas;
    
    private RectTransform rect;
    private CanvasGroup canvasGroup;
    Vector2 pos = new Vector2(0,0);
    
    public static bool Wmove = false;
    //public static int IsWomanSuccess = 0;

    bool IsClick;
    bool ForR = false;
    bool ForB = false;
    float clicktime;
    float minTime = 3.0f;

    void OnEnable()
    {
        // IsWomanSuccess = 0;
        pos = gameObject.GetComponent<RectTransform>().position;
        Wmove = false;
        ForR= false;
        ForB= false;
        rect = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        if (canvas == null)
            canvas = GameObject.Find("AR1C3_Quiz5").GetComponent<Canvas>();
    }
    void Update()
    {
        // Debug.Log(Wmove);
        /*if (IsClick)
        {
            clicktime += Time.deltaTime;
        }
        else
        {
            clicktime = 0;
        }*/
        /*if (ForR)
        {
            ForR = false;
            if (gameObject.GetComponent<Rigidbody2D>() == null)
            {
                gameObject.AddComponent<Rigidbody2D>();
            }
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            RigidbodyConstraints2D rc2 = RigidbodyConstraints2D.FreezeRotation;
            gameObject.GetComponent<Rigidbody2D>().constraints = rc2;
        }
        else
        {
            if (gameObject.GetComponent<Rigidbody2D>() != null)
                Destroy(gameObject.GetComponent<Rigidbody2D>());
        }*/

        if (ForB)
        {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }
        else
        {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        //ForR = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rect.anchoredPosition += eventData.delta / canvas.scaleFactor;
        Wmove = true;
        ForB = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        ForB = false;
        if (!AR1C3_Fire.iswdrop || !AR1C3_Power.iswdrop)
        {
            gameObject.GetComponent<RectTransform>().position = pos;
        }
        else
        {

        }
    }
    /*public void OnPointerDown(PointerEventData eventData)
    {
        IsClick = true;
        if (clicktime >= minTime)
        {
            IsWomanSuccess = 1;
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (clicktime < minTime)
        {
            IsWomanSuccess = 2;
        }
    }*/
}

