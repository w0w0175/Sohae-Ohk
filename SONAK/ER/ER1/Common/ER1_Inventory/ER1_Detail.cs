using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER1_Detail : MonoBehaviour
{
    public static ER1_Detail Instance;

    public GameObject laddermoving;
    public GameObject Answer;
    public GameObject Inventory;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        laddermoving.SetActive(false);
        Answer.SetActive(false);
    }
    public void ClicktoUse()
    {
        SoundManager.instance.PlaySFX(Sfx.Click_Button);
        Inventory.SetActive(false);
        if (ER1C1_MovingManager.Instance != null)
        {
            if (ER1C1_MovingManager.Instance.forGloves == true)
            {
                ER1C1_MovingManager.Instance.UsedGlove = true;
                GlovesUse();
            }
            else if (ER1C1_MovingManager.Instance.UsingLadder)
            {
                ER1C1_MovingManager.Instance.Used_Ladder = true;
                LadderUse();
            }
        }
        if (ER1C2_MoveManager.Instance != null)
        {
            if (ER1_Slot.fooduse)
            {
                ER1_Slot.fooduse = false;
                ER1C2_MoveManager.Instance.UsePotFood();
            }
            if (ER1_Slot.wateruse)
            {
                ER1_Slot.wateruse = false;
                ER1C2_MoveManager.Instance.UseKettleWater();
            }
            if (ER1_Slot.kettleuse)
            {
                ER1_Slot.kettleuse = false;
                ER1C2_MoveManager.Instance.LakeWater();
            }
            if (ER1_Slot.woodsuse)
            {
                ER1_Slot.woodsuse = false;
                ER1C2_MoveManager.Instance.UseWoods();
            }
        }
        if (ER1C3_MoveManager.Instance != null)
        {
            if (ER1_Slot.medaluse)
            {
                ER1_Slot.medaluse = false;
                ER1C3_MoveManager.Instance.ViewMedal();
                ER1_Close.Instance.UsingItem = true;
            }
        }
    }

    public void GlovesUse()
    {
        ER1C1_MovingManager.Instance.forGloves = false;
        ER1C1_MovingManager.Instance.UsingGloves();
    }
    public void LadderUse()
    {
        ER1_Close.Instance.UsingItem = true;
        laddermoving.SetActive(true);
        Answer.SetActive(true);
        laddermoving.transform.localPosition = new Vector2(-2, -400);
    }
}
