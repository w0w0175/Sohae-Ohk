using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR1C1_ForBackground : MonoBehaviour
{
    public static AR1C1_ForBackground Instance;

    public bool formoving = false;

    public int formainbg = 0;
    public int forclick = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        formainbg = 0;
    }

    public void Clickbookcase()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(-2f, -0.8f, 0f);
        forclick = 2;
        formainbg = 4;
        formoving = false;
        Invoke("ForMoving", 0.001f);

        if (!AR1C1_MovingManager.Instance.isQ1solved)
        {
            AR1C1_MovingManager.Instance.bClick();
        }
        else
        {
            AR1C1_MovingManager.Instance.bookcaseClicks();
        }
    }
    public void ClickEmptyCase()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(2.2f, -0.8f, 0f);
        forclick = 1;
        formainbg = 5;
        formoving = false;
        Invoke("ForMoving", 0.001f);

        if (!AR1C1_MovingManager.Instance.isQ1solved)
        {
            AR1C1_MovingManager.Instance.aClick();
        }
        else
        {
            AR1C1_MovingManager.Instance.emptyClicks();
        }
    }
    public void ClickLeft()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(4.7f, -0.8f,0f);
        formainbg = 3;
        Invoke("ForMoving", 0.001f);
    }
    public void ClickRight()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(-4.7f, -0.8f, 0f);
        formainbg = 6;
        formoving = false;
        Invoke("ForMoving", 0.001f);
    }
    public void ClickDesk()
    {
        ExpandBg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(-0.06f, 5.2f, 0f);
        formainbg = 2;
    }
    public void ClicktoMain()
    {
        Minimizebg();
        gameObject.GetComponent<RectTransform>().position = new Vector3(0.004f, -0.005f, 0f);
        formainbg = 1;
    }
    public void ExpandBg()
    {
        transform.localScale = new Vector3(2,2,2);
    }
    public void Minimizebg()
    {
        transform.localScale = new Vector3(1,1,1);
    }
    public void ForMoving()
    {
        formoving = true;
    }
}
