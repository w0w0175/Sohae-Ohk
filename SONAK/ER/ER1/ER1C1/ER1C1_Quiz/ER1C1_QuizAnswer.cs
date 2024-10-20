using UnityEngine;
using UnityEngine.EventSystems;

public class ER1C1_QuizAnswer : MonoBehaviour, IDropHandler
{
    Vector2 position;
    Vector2 sheeppos = new Vector2(-276, 121);
    Vector2 wolfpos = new Vector2(-280, 135);
    Vector2 grasspos = new Vector2(-275, 132);

    public GameObject erden;
    public GameObject sheep;
    public GameObject wolf;
    public GameObject grass;

    public static bool forfailwolfsheep = false;
    public static bool forfailsheepgrass = false;
    public static bool ww, ss, gg = false;

    void Awake()
    {
        position = new Vector2(-311, 213.87f);

        forfailwolfsheep = false;
        forfailsheepgrass = false;

        ww = false;
        ss = false;
        gg = false;
    }

    void Update()
    {
        if (ww == true && ss == true && gg == false && ER1C1_QuizStart.erdenatstart == 1)
        {
            forfailwolfsheep = true;
        }
        if (ww == false && ss == true && gg == true && ER1C1_QuizStart.erdenatstart == 1)
        {
            forfailsheepgrass = true;
        }
        if (ww == true && ss == false && gg == false && ER1C1_QuizStart.erdenatstart == 0)
        {
            forfailsheepgrass = true;
        }
        if (gg == true && ss == false && ww == false && ER1C1_QuizStart.erdenatstart == 0)
        {
            forfailwolfsheep = true;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            erden.GetComponent<RectTransform>().anchoredPosition = position;
            if (erden.GetComponent<RectTransform>().anchoredPosition != position)
            {
                erden.GetComponent<RectTransform>().anchoredPosition = position;
            }

            ER1C1_QuizStart.erdenatstart = 0;

            if (ER1C1_QuizDragAndDrop.sh == 2)
            {
                ER1C1_QuizDragAndDrop.sh = 3;

                sheep.GetComponent<RectTransform>().anchoredPosition = sheeppos;
                if (sheep.GetComponent<RectTransform>().anchoredPosition != new Vector2(-276, 121))
                {
                    sheep.GetComponent<RectTransform>().anchoredPosition = sheeppos;
                }

                ss = true;
            }

            if (ER1C1_QuizDragAndDrop.wo == 2)
            {
                ER1C1_QuizDragAndDrop.wo = 3;

                wolf.GetComponent<RectTransform>().anchoredPosition = wolfpos;
                if (wolf.GetComponent<RectTransform>().anchoredPosition != new Vector2(-280, 135))
                {
                    wolf.GetComponent<RectTransform>().anchoredPosition = wolfpos;
                }

                ww = true;
            }

            if (ER1C1_QuizDragAndDrop.gr == 2)
            {
                ER1C1_QuizDragAndDrop.gr = 3;

                grass.GetComponent<RectTransform>().anchoredPosition = grasspos;
                if (grass.GetComponent<RectTransform>().anchoredPosition != new Vector2(-275, 132))
                {
                    grass.GetComponent<RectTransform>().anchoredPosition = grasspos;
                }

                gg = true;
            }
        }
    }
}