using UnityEngine;
using UnityEngine.UI;

public class ER1C2_DrawerManager : MonoBehaviour
{
    public static ER1C2_DrawerManager Instance;

    public GameObject C1_1;
    public GameObject C1_2;
    public GameObject C1_3;
    public GameObject C1_4;
    public GameObject C1_5;
    public GameObject C1_6;
    public GameObject C1_7;
    public GameObject C1_8;
    public GameObject C2_1;
    public GameObject C2_2;
    public GameObject C2_3;
    public GameObject C2_4;
    public GameObject C2_5;
    public GameObject C2_6;
    public GameObject C2_7;
    public GameObject C2_8;
    public GameObject C3_1;
    public GameObject C3_2;
    public GameObject C3_3;
    public GameObject C3_4;
    public GameObject C3_5;
    public GameObject C3_6;
    public GameObject C3_7;
    public GameObject C3_8;
    public GameObject BG_1;
    public GameObject BG_2;
    public GameObject BG_3;

    public Sprite b1_1;
    public Sprite b1_2;
    public Sprite b1_3;
    public Sprite b1_4;
    public Sprite b1_5;
    public Sprite b1_6;
    public Sprite b1_7;
    public Sprite b1_8;
    public Sprite b2_1;
    public Sprite b2_2;
    public Sprite b2_3;
    public Sprite b2_4;
    public Sprite b2_5;
    public Sprite b2_6;
    public Sprite b2_7;
    public Sprite b2_8;
    public Sprite b3_1;
    public Sprite b3_2;
    public Sprite b3_3;
    public Sprite b3_4;
    public Sprite b3_5;
    public Sprite b3_6;
    public Sprite b3_7;
    public Sprite b3_8;

    int C1 = 0;
    int C2 = 0;
    int C3 = 0;

    bool Success = false;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    void Update()
    {
        if (C1_8.activeSelf && C2_5.activeSelf && C3_6.activeSelf)
        {
            Success = true;
        }
        if (Success)
        {
            Success = false;
            ER1C2_MoveManager.Instance.DrawerSuccess();
        }
        ForCircle();
    }
    public void Drawer1Click()
    {
        switch (C1)
        {
            case 0:
                C1_1.SetActive(false);
                C1_2.SetActive(true);
                C1 = 1;
                break;
            case 1:
                C1_2.SetActive(false);
                C1_3.SetActive(true);
                C1 = 2;
                break;
            case 2:
                C1_3.SetActive(false);
                C1_4.SetActive(true);
                C1 = 3;
                break;
            case 3:
                C1_4.SetActive(false);
                C1_5.SetActive(true);
                C1 = 4;
                break;
            case 4:
                C1_5.SetActive(false);
                C1_6.SetActive(true);
                C1 = 5;
                break;
            case 5:
                C1_6.SetActive(false);
                C1_7.SetActive(true);
                C1 = 6;
                break;
            case 6:
                C1_7.SetActive(false);
                C1_8.SetActive(true);
                C1 = 7;
                break;
            case 7:
                C1_8.SetActive(false);
                C1_1.SetActive(true);
                C1 = 0;
                break;
        }
    }
    public void Drawer2Click()
    {
        switch (C2)
        {
            case 0:
                C2_1.SetActive(false);
                C2_2.SetActive(true);
                C2 = 1;
                break;
            case 1:
                C2_2.SetActive(false);
                C2_3.SetActive(true);
                C2 = 2;
                break;
            case 2:
                C2_3.SetActive(false);
                C2_4.SetActive(true);
                C2 = 3;
                break;
            case 3:
                C2_4.SetActive(false);
                C2_5.SetActive(true);
                C2 = 4;
                break;
            case 4:
                C2_5.SetActive(false);
                C2_6.SetActive(true);
                C2 = 5;
                break;
            case 5:
                C2_6.SetActive(false);
                C2_7.SetActive(true);
                C2 = 6;
                break;
            case 6:
                C2_7.SetActive(false);
                C2_8.SetActive(true);
                C2 = 7;
                break;
            case 7:
                C2_8.SetActive(false);
                C2_1.SetActive(true);
                C2 = 0;
                break;
        }
    }
    public void Drawer3Click()
    {
        switch (C3)
        {
            case 0:
                C3_1.SetActive(false);
                C3_2.SetActive(true);
                C3 = 1;
                break;
            case 1:
                C3_2.SetActive(false);
                C3_3.SetActive(true);
                C3 = 2;
                break;
            case 2:
                C3_3.SetActive(false);
                C3_4.SetActive(true);
                C3 = 3;
                break;
            case 3:
                C3_4.SetActive(false);
                C3_5.SetActive(true);
                C3 = 4;
                break;
            case 4:
                C3_5.SetActive(false);
                C3_6.SetActive(true);
                C3 = 5;
                break;
            case 5:
                C3_6.SetActive(false);
                C3_7.SetActive(true);
                C3 = 6;
                break;
            case 6:
                C3_7.SetActive(false);
                C3_8.SetActive(true);
                C3 = 7;
                break;
            case 7:
                C3_8.SetActive(false);
                C3_1.SetActive(true);
                C3 = 0;
                break;
        }
    }
    public void ForCircle()
    {
        switch (C1)
        {
            case 0:
                BG_1.GetComponent<Image>().sprite = b1_1;
                break;
            case 1:
                BG_1.GetComponent<Image>().sprite = b1_2;
                break;
            case 2:
                BG_1.GetComponent<Image>().sprite = b1_3;
                break;
            case 3:
                BG_1.GetComponent<Image>().sprite = b1_4;
                break;
            case 4:
                BG_1.GetComponent<Image>().sprite = b1_5;
                break;
            case 5:
                BG_1.GetComponent<Image>().sprite = b1_6;
                break;
            case 6:
                BG_1.GetComponent<Image>().sprite = b1_7;
                break;
            case 7:
                BG_1.GetComponent<Image>().sprite = b1_8;
                break;
        }
        switch (C2)
        {
            case 0:
                BG_2.GetComponent<Image>().sprite = b2_1;
                break;
            case 1:
                BG_2.GetComponent<Image>().sprite = b2_2;
                break;
            case 2:
                BG_2.GetComponent<Image>().sprite = b2_3;
                break;
            case 3:
                BG_2.GetComponent<Image>().sprite = b2_4;
                break;
            case 4:
                BG_2.GetComponent<Image>().sprite = b2_5;
                break;
            case 5:
                BG_2.GetComponent<Image>().sprite = b2_6;
                break;
            case 6:
                BG_2.GetComponent<Image>().sprite = b2_7;
                break;
            case 7:
                BG_2.GetComponent<Image>().sprite = b2_8;
                break;
        }
        switch (C3)
        {
            case 0:
                BG_3.GetComponent<Image>().sprite = b3_1;
                break;
            case 1:
                BG_3.GetComponent<Image>().sprite = b3_2;
                break;
            case 2:
                BG_3.GetComponent<Image>().sprite = b3_3;
                break;
            case 3:
                BG_3.GetComponent<Image>().sprite = b3_4;
                break;
            case 4:
                BG_3.GetComponent<Image>().sprite = b3_5;
                break;
            case 5:
                BG_3.GetComponent<Image>().sprite = b3_6;
                break;
            case 6:
                BG_3.GetComponent<Image>().sprite = b3_7;
                break;
            case 7:
                BG_3.GetComponent<Image>().sprite = b3_8;
                break;
        }
    }
}
