using UnityEngine;

public class ER1C2_DoorManager : MonoBehaviour
{
    public static ER1C2_DoorManager Instance;
    
    public GameObject D1_1;
    public GameObject D1_2;
    public GameObject D1_3;
    public GameObject D1_4;
    public GameObject D2_1;
    public GameObject D2_2;
    public GameObject D2_3;
    public GameObject D2_4;
    public GameObject D3_1;
    public GameObject D3_2;
    public GameObject D3_3;
    public GameObject D3_4;
    public GameObject D4_1;
    public GameObject D4_2;
    public GameObject D4_3;
    public GameObject D4_4;
    
    int Door_1 = 0;
    int Door_2 = 0;
    int Door_3 = 0;
    int Door_4 = 0;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    void Update()
    {
        if (D1_3.activeSelf && D2_3.activeSelf && D3_2.activeSelf && D4_2.activeSelf)
        {
            ER1C2_MoveManager.Instance.DoorSuccess();
        }
    }
    public void Door1Click()
    {
        switch (Door_1)
        {
            case 0:
                D1_2.SetActive(true);
                D1_1.SetActive(false);
                Door_1 = 1;
                break;
            case 1:
                D1_3.SetActive(true);
                D1_2.SetActive(false);
                Door_1 = 2;
                break;
            case 2:
                D1_4.SetActive(true);
                D1_3.SetActive(false);
                Door_1 = 3;
                break;
            case 3:
                D1_1.SetActive(true);
                D1_4.SetActive(false);
                Door_1 = 0;
                break;
        }
    }
    public void Door2Click()
    {
        switch (Door_2)
        {
            case 0:
                D2_2.SetActive(true);
                D2_1.SetActive(false);
                Door_2 = 1;
                break;
            case 1:
                D2_3.SetActive(true);
                D2_2.SetActive(false);
                Door_2 = 2;
                break;
            case 2:
                D2_4.SetActive(true);
                D2_3.SetActive(false);
                Door_2 = 3;
                break;
            case 3:
                D2_1.SetActive(true);
                D2_4.SetActive(false);
                Door_2 = 0;
                break;
        }
    }
    public void Door3Click()
    {
        switch (Door_3)
        {
            case 0:
                D3_2.SetActive(true);
                D3_1.SetActive(false);
                Door_3 = 1;
                break;
            case 1:
                D3_3.SetActive(true);
                D3_2.SetActive(false);
                Door_3 = 2;
                break;
            case 2:
                D3_4.SetActive(true);
                D3_3.SetActive(false);
                Door_3 = 3;
                break;
            case 3:
                D3_1.SetActive(true);
                D3_4.SetActive(false);
                Door_3 = 0;
                break;
        }
    }
    public void Door4Click()
    {
        switch (Door_4)
        {
            case 0:
                D4_2.SetActive(true);
                D4_1.SetActive(false);
                Door_4 = 1;
                break;
            case 1:
                D4_3.SetActive(true);
                D4_2.SetActive(false);
                Door_4 = 2;
                break;
            case 2:
                D4_4.SetActive(true);
                D4_3.SetActive(false);
                Door_4 = 3;
                break;
            case 3:
                D4_1.SetActive(true);
                D4_4.SetActive(false);
                Door_4 = 0;
                break;
        }
    }
}
