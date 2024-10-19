using UnityEngine;
using UnityEngine.EventSystems;

public class AR1C1_4Answer : MonoBehaviour, IDropHandler
{
    Vector2 cblue = new(201, 182);
    Vector2 cgreen = new(198,177);
    Vector2 cred = new(209,177);
    Vector2 cpurple = new(208,177);
    Vector2 w1 = new(208,177);
    Vector2 w2 = new(209,179);
    Vector2 w3 = new(215,181);
    Vector2 w4 = new(221,170);
    Vector2 w5 = new(212,177);
    Vector2 w6 = new(210,158);

    public static bool isred = false;

    void Awake()
    {
        isred = false;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            AR1C1_MovingManager.Instance.checkbooks++;
            gameObject.SetActive(false);
            AR1_Block.UsingItem = false;
            Destroy(eventData.pointerDrag.GetComponent<AR1_Moving>());
            if (AR1_Slot.Putnum == 1)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w1;
            }
            if (AR1_Slot.Putnum == 2)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w2;
            }
            if (AR1_Slot.Putnum == 3)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w3;
            }
            if (AR1_Slot.Putnum == 4)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w4;
            }
            if (AR1_Slot.Putnum == 5)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w5;
            }
            if (AR1_Slot.Putnum == 6)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w6;
            }
            if (AR1_Slot.Putnum == 7)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = cblue;
            }
            if (AR1_Slot.Putnum == 8)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = cgreen;
            }
            if (AR1_Slot.Putnum == 9)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = cpurple;
            }
            if (AR1_Slot.Putnum == 10)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = cred;
                isred = true;
            }
        }

    }
}