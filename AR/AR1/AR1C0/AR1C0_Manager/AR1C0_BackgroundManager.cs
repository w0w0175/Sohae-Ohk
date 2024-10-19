using UnityEngine;

public class AR1C0_BackgroundManager : MonoBehaviour
{
    public static AR1C0_BackgroundManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void Background_1()
    {
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(1056,0);
        transform.localScale = new Vector3(1, 1, 1);
    }
    public void Background_2()
    {
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-105,0);
        transform.localScale = new Vector3(1, 1, 1);
    }
    public void Background_3()
    {
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-1074,0);
        transform.localScale = new Vector3(1, 1, 1);
    }
    public void Typewriter()
    {
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-551,482);
        transform.localScale = new Vector2(1.5f, 1.5f);
    }
}
