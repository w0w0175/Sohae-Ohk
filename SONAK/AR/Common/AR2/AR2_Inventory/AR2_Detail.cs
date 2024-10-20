using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class AR2_Detail : MonoBehaviour
{
    public static AR2_Detail Instance;
    
    public GameObject I_forkey;
    public GameObject I_puthere;
    public GameObject Inventory;
    public GameObject paperfront;
    public GameObject paperback;
    public GameObject paperBtn;
    public GameObject planfront;
    public GameObject planback;
    public GameObject planBtns;
    public GameObject Diary;
    public GameObject OldQ5;
    public GameObject OldforGod;
    public GameObject ar2c1_close;
    public GameObject ar2c5_key;
    public GameObject ar2c5_answer;

    public bool Ispaper = false;
    public bool Isplan = false;
    public bool Isdiary = false;

    public static bool planBack = false; // AR2C2

    void OnEnable()
    {
        if(Instance == null)
            Instance = this;

        planBack = false;
    }
    public void ClicktoEButton()
    {
        AR2_Close.Instance.ClickInventoryClose();
        AR2_Close.UsingItem = true;
        if (AR2C1_MovingManager.Instance != null)
        {
            if (AR2C1_MovingManager.Instance.forkey)
            {
                AR2C1_MovingManager.Instance.forkey = false;
                ClicktoUseKey();
                AR2_Close.UsingItem = true;
            }
           
        }
        if (AR2_Slot.Openold)
        {
            AR2_Close.UsingItem = true;
            AR2_Slot.Openold = false;
            if (Isplan == false)
            {
                AR2C2_MoveManager.Instance.OldEtiquette();
                Isplan = true;
            }
            else
            {

            }
        }
        if (AR2_Slot.Ispaper == true)
        {
            AR2_Close.UsingItem = true;
            AR2_Slot.Ispaper = false;
            if (AR2C2_MoveManager.Instance.toQ3 == true)
            {
                AR2C2_MoveManager.Instance.toQ3 = false;
                AR2C2_MoveManager.Instance.Quiz3();
                GameObject.Find("PaperIntend").SetActive(false);
            }
            else
            {
                ClicktoPaper();
            }
        }
        if (AR2_Slot.Isplan == true)
        {
            AR2_Close.UsingItem = true;
            AR2_Slot.Isplan = false;
            ClicktoPlan();
        }
        if (AR2_Slot.oldq5)
        {
            AR2_Close.UsingItem = true;
            AR2_Slot.oldq5 = false;
            ClickOld_Q5();
        }
        if (AR2_Slot.IsGod)
        {
            AR2_Close.UsingItem = true;
            AR2_Slot.IsGod = false;
            ClickoldforGod();
        }
        if (AR2C5_MoveManager.Instance != null)
        {
            if (AR2_Slot.IsScissor)
            {
                AR2_Close.UsingItem = false;
                AR2C5_MoveManager.Instance.IsCut = false;
                AR2_Slot.IsScissor = false;
                AR2C5_MoveManager.Instance.UsingScissor();
                AR2C5_MoveManager.Instance.UsedScissor = true;
            }
            else if (AR2_Slot.IsKey)
            {
                AR2_Close.UsingItem = true;
                AR2C5_MoveManager.Instance.IsKey = false;
                AR2_Slot.IsKey = false;
                ClicktoUseC5Key();
            }
            else if (AR2_Slot.IsCurtain)
            {
                AR2_Close.UsingItem = false;
                AR2C5_MoveManager.Instance.IsCurtain = false;
                AR2_Slot.IsCurtain = false;
                AR2C5_MoveManager.Instance.Window_Tie();
            }
            else if (AR2_Slot.IsC5Old)
            {
                //AR2_Close.UsingItem = false;
                AR2_Slot.IsC5Old = false;
                AR2C5_MoveManager.Instance.OldQuiz();
            }
        }
    }
    public void ClicktoUseKey()
    {
        I_forkey.SetActive(true);
        I_puthere.SetActive(true);
        I_forkey.transform.localPosition = new UnityEngine.Vector2(0, -400);
    }
    public void ClicktoUseC5Key()
    {
        ar2c5_answer.SetActive(true);
        ar2c5_key.SetActive(true);
        AR2C5_MoveManager.Instance.BackBtn.SetActive(false);
        ar2c5_key.GetComponent<RectTransform>().anchoredPosition = new UnityEngine.Vector2(206, -300);
    }
    public void CloseC5Key()
    {
        ar2c5_answer.SetActive(false);
        ar2c5_key.SetActive(false);
    }

    public void ClicktoPaper()
    {
        Ispaper = true;
        paperfront.SetActive(true); 
        if (AR2C2_MoveManager.Instance.Quiz3end == false)
        {
            ar2c1_close.SetActive(true); 
        }
        else
        {
            paperBtn.SetActive(true); 
        }    
    }
    public void ToPaperBack()
    {
        paperfront.SetActive(false);
        paperback.SetActive(true);
    }
    public void ToPaperFront()
    {
        paperfront.SetActive(true);
        paperback.SetActive(false);
    }
    public void ClosePaper()
    {
        AR2_Close.UsingItem = false;
        Ispaper = false;
        paperfront.SetActive(false);
        paperBtn.SetActive(false);
        paperback.SetActive(false);
    }
    public void ClicktoPlan()
    {
        planfront.SetActive(true);
        planBtns.SetActive(true);
    }
    public void PlanBack()
    {
        planfront.SetActive(false);
        planback.SetActive(true);
        planBack = true;
    }
    public void PlanFront()
    {
        planfront.SetActive(true);
        planback.SetActive(false);
        planBack = false;
    }
    public void ClosePlan()
    {
        AR2_Close.UsingItem = false;
        planBtns.SetActive(false);
        planback.SetActive(false);
        planfront.SetActive(false);
    }
    public void ClickOld_Q5()
    {
        OldQ5.SetActive(true);
    }
    public void Old_Q5_Close()
    {
        AR2_Close.UsingItem = false;
        OldQ5.SetActive(false);
    }
    public void ClickoldforGod()
    {
        OldforGod.SetActive(true);
    }
    public void CloseoldforGod()
    {
        AR2_Close.UsingItem = false;
        OldforGod.SetActive(false);
    }
}
