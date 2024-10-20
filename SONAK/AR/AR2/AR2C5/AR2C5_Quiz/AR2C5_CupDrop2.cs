using UnityEngine;
using UnityEngine.EventSystems;

public class AR2C5_CupDrop2 : MonoBehaviour, IDropHandler
{
    bool isdrop = false;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (isdrop)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = eventData.pointerDrag.GetComponent<AR2C5_Cups>().pos;
            }
            else
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = new Vector2(46, -262);
                isdrop = true;
                if (eventData.pointerDrag.name == "Cups_9" || eventData.pointerDrag.name == "Cups_11" || eventData.pointerDrag.name == "Cups_13")
                {
                    AR2C5_MoveManager.Instance.CupDrop2 = true;
                }
            }
        }
    }
    void Update()
    {
        if (AR2C5_MoveManager.Instance.FailCup)
        {
            isdrop = false;
            AR2C5_MoveManager.Instance.CupDrop2 = false;
        }
        else
        {

        }
    }
}
