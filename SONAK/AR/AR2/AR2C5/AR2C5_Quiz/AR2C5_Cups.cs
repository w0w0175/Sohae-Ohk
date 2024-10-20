using UnityEngine;
using UnityEngine.EventSystems;

public class AR2C5_Cups : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    private RectTransform rect;
    private CanvasGroup canvasGroup;
    public Vector2 pos;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }
        pos = gameObject.GetComponent<RectTransform>().anchoredPosition;
    }
    void Update()
    {
        if (AR2C5_MoveManager.Instance.FailCup)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = pos;
        }
        else
        {

        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rect.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, 0.5f, LayerMask.GetMask("Answer"));
        if (hit == null)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = pos;
        }
        canvasGroup.blocksRaycasts = true;
    }
}
