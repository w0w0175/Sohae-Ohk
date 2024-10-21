using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AR1_Inventory : MonoBehaviour
{
    public List<AR1_Item> items;
    public static AR1_Inventory Instance;

    public AR1_Item Heartkey;
    public AR1_Item Diakey;
    public AR1_Item Keys;
    public AR1_Item Paper;
    public AR1_Item Key;
    public AR1_Item CorrectGreen;
    public AR1_Item CorrectRed;
    public AR1_Item CorrectBlue;
    public AR1_Item CorrectPurple;
    public AR1_Item Wrong1;
    public AR1_Item Wrong2;
    public AR1_Item Wrong3;
    public AR1_Item Wrong4;
    public AR1_Item Wrong5;
    public AR1_Item Wrong6;
    public AR1_Item Confidential;
    public AR1_Item Q3Paper;
    public AR1_Item Files;
    public AR1_Item Note;

    AR1_Item iitem;

    [SerializeField] private Transform slotParent;
    [SerializeField] private AR1_Slot[] slots;
    void Start()
    {
        if (Instance == null)
            Instance = this;
         StartCoroutine("StartInven");
    }
    IEnumerator StartInven() //처음 시작할 때 기본적으로 있어야 하는 아이템 추가 함수
    {
        switch (GameManager.instance.ChapterNum)
        {
             case 1:
                 items.Clear();
                 yield return null;
                 break;
             case 2:
                 items.Clear();
                 yield return null;
                 Additem(Key);
                 yield return null;
                 Additem(Paper);
                 break;
             case 4:
                 items.Clear();
                 yield return null;
                 break;
             case 5:
                 items.Clear();
                 yield return null;
                 Additem(Files);
                 break;
        }
    }

    void Update()
    {
        FreshSlot();
        if (GameManager.instance.ChapterNum == 1)
        {
            if (AR1C0_MoveManager.Instance != null)
            {
                AR1C0_Items();
            }
        }
        else if (GameManager.instance.ChapterNum == 2)
        {
            if (AR1C1_MovingManager.Instance != null)
            {
                AR1C1_Items();
            }
        }
        else if (GameManager.instance.ChapterNum == 4)
        {
            if (AR1C3_MoveManager.Instance != null)
            {
                AR1C3_Items();
            }
        }
    }

    private void OnValidate()
    {
        slots = slotParent.GetComponentsInChildren<AR1_Slot>();
    }
    public void FreshSlot() //슬롯을 새로고침 하는 함수
    {
        int i = 0;

        for (; i < items.Count && i < slots.Length; i++)
        {
            slots[i].item = items[i];
        }

        for (; i < slots.Length; i++)
        {
            slots[i].item = null;
        }
        items = items.Distinct().ToList();
    }

    public void Additem(AR1_Item _item) //아이템을 슬롯에 추가하는 함수
    {
        if (items.Count < slots.Length)
        {
            items.Add(_item);
            FreshSlot();
        }
        else
        {
            print("슬롯이 가득 차 있습니다.");
        }
    }
    public void AR1C0_Items() //챕터 0일 경우 아이템 추가
    {
        if (AR1C0_MoveManager.Instance.GetNote)
        {
            AR1C0_MoveManager.Instance.GetNote = false;
            Additem(Note);
        }
    }
    public void AR1C1_Items() //챕터 1일 경우 아이템 추가
    {
        if (AR1C1_MovingManager.Instance.isCON == true)
        {
            AR1C1_MovingManager.Instance.isCON = false;
            Additem(Confidential);
        }
        if (AR1C1_MovingManager.Instance.isPaper == true)
        {
            AR1C1_MovingManager.Instance.isPaper = false;
            Additem(Q3Paper);
        }
        if (AR1C1_MovingManager.Instance.cg == true)
        {
            AR1C1_MovingManager.Instance.cg = false;
            Additem(CorrectGreen);
        }
        if (AR1C1_MovingManager.Instance.cr == true)
        {
            AR1C1_MovingManager.Instance.cr = false;
            Additem(CorrectRed);
        }
        if (AR1C1_MovingManager.Instance.cb == true)
        {
            AR1C1_MovingManager.Instance.cb = false;
            Additem(CorrectBlue);
        }
        if (AR1C1_MovingManager.Instance.cp == true)
        {
            AR1C1_MovingManager.Instance.cp = false;
            Additem(CorrectPurple);
        }
        if (AR1C1_MovingManager.Instance.w1 == true)
        {
            AR1C1_MovingManager.Instance.w1 = false;
            Additem(Wrong1);
        }
        if (AR1C1_MovingManager.Instance.w2 == true)
        {
            AR1C1_MovingManager.Instance.w2 = false;
            Additem(Wrong2);
        }
        if (AR1C1_MovingManager.Instance.w3 == true)
        {
            AR1C1_MovingManager.Instance.w3 = false;
            Additem(Wrong3);
        }
        if (AR1C1_MovingManager.Instance.w4 == true)
        {
            AR1C1_MovingManager.Instance.w4 = false;
            Additem(Wrong4);
        }
        if (AR1C1_MovingManager.Instance.w5 == true)
        {
            AR1C1_MovingManager.Instance.w5 = false;
            Additem(Wrong5);
        }
        if (AR1C1_MovingManager.Instance.w6 == true)
        {
            AR1C1_MovingManager.Instance.w6 = false;
            Additem(Wrong6);
        }
        if (AR1C1_MovingManager.Instance.isReturn == true)
        {
            AR1C1_MovingManager.Instance.isReturn = false;
            ReturnItems();
        }
        if (AR1_Detail.cb == true)
        {
            RemoveBlue();
        }
        if (AR1_Detail.cg == true)
        {
            RemoveGreen();
        }
        if (AR1_Detail.cr == true)
        {
            RemoveRed();
        }
        if (AR1_Detail.cp == true)
        {
            RemovePurple();
        }
        if (AR1_Detail.w11 == true)
        {
            RemoveW1();
        }
        if (AR1_Detail.w22 == true)
        {
            RemoveW2();
        }
        if (AR1_Detail.w33 == true)
        {
            RemoveW3();
        }
        if (AR1_Detail.w44 == true)
        {
            RemoveW4();
        }
        if (AR1_Detail.w55 == true)
        {
            RemoveW5();
        }
        if (AR1_Detail.w66 == true)
        {
            RemoveW6();
        }
        if (AR1C1_MovingManager.Instance.forkey == true)
        {
            RemoveBlue();
            RemoveGreen();
            RemoveRed();
            RemovePurple();

        }
        if (AR1C1_KeyAnswer.Instance != null)
        {
            if (AR1C1_KeyAnswer.Instance.isKeyTouched || AR1C1_MovingManager.Instance.removekey)
            {
                AR1C1_KeyAnswer.Instance.isKeyTouched = false;
                RemoveC1Key();
            }
        }
        
        if (AR1C1_MovingManager.Instance.NextSecretroom)
        {
            RemoveC1Paper();
            RemoveW1();
            RemoveW2();
            RemoveW3();
            RemoveW4();
            RemoveW5();
            RemoveW6();
        }
    }
    public void AR1C3_Items()
    {
        if (AR1C3_MoveManager.Instance.forkey == true)
        {
            AR1C3_MoveManager.Instance.forkey = false;
            Additem(Keys);
        }
        if (AR1_Detail.Instance != null)
        {
            if (AR1_Detail.Instance.partkey == true)
            {
                AR1_Detail.Instance.partkey = false;
                Additem(Heartkey);
                Additem(Diakey);
                RemoveKeys();
            }
        }
        if (AR1C3_MoveManager.Instance.RemoveKeys)
        {
            RemoveDiakey();
            RemoveHeartkey();
        }
    }

    #region REMOVE
    public void RemoveDiakey()
    {
        iitem = items.Find(x => x.itemName == "AR1C3_DiaKey");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveHeartkey()
    {
        iitem = items.Find(x => x.itemName == "AR1C3_HeartKey");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveKeys()
    {
        iitem = items.Find(x => x.itemName == "AR1C3_Keys");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveBlue()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_CorrectBlue");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemovePurple()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_CorrectPurple");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveRed()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_CorrectRed");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveGreen()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_CorrectGreen");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveW1()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_Wrong1");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveW2()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_Wrong2");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveW3()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_Wrong3");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveW4()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_Wrong4");
        items.Remove(iitem);
        FreshSlot();

    }
    public void RemoveW5()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_Wrong5");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveW6()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_Wrong6");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveC1Key()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_KEY");
        items.Remove(iitem);
        FreshSlot();
    }
    public void RemoveC1Paper()
    {
        iitem = items.Find(x => x.itemName == "AR1C1_PAPERS");
        items.Remove(iitem);
        FreshSlot();
    }
    #endregion
    public void ReturnItems()
    {
        if (AR1_Detail.cb == true)
        {
            AR1_Detail.cb = false;
            if (items.Contains(CorrectBlue))
            {

            }
            else
            {
                Additem(CorrectBlue);
            }

        }
        if (AR1_Detail.cr == true)
        {
            AR1_Detail.cr = false;
            if (items.Contains(CorrectRed))
            {

            }
            else
            {
                Additem(CorrectRed);
            }
        }
        if (AR1_Detail.cp == true)
        {
            AR1_Detail.cp = false;
            if (items.Contains(CorrectPurple))
            {

            }
            else
            {
                Additem(CorrectPurple);
            }
        }
        if (AR1_Detail.cg == true)
        {
            AR1_Detail.cg = false;
            if (items.Contains(CorrectGreen))
            {

            }
            else
            {
                Additem(CorrectGreen);
            }
        }
        if (AR1_Detail.w11 == true)
        {
            AR1_Detail.w11 = false;
            if (items.Contains(Wrong1))
            {

            }
            else
            {
                Additem(Wrong1);
            }
        }
        if (AR1_Detail.w22 == true)
        {
            AR1_Detail.w22 = false;
            if (items.Contains(Wrong2))
            {

            }
            else
            {
                Additem(Wrong2);
            }
        }
        if (AR1_Detail.w33 == true)
        {
            AR1_Detail.w33 = false;
            if (items.Contains(Wrong3))
            {

            }
            else
            {
                Additem(Wrong3);
            }
        }
        if (AR1_Detail.w44 == true)
        {
            AR1_Detail.w44 = false;
            if (items.Contains(Wrong4))
            {

            }
            else
            {
                Additem(Wrong4);
            }
        }
        if (AR1_Detail.w55 == true)
        {
            AR1_Detail.w55 = false;
            if (items.Contains(Wrong5))
            {

            }
            else
            {
                Additem(Wrong5);
            }
        }
        if (AR1_Detail.w66 == true)
        {
            AR1_Detail.w66 = false;
            if (items.Contains(Wrong6))
            {

            }
            else
            {
                Additem(Wrong6);
            }
        }
    }
}