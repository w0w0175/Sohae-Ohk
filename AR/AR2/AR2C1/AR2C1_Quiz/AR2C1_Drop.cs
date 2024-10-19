using UnityEngine;
using UnityEngine.EventSystems;

public class AR2C1_Drop : MonoBehaviour, IDropHandler
{
    
    Vector2 position = new(-860, 295);
    public static bool isusedkey = false;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().localPosition = position;
            isusedkey = true;
            AR2C1_MovingManager.Instance.BookCase_2();
            AR2_Close.UsingItem = false;
        }
    }
}