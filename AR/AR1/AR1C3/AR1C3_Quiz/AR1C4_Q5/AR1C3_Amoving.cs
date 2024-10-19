using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//using static UnityEditor.PlayerSettings;

public class AR1C3_Amoving : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    private RectTransform rect;
    private CanvasGroup canvasGroup;
    Vector2 pos = new Vector2(0, 0);

    public static bool Amove = false;
    bool ForR;
    bool ForB = false;

    void OnEnable()
    {
        pos = gameObject.GetComponent<RectTransform>().position;
        rect = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        Amove = false;
        ForR = false;
        ForB = false;
        if (canvas == null)
            canvas = GameObject.Find("AR1C3_Quiz5").GetComponent<Canvas>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        //ForR = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rect.anchoredPosition += eventData.delta / canvas.scaleFactor;
        Amove = true;
        //ForB = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        //ForB = false;
        if (!AR1C3_Fire.isadrop || !AR1C3_Power.isadrop)
        {
            gameObject.GetComponent<RectTransform>().position = pos;
        }
        else
        {

        }
    }
}
