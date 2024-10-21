//using UnityEditor.U2D.Path;
using UnityEngine;

public class AR1_OpenClose : MonoBehaviour
{
    public static AR1_OpenClose Instance;

    public GameObject Inventory;
    public GameObject Explain;
    public GameObject arrow;

    void Awake()
    {
        Inventory.SetActive(false);
        if (Instance == null)
            Instance = this;
    }

    public void ClicktoCloseEx() //설명창 끄기를 눌렀을 때 사용되는 함수
    {
        Explain.SetActive(false);
        SoundManager.instance.PlaySFX(Sfx.Click_Button);
        AR1_Slot.dia = false;           // AR1C3
        AR1_Slot.heart = false;         // AR1C3
        AR1_Slot.confidential = false;
        AR1_Slot.myspaper = false;
        AR1_Slot.ispaper = false;
        AR1_Slot.files = false;
        AR1_Slot.note = false;
        AR1_Slot.Putnum = 0;
        AR1_Slot.fordetail = 0;
    }
    public void ClicktoCloseInven() //인벤토리 끄기를 눌렀을 때 사용되는 함수
    {
        Inventory.SetActive(false);
        SoundManager.instance.PlaySFX(Sfx.Click_Button);
    }
    public void ClicktoOpen() //인벤토리를 클릭했을 때 사용되는 함수
    {
        Inventory.SetActive(true);
        Explain.SetActive(false);
        SoundManager.instance.PlaySFX(Sfx.Inventory_Open);
        if (arrow.activeSelf)
        {
            arrow.SetActive(false);
        }

    }
    public void ClicktoClosePaper()
    {
        Inventory.SetActive(false);
    }
}