using UnityEngine;
using UnityEngine.EventSystems;

public class ER1_Answerplace : MonoBehaviour, IDropHandler
{
    Vector2 position = new(36, 333);

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().localPosition = position;
            ER1C1_MovingManager.Instance.isusedladder = true;
            ER1C1_MovingManager.Instance.UsingLadder = false;
        }
    }
}