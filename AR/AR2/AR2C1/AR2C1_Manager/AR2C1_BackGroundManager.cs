using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR2C1_BackGroundManager : MonoBehaviour
{
    public static AR2C1_BackGroundManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    public void ClickUnderCarpet()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(0.958f, 5.796875f, 0f);
    }
    public void ClickLetter()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(2.74f, 4.88f, 0f);
    }
    public void ClickWindow()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(-2.42f, -3.58f, 0f);
    }
    public void ClickBox()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(2.625f, -4.84f, 0f);
    }
    public void ClickBookCase()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(2.74f, -0.89f, 0f);
    }
    public void ClicktoMain()
    {
        transform.localScale = new Vector3(1, 1, 1);
        gameObject.GetComponent<RectTransform>().position = new Vector3(0f,0f, 0f);
    }
    public void ExpandBg()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
}