using System;
using UnityEngine;
using UnityEngine.UI;

public class AR2_Close : MonoBehaviour
{
    public static AR2_Close Instance;

    public GameObject I_E;
    public GameObject Inventory;
    public GameObject redarrow;
    public GameObject Block_common;
    public GameObject Block_common2;
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow_old;
    public GameObject Block_1;
    public GameObject ar2c1_adopt;
    public GameObject ar2c1_diary;
    public GameObject ar2c2_paper;
    public GameObject ar2c1_close;
    public GameObject MainBlock;

    public static bool UsingItem = false;
    public static bool forarrow_old = false;

    void Awake()
    {
        Inventory.SetActive(false);
        if (Instance == null)
            Instance = this;
    }
    void Update()
    {
        if (UsingItem)
        {
            BlockInventory();
        }
        else
        {
            ReturnInventory();
        }
    }
    public void BlockInventory()
    {
        Color color = gameObject.GetComponent<Image>().color;
        color = new Color32(100, 100, 100, 255);
        gameObject.GetComponent<Image>().color = color;
        MainBlock.SetActive(true);
        ;
    }
    public void ReturnInventory()
    {
        Color color = gameObject.GetComponent<Image>().color;
        color = new Color32(255, 255, 255, 255);
        gameObject.GetComponent<Image>().color = color;
        MainBlock.SetActive(false);
    }
    public void ClickExplainClose()
    {
        SoundManager.instance.PlaySFX(Sfx.Click_Button);

        I_E.SetActive(false);
        AR2_Slot.Ispaper = false;
        AR2_Slot.Isplan = false;
        AR2_Slot.Openold = false;
        AR2_Slot.IsC5Old = false;
        AR2_Slot.IsCurtain = false;
        AR2_Slot.IsKey = false;
        AR2_Slot.IsScissor = false;
        AR2_Slot.oldq5 = false;
        AR2_Slot.IsGod = false;
        AR2_Slot.Isdiary = false;
    }

    public void ClickInventoryClose()
    {
        SoundManager.instance.PlaySFX(Sfx.Click_Button);

        Inventory.SetActive(false);
    }

    public void ClickInventoryOpen()
    {
        SoundManager.instance.PlaySFX(Sfx.Inventory_Open);

        Inventory.SetActive(true);
        I_E.SetActive(false);
        if (redarrow.activeSelf == true)
        {
            redarrow.SetActive(false);
            if (AR2C2_MoveManager.Instance.toQ3)
            {
                arrow1.SetActive(true);
                Block_1.SetActive(true);
                Block_common.SetActive(true);
                Block_common2.SetActive(false);
            }
        }
        if (arrow2.activeSelf == true)
        {
            arrow2.SetActive(false);
            arrow_old.SetActive(true);
            forarrow_old = true;
        }
    }
    public void CloseContent()
    {
        ar2c2_paper.SetActive(false);
        ar2c1_close.SetActive(false);
    }
}