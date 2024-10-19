using UnityEngine;
using UnityEngine.EventSystems;

public class AR1C1_2Answer : MonoBehaviour, IDropHandler
{
    Vector2 cblue = new(-109, 182);
    Vector2 cgreen = new(-107, 177);
    Vector2 cred = new(-102,177);
    Vector2 cpurple = new(-100,177);
    Vector2 w1 = new(-98,177);
    Vector2 w2 = new(-96,179);
    Vector2 w3 = new(-93,181);
    Vector2 w4 = new(-86,170);
    Vector2 w5 = new(-96,177);
    Vector2 w6 = new(95,158);

    public static bool isgreen = false;
   
    void Awake()
    {
        isgreen = false;
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
                isgreen = true;
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
    public void BlockAgain()
    {
        gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }
}