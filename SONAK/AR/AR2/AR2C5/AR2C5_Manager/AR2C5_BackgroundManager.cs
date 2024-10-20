using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR2C5_BackgroundManager : MonoBehaviour
{
    public static AR2C5_BackgroundManager Instance;

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
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-421, -892);
    }
    public void ClickCurtain()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(290, -216);
    }
    public void ClickWindow()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(676, -283);
    }
    public void ClickUnderBox()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(672, 980);
    }
    public void ClickDrawer()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-474, 322);
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
}
