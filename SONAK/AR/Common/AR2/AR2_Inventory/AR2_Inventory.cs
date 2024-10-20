using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AR2_Inventory : MonoBehaviour
{
    public List<AR2_Item> items;

    public AR2_Item Clover;
    public AR2_Item Heart;
    public AR2_Item Spade;
    public AR2_Item Dia;
    public AR2_Item Adopt;
    public AR2_Item Key;
    public AR2_Item Diary;
    public AR2_Item AR2C1_Old;
    public AR2_Item AR2C2_Etiq;
    public AR2_Item AR2C4_Quette;
    public AR2_Item AR2C5_OEQ;
    public AR2_Item Gun;
    public AR2_Item Plan;
    public AR2_Item Paper;
    public AR2_Item Spoon;
    public AR2_Item Invation;
    public AR2_Item Envelope;
    public AR2_Item Scissors;
    public AR2_Item AR2C5_key;
    public AR2_Item Curtain;

    [SerializeField]
    private Transform slotParent;
    [SerializeField]
    private AR2_Slot[] slots;

    private void OnValidate()
    {
        slots = slotParent.GetComponentsInChildren<AR2_Slot>();
    }

    void Start()
    {
         StartCoroutine("StartInven");
    }
    void Update()
    {
        FreshSlot();
        if (GameManager.instance.ChapterNum == 1)
        {
            if (AR2C1_MovingManager.Instance != null)
            {
                if (AR2C1_MovingManager.Instance.ar2c1)
                {
                    AR2C1_Items();
                }
            }

        }
        else if (GameManager.instance.ChapterNum == 2)
        {
            if (AR2C2_MoveManager.Instance != null)
            {
                if (AR2C2_MoveManager.Instance.ar2c2)
                {
                    AR2C2_Items();
                }
            }

        }
        else if (GameManager.instance.ChapterNum == 4)
        {
            if (AR2C4_MoveManager.Instance != null)
            {
                if (AR2C4_MoveManager.Instance.ar2c4)
                {
                    AR2C4_Items();
                }
            }

        }
        else if (GameManager.instance.ChapterNum == 5)
        {
            if (AR2C5_MoveManager.Instance != null)
            {
                if (AR2C5_MoveManager.Instance.ar2c5)
                {
                    AR2C5_Items();
                }
            }
        }
    }
    IEnumerator StartInven()
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
                AddItem(AR2C2_Etiq);
                break;
            case 4:
                items.Clear();
                yield return null;
                AddItem(AR2C4_Quette);
                if (AR2_Manager.AR2C1_Gun == false)
                {
                    AddItem(Clover);
                    AddItem(Heart);
                    AddItem(Dia);
                    AddItem(Spade);
                }
                else
                {
                    AddItem(Gun);
                }
                break;
            case 5:
                items.Clear();
                yield return null;
                AddItem(AR2C5_OEQ);
                break;

        }
    }
    public void FreshSlot()
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
    public void AddItem(AR2_Item _item)
    {
        if (items.Count < slots.Length)
        {
            items.Add(_item);
            FreshSlot();
        }
        else
        {

        }
    }
    public void AR2C1_Items()
    {
        if (AR2C1_MovingManager.Instance.isheart == true)
        {
            AR2C1_MovingManager.Instance.isheart = false;
            AddItem(Heart);
        }
        if (AR2C1_MovingManager.Instance.isdia == true)
        {
            AR2C1_MovingManager.Instance.isdia = false;
            AddItem(Dia);
        }
        if (AR2C1_MovingManager.Instance.isspade == true)
        {
            AR2C1_MovingManager.Instance.isspade = false;
            AddItem(Spade);
        }
        if (AR2C1_MovingManager.Instance.isclover == true)
        {
            AR2C1_MovingManager.Instance.isclover = false;
            AddItem(Clover);
        }
        if (AR2C1_MovingManager.Instance.isadopt == true)
        {
            AR2C1_MovingManager.Instance.isadopt = false;
            AddItem(Adopt);
        }
        if (AR2C1_MovingManager.Instance.iskey == true)
        {
            AR2C1_MovingManager.Instance.iskey = false;
            AddItem(Key);
        }
        if (AR2C1_MovingManager.Instance.isold == true)
        {
            AR2C1_MovingManager.Instance.isold = false;
            AddItem(AR2C1_Old);
        }
        if (AR2C1_MovingManager.Instance.isgun == true)
        {
            AR2C1_MovingManager.Instance.isgun = false;
            AddItem(Gun);
            items.Remove(Clover);
            items.Remove(Heart);
            items.Remove(Spade);
            items.Remove(Dia);
        }
        if (AR2C1_MovingManager.Instance.isdiary == true)
        {
            AR2C1_MovingManager.Instance.isdiary = false;
            AddItem(Diary);
        }
        if (AR2C1_Drop.isusedkey == true)
        {
            AR2C1_Drop.isusedkey = false;
            items.Remove(Key);
        }
    }
    public void AR2C2_Items()
    {
        if (AR2_Detail.Instance != null || AR2C2_MoveManager.Instance.IsPlanadded)
        {
            if (AR2_Detail.Instance.Isplan || AR2C2_MoveManager.Instance.IsPlanadded)
            {
                AR2_Detail.Instance.Isplan = false;
                AR2C2_MoveManager.Instance.IsPlanadded = false;
                AR2C2_MoveManager.Instance.IsPlan = true;
                AddItem(Plan);
            }
        }
        if (AR2C2_MoveManager.Instance.IsPaper == true)
        {
            AR2C2_MoveManager.Instance.IsPaper = false;
            AddItem(Paper);
        }
        if (AR2C2_MoveManager.Instance.IsSpoon == true)
        {
            AR2C2_MoveManager.Instance.IsSpoon = false;
            AddItem(Spoon);
        }
    }
    public void AR2C4_Items()
    {
        if (AR2C4_MoveManager.Instance.IsInvation)
        {
            AR2C4_MoveManager.Instance.IsInvation = false;
            if (items.Contains(Invation))
            {

            }
            else
            {
                AddItem(Invation);
            }
        }
        if (AR2C4_MoveManager.Instance.IsEnvelope)
        {
            AR2C4_MoveManager.Instance.IsEnvelope = false;
            if (items.Contains(Envelope))
            {

            }
            else
            {
                AddItem(Envelope);
            }
        }
        if (AR2C4_MoveManager.Instance.IsGun)
        {
            AR2C4_MoveManager.Instance.IsGun = false;
            AddItem(Gun);
            items.Remove(Clover);
            items.Remove(Heart);
            items.Remove(Spade);
            items.Remove(Dia);
        }
        if (AR2C4_MoveManager.Instance.RemoveItems)
        {
            AR2C4_MoveManager.Instance.RemoveItems = false;
            items.Remove(Invation);
            items.Remove(Envelope);
        }
    }
    public void AR2C5_Items()
    {
        if (AR2C5_MoveManager.Instance.Getkey)
        {
            AR2C5_MoveManager.Instance.Getkey = false;
            AddItem(AR2C5_key);
        }
        if (AR2C5_MoveManager.Instance.GetCurtain)
        {
            AR2C5_MoveManager.Instance.GetCurtain = false;
            AddItem(Curtain);
        }
        if (AR2C5_MoveManager.Instance.GetScissors)
        {
            AR2C5_MoveManager.Instance.GetScissors = false;
            AddItem(Scissors);
        }
        if (AR2C5_MoveManager.Instance.UsedScissor)
        {
            AR2C5_MoveManager.Instance.UsedScissor = false;
            items.Remove(Scissors);
        }
        if (AR2C5_MoveManager.Instance.UsedKey)
        {
            AR2C5_MoveManager.Instance.UsedKey = false;
            items.Remove(AR2C5_key);
        }
        if (AR2C5_MoveManager.Instance.RemoveAll)
        {
            AR2C5_MoveManager.Instance.RemoveAll = false;
            items.Clear();
        }
    }
}


