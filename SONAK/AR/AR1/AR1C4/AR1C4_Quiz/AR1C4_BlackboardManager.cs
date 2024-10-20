using UnityEngine;
using UnityEngine.UI;

public class AR1C4_BlackboardManager : MonoBehaviour
{
    public static AR1C4_BlackboardManager Instance;

    public GameObject Line1;
    public GameObject Line2;
    public GameObject Line3;
    public GameObject Line4;
    public GameObject Line5;
    public GameObject Line6;

    public GameObject Pic_1;
    public GameObject Pic_2;
    public GameObject Pic_3;
    public GameObject Pic_4;

    public bool IsSelected1 = false;
    public bool IsSelected2 = false;
    public bool IsSelected3 = false;
    public bool IsSelected4 = false;

    bool A1 = false;
    bool A2 = false;
    bool A3 = false;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    void Update()
    {
        if (A1 && A2 && A3)
        {
            A1 = false;
            A2 = false;
            A3 = false;
            AR1C4_MoveManager.Instance.BBCheck = true;
        }
    }

    public void MakeLines()
    {
        if (IsSelected1 && IsSelected2)
        {
            Invoke("After", 0.3f);
            if (Line1.activeSelf)
            {
                Line1.SetActive(false);
            }
            else
            {
                Line1.SetActive(true);
            }
        }
        else if (IsSelected1 && IsSelected3)
        {
            Invoke("After", 0.3f);
            if (Line3.activeSelf)
            {
                Line3.SetActive(false);
                A1 = false;
            }
            else
            {
                Line3.SetActive(true);
                A1 = true;
            }
        }
        else if (IsSelected1 && IsSelected4)
        {
            Invoke("After", 0.3f);
            if (Line2.activeSelf)
            {
                Line2.SetActive(false);
                A2 = false;
            }
            else
            {
                Line2.SetActive(true);
                A2 = true;
            }
        }
        else if (IsSelected2 && IsSelected3)
        {
            Invoke("After", 0.3f);
            if (Line4.activeSelf)
            {
                Line4.SetActive(false);
            }
            else
            {
                Line4.SetActive(true);
            }
        }
        else if (IsSelected2 && IsSelected4)
        {
            Invoke("After", 0.3f);
            if (Line5.activeSelf)
            {
                Line5.SetActive(false);
                A3 = false;
            }
            else
            {
                Line5.SetActive(true);
                A3 = true;
            }
        }
        else if (IsSelected3 && IsSelected4)
        {
            Invoke("After", 0.3f);
            if (Line6.activeSelf)
            {
                Line6.SetActive(false);
            }
            else
            {
                Line6.SetActive(true);
            }
        }
    }
    public void After()
    {
        if (IsSelected1 && IsSelected2)
        {
            IsSelected1 = false;
            IsSelected2 = false;
            ReturnImage(Pic_1);
            ReturnImage(Pic_2);
        }
        else if (IsSelected1 && IsSelected3)
        {
            IsSelected1 = false;
            IsSelected3 = false;
            ReturnImage(Pic_1);
            ReturnImage(Pic_3);
        }
        else if (IsSelected1 && IsSelected4)
        {
            IsSelected1 = false;
            IsSelected4 = false;
            ReturnImage(Pic_1);
            ReturnImage(Pic_4);
        }
        else if (IsSelected2 && IsSelected3)
        {
            IsSelected3 = false;
            IsSelected2 = false;
            ReturnImage(Pic_2);
            ReturnImage(Pic_3);
        }
        else if (IsSelected2 && IsSelected4)
        {
            IsSelected4 = false;
            IsSelected2 = false;
            ReturnImage(Pic_2);
            ReturnImage(Pic_4);
        }
        else if (IsSelected3 && IsSelected4)
        {
            IsSelected3 = false;
            IsSelected4 = false;
            ReturnImage(Pic_3);
            ReturnImage(Pic_4);
        }
    }
    public void ImageChange(GameObject go)
    {
        Color color = go.GetComponent<Image>().color;
        color = new Color32(150, 150, 150, 255);
        go.GetComponent<Image>().color = color;
    }
    public void ReturnImage(GameObject go)
    {
        Color color = go.GetComponent<Image>().color;
        color = new Color32(255, 255, 255, 255);
        go.GetComponent<Image>().color = color;
    }
    public void BBResult()
    {
        if (Line1.activeSelf && Line6.activeSelf && Line2.activeSelf)
        {
            AR1C0_MoveManager.Instance.BlackboardSuccess();
        }
        else
        {
            AR1C0_MoveManager.Instance.BlackboardFail();
        }
    }
}
