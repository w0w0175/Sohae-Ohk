using UnityEngine;
using UnityEngine.EventSystems;

public class ER1C1_QuizStart : MonoBehaviour, IDropHandler
{
    Vector3 position;
    Vector3 pos2;
    RectTransform rect;
    public GameObject erden;

    public GameObject sheep;
    public GameObject wolf;
    public GameObject grass;

    public static int erdenatstart = 1;

    void Awake()
    {
        rect = erden.GetComponent<RectTransform>();
        position = rect.anchoredPosition;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            erden.GetComponent<RectTransform>().anchoredPosition = pos2;
            if (pos2 != position)
            {
                rect.anchoredPosition = position;
            }

            erdenatstart = 1;

            if (ER1C1_QuizDragAndDrop.sh == 4)
            {
                ER1C1_QuizDragAndDrop.sh = 2;

                sheep.GetComponent<RectTransform>().anchoredPosition = new Vector2(330, 147);
                if (sheep.GetComponent<RectTransform>().anchoredPosition != new Vector2(330, 147))
                {
                    sheep.GetComponent<RectTransform>().anchoredPosition = new Vector2(330, 147);
                }

                ER1C1_QuizAnswer.ss = false;
            }
            else if (ER1C1_QuizDragAndDrop.sh == 0)
            {
                sheep.GetComponent<RectTransform>().anchoredPosition = new Vector2(245, 37);
            }

            if (ER1C1_QuizDragAndDrop.wo == 4)
            {
                ER1C1_QuizDragAndDrop.wo = 2;

                wolf.GetComponent<RectTransform>().anchoredPosition = new Vector2(336, 140);
                if (wolf.GetComponent<RectTransform>().anchoredPosition != new Vector2(336, 140))
                {
                    wolf.GetComponent<RectTransform>().anchoredPosition = new Vector2(336, 140);
                }

                ER1C1_QuizAnswer.ww = false;
            }

            if (ER1C1_QuizDragAndDrop.gr == 4)
            {
                ER1C1_QuizDragAndDrop.gr = 2;

                grass.GetComponent<RectTransform>().anchoredPosition = new Vector2(324, 137);
                if (grass.GetComponent<RectTransform>().anchoredPosition != new Vector2(324, 137))
                {
                    grass.GetComponent<RectTransform>().anchoredPosition = new Vector2(324, 137);
                }

                ER1C1_QuizAnswer.gg = false;
            }
        }
        else
        {
            erdenatstart = 0;
        }
    }
}