using UnityEngine;

public class ER1C1_BackgroundManager2 : MonoBehaviour
{
    public static ER1C1_BackgroundManager2 Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    public void ClickHoney()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(493, -758);
    }
    public void ClickLake()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(532, 536);
    }
    public void ClickCave()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-523, -220);
    }
    public void ClickPicture()
    {
        ExpandBgMore();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-510, -440);
    }
    public void ClickInside()
    {
        ExpandBgMore();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-1062, -357);
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
