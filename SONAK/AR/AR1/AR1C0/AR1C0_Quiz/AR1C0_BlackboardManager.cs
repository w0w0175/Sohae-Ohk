using UnityEngine;
using UnityEngine.UI;

public class AR1C0_BlackboardManager : MonoBehaviour
{
    public static AR1C0_BlackboardManager Instance;

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

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    public void MakeLines()
    {
        Invoke("After", 0.3f);
        if (IsSelected1 && IsSelected2)
        {
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
            if (Line4.activeSelf)
            {
                Line4.SetActive(false);
            }
            else
            {
                Line4.SetActive(true);
            }
        }
        else if (IsSelected1 && IsSelected4)
        {
            if (Line3.activeSelf)
            {
                Line3.SetActive(false);
            }
            else
            {
                Line3.SetActive(true);
            }
        }
        else if (IsSelected2 && IsSelected3)
        {
            if (Line6.activeSelf)
            {
                Line6.SetActive(false);
            }
            else
            {
                Line6.SetActive(true);
            }
        }
        else if (IsSelected2 && IsSelected4)
        {
            if (Line5.activeSelf)
            {
                Line5.SetActive(false);
            }
            else
            {
                Line5.SetActive(true);
            }
        }
        else if (IsSelected3 && IsSelected4)
        {
            if (Line2.activeSelf)
            {
                Line2.SetActive(false);
            }
            else
            {
                Line2.SetActive(true);
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
    public void PlayAgain()
    {
        Line1.SetActive(false);
        Line2.SetActive(false);
        Line3.SetActive(false);
        Line4.SetActive(false);
        Line5.SetActive(false);
        Line6.SetActive(false);

        ReturnImage(Pic_1);
        ReturnImage(Pic_2);
        ReturnImage(Pic_3);
        ReturnImage(Pic_4);
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
