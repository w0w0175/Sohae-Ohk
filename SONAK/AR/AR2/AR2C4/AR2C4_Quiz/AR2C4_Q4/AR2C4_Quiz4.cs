using UnityEngine;
using UnityEngine.EventSystems;

public class AR2C4_Quiz4 : MonoBehaviour//, IPointerDownHandler
{
    public static bool Q4;
    public RectTransform pos;
    void OnEnable()
    {
        if (pos.anchoredPosition.y != 0)
        {
            Vector2 position = new Vector2(0,0);
            pos.anchoredPosition = position;
        }
    }
    /*public void OnPointerDown(PointerEventData eventData)
    {
        if (pos.anchoredPosition.y > 37.5)
        {
            pos.anchoredPosition = new Vector2(0, 0);
        }
        else if (pos.anchoredPosition.y < 115 && pos.anchoredPosition.y > 37.5)
        {
            pos.anchoredPosition = new Vector2(0, 80);
        }
        else if (pos.anchoredPosition.y > 115 && pos.anchoredPosition.y < 210)
        {
            pos.anchoredPosition = new Vector2(0, 162);
        }
        else if (pos.anchoredPosition.y < 290 && pos.anchoredPosition.y > 210)
        {
            pos.anchoredPosition = new Vector2(0, 243);
        }
        else if (pos.anchoredPosition.y < 375 && pos.anchoredPosition.y > 290)
        {
            pos.anchoredPosition = new Vector2(0, 335);
        }
        else if (pos.anchoredPosition.y < 460 && pos.anchoredPosition.y > 375)
        {
            pos.anchoredPosition = new Vector2(0, 420);
        }
        else if (pos.anchoredPosition.y < 550 && pos.anchoredPosition.y > 460)
        {
            pos.anchoredPosition = new Vector2(0, 506);
        }
        else if (pos.anchoredPosition.y < 635 && pos.anchoredPosition.y > 550)
        {
            pos.anchoredPosition = new Vector2(0, 596);
        }
        else if (pos.anchoredPosition.y < 715 && pos.anchoredPosition.y > 635)
        {
            pos.anchoredPosition = new Vector2(0, 673);
        }
        else if (pos.anchoredPosition.y < 805 && pos.anchoredPosition.y > 715)
        {
            pos.anchoredPosition = new Vector2(0, 761);
        }
        else if (pos.anchoredPosition.y < 895 && pos.anchoredPosition.y > 805)
        {
            pos.anchoredPosition = new Vector2(0, 846);
        }
        else if (pos.anchoredPosition.y < 980 && pos.anchoredPosition.y > 895)
        {
            pos.anchoredPosition = new Vector2(0, 932);
        }
        else if (pos.anchoredPosition.y < 1070 && pos.anchoredPosition.y > 980)
        {
            pos.anchoredPosition = new Vector2(0, 1015);
        }
        else if (pos.anchoredPosition.y < 1150 && pos.anchoredPosition.y > 1070)
        {
            pos.anchoredPosition = new Vector2(0, 1105);
        }
        else if (pos.anchoredPosition.y < 1235 && pos.anchoredPosition.y > 1150)
        {
            pos.anchoredPosition = new Vector2(0, 1189);
        }
        else if (pos.anchoredPosition.y < 1315 && pos.anchoredPosition.y > 1235)
        {
            pos.anchoredPosition = new Vector2(0, 1260);
        }
        else if (pos.anchoredPosition.y < 1405 && pos.anchoredPosition.y > 1315)
        {
            pos.anchoredPosition = new Vector2(0, 1365);
        }
        else if (pos.anchoredPosition.y < 1490 && pos.anchoredPosition.y > 1405)
        {
            pos.anchoredPosition = new Vector2(0, 1448);
        }
        else if (pos.anchoredPosition.y < 1570 && pos.anchoredPosition.y > 1490)
        {
            pos.anchoredPosition = new Vector2(0, 1533);
        }
        else if (pos.anchoredPosition.y > 1570)
        {
            pos.anchoredPosition = new Vector2(0, 1617);
        }
    }*/

    public void Q4Result()
    {
       if(pos.anchoredPosition.y > 1598.7)
        {
            Q4 = true;
        }
       else
        {
            Q4 = false;
        }
    }
}