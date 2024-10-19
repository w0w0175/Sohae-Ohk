using UnityEngine;
using UnityEngine.EventSystems;

public class AR1C1_3Answer : MonoBehaviour, IDropHandler
{
    Vector2 cblue = new(12, 182);
    Vector2 cgreen = new(6,177);
    Vector2 cred = new(13,177);
    Vector2 cpurple = new(16,177);
    Vector2 w1 = new(15,177);
    Vector2 w2 = new(18,179);
    Vector2 w3 = new(22,181);
    Vector2 w4 = new(28,170);
    Vector2 w5 = new(19,177);
    Vector2 w6 = new(15,158);

    public static bool isblue = false;

    void Awake()
    {
        isblue = false;
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
                isblue = true;
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
            }
        }
    }
}