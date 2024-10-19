using UnityEngine;
using UnityEngine.EventSystems;

public class AR2C1_TouchManager : MonoBehaviour, IPointerClickHandler
{
    Collider2D col;

    bool FrameCheck = false;

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
            if (gameObject.name == "Choice1_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR2C1_MovingManager.Instance.iseventb == true)
                {
                    AR2C1_MovingManager.Instance.iseventb = false;
                    AR2C1_MovingManager.Instance.EventB_1();
                }
                else
                {
                    AR2C1_MovingManager.Instance.ClicktoRoom();
                }
            }
            if (gameObject.name == "Choice2_1")
            {
                AR2C1_MovingManager.Instance.A_OpenDoor();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Choice2_2")
            {
                AR2C1_MovingManager.Instance.A_Asking();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "AR2C1_ToHallway")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR2C1_MovingManager.Instance.ClicktoHallway();
            }
            if (gameObject.name == "AR2C1_ToRoom")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR2C1_MovingManager.Instance.ClicktoRoom();
            }
            if (gameObject.name == "BackBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR2C1_BackGroundManager.Instance.ClicktoMain();
                AR2C1_MovingManager.Instance.ClicktoMain();
                AR2C1_MovingManager.Instance.WindowON = false;
                AR2C1_MovingManager.Instance.BoxON = false;
                AR2C1_MovingManager.Instance.CarpetON = false;
            }
            if (gameObject.name == "AR2C1_Window")
            {
                AR2C1_BackGroundManager.Instance.ClickWindow();
                AR2C1_MovingManager.Instance.ClickWindow();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (!AR2C1_MovingManager.Instance.WindowON)
            {
                if (gameObject.name == "Carpet_Click")
                {
                    if (AR2C1_MovingManager.Instance.isusing == true)
                    {

                    }
                    else
                    {
                        AR2C1_BackGroundManager.Instance.ClickUnderCarpet();
                        AR2C1_MovingManager.Instance.ClickCarpet();
                        SoundManager.instance.PlaySFX(Sfx.Click_UI);
                    }
                }
                if (gameObject.name == "AR2C1_Letter")
                {
                    if (AR2C1_MovingManager.Instance.isusing == true)
                    {

                    }
                    else
                    {
                        AR2C1_BackGroundManager.Instance.ClickLetter();
                        AR2C1_MovingManager.Instance.ClickLetter();
                    }

                }
                if (!AR2C1_MovingManager.Instance.CarpetON)
                {
                    if (gameObject.name == "AR2C1_Frame" || gameObject.name == "AR2C1_Desk")
                    {
                        AR2C1_MovingManager.Instance.ClickDesk();
                        SoundManager.instance.PlaySFX(Sfx.Click_UI);
                    }
                }
                if (!AR2C1_MovingManager.Instance.BoxON)
                {
                    if (gameObject.name == "AR2C1_BookCase")
                    {
                        AR2C1_BackGroundManager.Instance.ClickBookCase();
                        AR2C1_MovingManager.Instance.ClickBookCase();
                        SoundManager.instance.PlaySFX(Sfx.Click_UI);
                    }
                }
                if (!AR2C1_MovingManager.Instance.HQprogress)
                {
                    if (gameObject.name == "AR2C1_Box")
                    {
                        AR2C1_BackGroundManager.Instance.ClickBox();
                        AR2C1_MovingManager.Instance.ClickBox();
                        SoundManager.instance.PlaySFX(Sfx.Click_UI);
                    }
                }
                if (gameObject.name == "UpperLocker")
                {
                    GameObject go = GameObject.Find("AR2C1_HiddenQuiz");
                    AR2C1_MovingManager.Instance.BoxResult();
                    go.GetComponent<AR2C1_LockerSolved>().OnClickUpperLocker();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
                if (gameObject.name == "AR2C1_Map")
                {
                    if (AR2C1_MovingManager.Instance.ismap == true)
                    {

                    }
                    else
                    {
                        AR2C1_MovingManager.Instance.ClickMap();
                        SoundManager.instance.PlaySFX(Sfx.Click_UI);
                    }
                }
                if (gameObject.name == "MapBtn5")
                {
                    AR2C1_MovingManager.Instance.MapSuccess();
                    SoundManager.instance.PlaySFX(Sfx.Click_Button);

                }
                if (gameObject.name == "MapBtn1" || gameObject.name == "MapBtn2" || gameObject.name == "MapBtn3" || gameObject.name == "MapBtn4")
                {
                    AR2C1_MovingManager.Instance.MapFail();
                    SoundManager.instance.PlaySFX(Sfx.Click_Button);

                }
                if (gameObject.name == "AR2C1_LampOff")
                {
                    if (AR2C1_MovingManager.Instance.isusing == true)
                    {

                    }
                    else
                    {
                        AR2C1_MovingManager.Instance.ClickLamp();
                        SoundManager.instance.PlaySFX(Sfx.Click_UI);
                    }
                }
                if (gameObject.name == "AR2C1_LeftDrawer" || gameObject.name == "AR2C1_RightDrawer")
                {
                    if (AR2C1_MovingManager.Instance.isusing == true)
                    {

                    }
                    else
                    {
                        AR2C1_MovingManager.Instance.ClickDrawer();
                        SoundManager.instance.PlaySFX(Sfx.Click_UI);
                    }
                }
                if (gameObject.name == "AR2C1_Heart3")
                {
                    if (AR2C1_MovingManager.Instance.isusing == true)
                    {

                    }
                    else
                    {
                        AR2C1_MovingManager.Instance.ClickHeart3();
                        SoundManager.instance.PlaySFX(Sfx.Click_UI);
                    }
                }
                if (gameObject.name == "AR2C1_FrameMove")
                {
                    if (AR2C1_MovingManager.Instance.isusing == true)
                    {

                    }
                    else
                    {
                        if (!FrameCheck)
                        {
                            FrameCheck = true;
                            AR2C1_FrameMove.Instance.StartFrameMove();
                            SoundManager.instance.PlaySFX(Sfx.Click_UI);
                        }
                    }
                }
                if (gameObject.name == "AR2C1_Dia7")
                {
                    if (AR2C1_Dia7Move.Instance.IsEndMoving == true)
                    {
                        AR2C1_Dia7Move.Instance.IsEndMoving = false;
                        AR2C1_MovingManager.Instance.Frame_1();
                        SoundManager.instance.PlaySFX(Sfx.Click_UI);
                    }
                }
                if (gameObject.name == "AR2C1_Clover")
                {
                    gameObject.GetComponent<AR2C1_ForLocker>().ClickNums();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
                if (gameObject.name == "AR2C1_Heart")
                {
                    gameObject.GetComponent<AR2C1_ForLocker>().ClickNums();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
                if (gameObject.name == "AR2C1_Dia")
                {
                    gameObject.GetComponent<AR2C1_ForLocker>().ClickNums();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
                if (gameObject.name == "AR2C1_Spade")
                {
                    gameObject.GetComponent<AR2C1_ForLocker>().ClickNums();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
                if (gameObject.name == "LetterOpenBtn")
                {
                    AR2C1_MovingManager.Instance.Letter_2();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
                if (gameObject.name == "Close_Item")
                {
                    SoundManager.instance.PlaySFX(Sfx.Click_Button);

                    AR2_Close.Instance.CloseContent();
                    AR2_Close.UsingItem = false;
                }
            }
        }
    }
}
