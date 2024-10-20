using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR2C4_BackgroundManager : MonoBehaviour
{
    public static AR2C4_BackgroundManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
    public void ClickChandelier()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-303,-986);
    }
    public void ClickTrash()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(145,355);
    }
    public void ClickBookcase()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-446,-227);
    }
    public void ClicktoMain()
    {
        transform.localScale = new Vector3(1, 1, 1);
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,0);
        AR2C4_MoveManager.Instance.BookcaseOut();
    }
    public void ExpandBg()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
}
