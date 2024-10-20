using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Collections;

public class ER1_Inventory : MonoBehaviour
{
    public List<ER1_Item> items;
    public static ER1_Inventory Instance;

    public ER1_Item Meat;
    public ER1_Item Feed;
    public ER1_Item Honey;
    public ER1_Item Ladder;
    public ER1_Item Gloves;
    public ER1_Item Foods;
    public ER1_Item Kettle;
    public ER1_Item Woods;
    public ER1_Item Medal;


    [SerializeField] private Transform slotParent;
    [SerializeField] private ER1_Slot[] slots;

    void Start()
    {
        if (Instance == null)
            Instance = this;
         StartCoroutine("StartInven");
    }
    IEnumerator StartInven()
    {
        switch (GameManager.instance.ChapterNum)
        {
            case 1:
                items.Clear();
                yield return null;
                AddItem(Gloves);
                yield return null;
                AddItem(Feed);
                break;
            case 2:
                items.Clear();
                yield return null;
                break;
            case 3:
                items.Clear();
                yield return null;
                break;
        }
    }
    void Update()
    {
        FreshSlot();
        if (GameManager.instance.ChapterNum == 1)
        {
            if (ER1C1_MovingManager.Instance != null)
            {
                ER1C1_Items();
            }
        }
        else if (GameManager.instance.ChapterNum == 2)
        {
            if (ER1C2_MoveManager.Instance != null)
            {
                ER1C2_Items();
            }
        }
        else if (GameManager.instance.ChapterNum == 3)
        {
            if (ER1C3_MoveManager.Instance != null)
            {
                ER1C3_Items();
            }
        }
    }
    private void OnValidate()
    {
        slots = slotParent.GetComponentsInChildren<ER1_Slot>();
    }
    public void FreshSlot()
    {
        int i = 0;

        for (; i < items.Count && i < slots.Length; i++)
        {
            slots[i].item = items[i];
        }
        for (; i<slots.Length; i++)
        {
            slots[i].item = null;
        }
        items = items.Distinct().ToList();
    }

    public void AddItem(ER1_Item _item)
    {
        if(items.Count < slots.Length)
        {
            items.Add(_item);

            FreshSlot();
        }   
        else
        {

        }
    }

    public void ER1C1_Items()
    {
        if (ER1C1_MovingManager.Instance.forMeat)
        {
            ER1C1_MovingManager.Instance.forMeat = false;
            AddItem(Meat);
        }
        if (ER1C1_MovingManager.Instance.forHoney)
        {
            ER1C1_MovingManager.Instance.forHoney = false;
            AddItem(Honey);
        }
        if (ER1C1_MovingManager.Instance.BirdAgain)
        {
            ER1C1_MovingManager.Instance.BirdAgain = false;
            AddItem(Feed);
        }
        if (ER1C1_MovingManager.Instance.forLadder)
        {
            ER1C1_MovingManager.Instance.forLadder = false;
            AddItem(Ladder);
        }
        if (ER1C1_MovingManager.Instance.UsedGlove)
        {
            ER1C1_MovingManager.Instance.UsedGlove = false;
            items.Remove(Gloves);
        }
        if (ER1C1_MovingManager.Instance.Used_Ladder)
        {
            ER1C1_MovingManager.Instance.Used_Ladder = false;
            items.Remove(Ladder);
        }
        if (ER1C1_MovingManager.Instance.Used_Bird)
        {
            ER1C1_MovingManager.Instance.Used_Bird = false;
            items.Remove(Feed);
        }
        if (ER1C1_MovingManager.Instance.Used_Meat)
        {
            ER1C1_MovingManager.Instance.Used_Meat = false;
            items.Remove(Meat);
        }
        if (ER1C1_MovingManager.Instance.Used_Honey)
        {
            ER1C1_MovingManager.Instance.Used_Honey = false;
            items.Remove(Honey);
        }
    }
    public void ER1C2_Items()
    {
        if (ER1C2_MoveManager.Instance.GetFood)
        {
            ER1C2_MoveManager.Instance.GetFood = false;
            AddItem(Foods);
        }
        if (ER1C2_MoveManager.Instance.GetKettle)
        {
            ER1C2_MoveManager.Instance.GetKettle = false;
            AddItem(Kettle);
        }
        if (ER1C2_MoveManager.Instance.GetWoods)
        {
            ER1C2_MoveManager.Instance.GetWoods = false;
            AddItem(Woods);
        }
        if (ER1C2_MoveManager.Instance.UsedWoods)
        {
            ER1C2_MoveManager.Instance.UsedWoods = false;
            items.Remove(Woods);
        }
        if (ER1C2_MoveManager.Instance.UsedKettle)
        {
            ER1C2_MoveManager.Instance.UsedKettle = false;
            items.Remove(Kettle);
        }
        if (ER1C2_MoveManager.Instance.UsedPotFood)
        {
            ER1C2_MoveManager.Instance.UsedPotFood = false;
            items.Remove(Foods);
        }
    }
    public void ER1C3_Items()
    {
        if (ER1C3_MoveManager.Instance.GetMedal)
        {
            ER1C3_MoveManager.Instance.GetMedal = false;
            AddItem(Medal);
        }
    }
}