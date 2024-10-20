
using UnityEngine;
using UnityEngine.EventSystems;


public class AR1C3_Answer3 : MonoBehaviour, IDropHandler
{
    Vector2 position1 = new(455, 173);
    Vector2 position2 = new(496, 186);

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (AR1_Detail.Instance.whatkey == 100)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = position2;
                AR1C3_MoveManager.Instance.forQ4 = 2;
                //Invoke("Return0", 0.5f);
            }
            else if (AR1_Detail.Instance.whatkey == 200)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().localPosition = position1;
                AR1C3_MoveManager.Instance.forQ4 = 1;
                // Invoke("Return0", 0.5f);

            }

        }
    }

    public void ReturnO()
    {
        AR1_Detail.Instance.whatkey = 0;
    }
}
