using UnityEngine;
using UnityEngine.EventSystems;

public class ER1C3_TouchManager : MonoBehaviour, IPointerClickHandler
{
    Collider2D col;
    void Awake()
    {
        col = GetComponent<Collider2D>();
        if (col == null)
        {
            col = gameObject.AddComponent<BoxCollider2D>();
            col.isTrigger = true;
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        else
        {
            if (gameObject.name == "ToRight")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickRightBtn();
            }
            if (gameObject.name == "ToLeft")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickLeftBtn();
            }
            if (gameObject.name == "Q1Look")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.Quiz1Start();
            }
            if (gameObject.name == "Necklace")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.ClickMedal();
            }
            if (gameObject.name == "OldBucket")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.ClickOldCase();
            }
            if (gameObject.name == "Calendar")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.ClickCalendar();
            }
            if (gameObject.name == "Q1_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<ER1C3_Q1Manager>().ClickQ1_1();
            }
            if (gameObject.name == "Q1_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<ER1C3_Q1Manager>().ClickQ1_2();
            }
            if (gameObject.name == "Q1_3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<ER1C3_Q1Manager>().ClickQ1_3();
            }
            if (gameObject.name == "Q1_4")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<ER1C3_Q1Manager>().ClickQ1_4();
            }
            if (gameObject.name == "Q1_Submit")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.Q1Result();
            }
            if (gameObject.name == "Q1_Back")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickQ1Back();
            }
            if (gameObject.name == "Quiz2Back")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.ClickQ2Back();
            }
            if (gameObject.name == "Q2_Explain")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.Quiz2_1();
            }
            if (gameObject.name == "Q2_Confirm")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.ClickQ2Confirm();
            }
            if (gameObject.name == "Q2_BacktoHall")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.ClickQ2BacktoHall();
            }
            if (gameObject.name == "Q3Look")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickQ3Look();
            }
            if (gameObject.name == "CaveMark")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.ClickCaveMark();
            }
            if (gameObject.name == "Q3_Submit")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.Q3Result();
            }
            if (gameObject.name == "LockedGlass")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickGlass();
            }
            if (gameObject.name == "Q4Confirm")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickQ4Confirm();
            }
            if (gameObject.name == "Q4Answer_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<ER1C3_Q4Manager>().ClickNum1();
            }
            if (gameObject.name == "Q4Answer_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<ER1C3_Q4Manager>().ClickNum2();
            }
            if (gameObject.name == "Q4Answer_3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<ER1C3_Q4Manager>().ClickNum3();
            }
            if (gameObject.name == "Q4Answer_4")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<ER1C3_Q4Manager>().ClickNum4();
            }
            if (gameObject.name == "Q4_Submit")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickQ4Submit();
            }
            if (gameObject.name == "Q4_ToRemember")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickQ4Remember();
            }
            if (gameObject.name == "Medal_X")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.CloseMedal();
            }
            if (gameObject.name == "Medal_Btn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.TurnMedal();
            }
            if (gameObject.name == "Q5Make")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickQ5Make();
            }
            if (gameObject.name == "Bookcase")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.ClickBookcase();
            }
            if (gameObject.name == "Result1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.ClickResult1();
            }
            if (gameObject.name == "Result2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.ClickResult2();
            }
            if (gameObject.name == "Result3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                ER1C3_MoveManager.Instance.ClickResult3();
            }
            if (gameObject.name == "BackBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ToMain();
            }
            if (gameObject.name == "Leaf1Locker")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickLockerLeaf1();
            }
            if (gameObject.name == "Leaf2Locker")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickLockerLeaf2();
            }
            if (gameObject.name == "Leaf3Locker")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.ClickLockerLeaf3();
            }
            if (gameObject.name == "Leaf_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_LeafManager.Instance.Click1();
            }
            if (gameObject.name == "Leaf_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_LeafManager.Instance.Click2();
            }
            if (gameObject.name == "Leaf_3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_LeafManager.Instance.Click3();
            }
            if (gameObject.name == "Leaf_4")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_LeafManager.Instance.Click4();
            }
            if (gameObject.name == "Leaf_5")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_LeafManager.Instance.Click5();
            }
            if (gameObject.name == "Leaf_6")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_LeafManager.Instance.Click6();
            }
            if (gameObject.name == "Leaf_7")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_LeafManager.Instance.Click7();
            }
            if (gameObject.name == "Leaf_8")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_LeafManager.Instance.Click8();
            }
            if (gameObject.name == "Leaf_9")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_LeafManager.Instance.Click9();
            }
            if (gameObject.name == "LeafLocker_Submit")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.Q5Input();
            }
            if (gameObject.name == "Locker_Open")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                ER1C3_MoveManager.Instance.Q5Result();
            }
            if (gameObject.name == "AddSkill_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Magic_Use);
                ER1C3_MoveManager.Instance.ClickUseSkill();
            }
        }
    }
}
