using UnityEngine;
using UnityEngine.EventSystems;

public class ER1C2_TouchManager : MonoBehaviour, IPointerClickHandler
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
            if (gameObject.name == "BackBtn")
            {
                ER1C2_MoveManager.Instance.ToMain();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "ToRight")
            {
                ER1C2_MoveManager.Instance.ToRight();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "ToLeft")
            {
                ER1C2_MoveManager.Instance.ToLeft();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "TownHall_Door")
            {
                ER1C2_MoveManager.Instance.ClickDoor();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "TownHall_Horse")
            {
                ER1C2_MoveManager.Instance.ClickHorse();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "HorseLeft")
            {
                ER1C2_MoveManager.Instance.HorsetoMain();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "First_Quest")
            {
                ER1C2_MoveManager.Instance.ChapStart_1();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "DoorEye_1")
            {
                ER1C2_DoorManager.Instance.Door1Click();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "DoorEye_2")
            {
                ER1C2_DoorManager.Instance.Door2Click();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "DoorEye_3")
            {
                ER1C2_DoorManager.Instance.Door3Click();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "DoorEye_4")
            {
                ER1C2_DoorManager.Instance.Door4Click();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "ToKitchen")
            {
                ER1C2_MoveManager.Instance.ClickKitchen();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "ToBackyard")
            {
                ER1C2_MoveManager.Instance.ClickBackyard();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Kitchen_Drawer")
            {
                ER1C2_MoveManager.Instance.ClickDrawer();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Kitchen_Box")
            {
                ER1C2_MoveManager.Instance.ClickBox();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Food")
            {
                ER1C2_MoveManager.Instance.ClickFood();
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
            }
            if (gameObject.name == "Box_Submit")
            {
                ER1C2_MoveManager.Instance.BoxResult();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Answer_D_1")
            {
                ER1C2_DrawerManager.Instance.Drawer1Click();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Answer_D_2")
            {
                ER1C2_DrawerManager.Instance.Drawer2Click();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Answer_D_3")
            {
                ER1C2_DrawerManager.Instance.Drawer3Click();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Kettle")
            {
                ER1C2_MoveManager.Instance.ClickKettle();
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
            }
            if (gameObject.name == "Back_Tree")
            {
                ER1C2_MoveManager.Instance.ClickTree();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Branch_1")
            {
                ER1C2_TreeManager.Instance.ClickTree1();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Branch_2")
            {
                ER1C2_TreeManager.Instance.ClickTree2();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Branch_3")
            {
                ER1C2_TreeManager.Instance.ClickTree3();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Branch_4")
            {
                ER1C2_TreeManager.Instance.ClickTree4();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Back_Fish")
            {
                ER1C2_MoveManager.Instance.ClickFish();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Back_Lake")
            {
                ER1C2_MoveManager.Instance.ClickLake();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Back_Flower_1")
            {
                ER1C2_MoveManager.Instance.ClickFlower();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Back_Flower_2")
            {
                ER1C2_MoveManager.Instance.ClickAfterFlower();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "UseBow")
            {
                ER1C2_MoveManager.Instance.UseBow();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "AddSkill_1")
            {
                ER1C2_MoveManager.Instance.UseSkill1();
                SoundManager.instance.PlaySFX(Sfx.Magic_Use);
            }
            if (gameObject.name == "Fourth_Confirm")
            {
                ER1C2_MoveManager.Instance.Quest4Confirm();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Foot_River")
            {
                ER1C2_MoveManager.Q5select = 1;
                ER1C2_MoveManager.Instance.FootFail();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Foot_Mountain")
            {
                ER1C2_MoveManager.Q5select = 2;
                ER1C2_MoveManager.Instance.FootFail();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Foot_Rock")
            {
                ER1C2_MoveManager.Q5select = 3;
                ER1C2_MoveManager.Instance.FootFail();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Foot_Forest")
            {
                ER1C2_MoveManager.Instance.FootSuccess();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Pot")
            {
                ER1C2_MoveManager.Instance.ClickPot();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
        }
    }
}
