using UnityEngine;

public class ER1C1_BackgroundManager : MonoBehaviour
{
    public static ER1C1_BackgroundManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    public void ClickGreenSheep()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(325, -863);
    }
    public void ClickGreenSheep_1()
    {
        ExpandBgMore();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(390, -1282);
    }
    public void ClickPinkSheep()
    {
        ExpandBgMore();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-1049, -1851);
    }
    public void ClickPinkBird()
    {
        ExpandBgMore();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-623, -696);
    }
    public void ClickRock()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-75, 141);
    }

    public void ClickMain()
    {
        transform.localScale = new Vector3(1, 1, 1);
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
    }
    public void ExpandBg()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
    public void ExpandBgMore()
    {
        transform.localScale = new Vector3(3, 3, 3);
    }
}
