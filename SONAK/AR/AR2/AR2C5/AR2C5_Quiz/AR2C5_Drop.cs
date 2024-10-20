using UnityEngine;
using UnityEngine.EventSystems;

public class AR2C5_Drop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = new Vector2(-202,-232);
            AR2C5_MoveManager.Instance.UnderBedKey();
            AR2_Close.UsingItem = false;
        }
    }
}
