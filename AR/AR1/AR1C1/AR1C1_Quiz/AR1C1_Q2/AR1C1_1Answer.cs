using UnityEngine;
using UnityEngine.EventSystems;

public class AR1C1_1Answer : MonoBehaviour, IDropHandler
{
    Vector2 cblue = new(-286,182);
    Vector2 cgreen = new(-293,177);
    Vector2 cred = new(-290,177);
    Vector2 cpurple = new(-293,177);
    Vector2 w1 = new(-290,177);
    Vector2 w2 = new(-291,179);
    Vector2 w3 = new(-293,181);
    Vector2 w4 = new(-280,170);
    Vector2 w5 = new(-290,177);
    Vector2 w6 = new(-295,158);

    public static bool ispurple = false;

    void Awake()
    {
        ispurple = false;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            AR1C1_MovingManager.Instance.checkbooks++;
            AR1_Block.UsingItem = false;
            gameObject.SetActive(false);
            if (AR1_Slot.Putnum == 1)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w1;
                Destroy(eventData.pointerDrag.GetComponent<AR1_Moving>());
            }
            if (AR1_Slot.Putnum == 2)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w2;
                Destroy(eventData.pointerDrag.GetComponent<AR1_Moving>());
            }
            if (AR1_Slot.Putnum == 3)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w3;
                Destroy(eventData.pointerDrag.GetComponent<AR1_Moving>());
            }
            if (AR1_Slot.Putnum == 4)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w4;
                Destroy(eventData.pointerDrag.GetComponent<AR1_Moving>());
            }
            if (AR1_Slot.Putnum == 5)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w5;
                Destroy(eventData.pointerDrag.GetComponent<AR1_Moving>());
            }
            if (AR1_Slot.Putnum == 6)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = w6;
                Destroy(eventData.pointerDrag.GetComponent<AR1_Moving>());
            }
            if (AR1_Slot.Putnum == 7)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = cblue;
                Destroy(eventData.pointerDrag.GetComponent<AR1_Moving>());
            }
            if (AR1_Slot.Putnum == 8)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = cgreen;
                Destroy(eventData.pointerDrag.GetComponent<AR1_Moving>());
            }
            if (AR1_Slot.Putnum == 9)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = cpurple;
                Destroy(eventData.pointerDrag.GetComponent<AR1_Moving>());
                ispurple = true;
            }
            if (AR1_Slot.Putnum == 10)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = cred;
                Destroy(eventData.pointerDrag.GetComponent<AR1_Moving>());
            }
            
        }
    }
}