using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR1C1_ForBackGround2 : MonoBehaviour
{
    public static AR1C1_ForBackGround2 Instance;
    public bool forQ3paper = false;
    public bool forQ4Confidential = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    
    public void ClickPaper()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(2.18f, 2.29f, 0f);
        forQ3paper = true;
    }

    public void ClickMap()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(1.78f, -1.82f, 0f);

    }
    public void ClickCalendar()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(-2.69f, -1.59f, 0f);

    }
    public void ClickConfidential()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(-2.48f, 3.16f, 0f);
        forQ4Confidential = true;

    }
    public void ClicktoMain()
    {
        Minimizebg(); 
        gameObject.GetComponent<RectTransform>().position = new Vector3(0,0,0);

    }
    public void ExpandBg()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }
    public void Minimizebg()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
}
