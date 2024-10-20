using UnityEngine;
using UnityEngine.EventSystems;

public class AR2C5_TouchManager : MonoBehaviour, IPointerClickHandler
{
    Collider2D col;

    void Awake()
    {
        if (col == null)
        {
            col = gameObject.AddComponent<BoxCollider2D>();
        }
        col = GetComponent<Collider2D>();
        col.isTrigger = true;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        else
        {
            if (gameObject.name == "BackBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C5_BackgroundManager.Instance.ClickMain();
                AR2C5_MoveManager.Instance.ToMain();
            }
            if (gameObject.name == "Curtain")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR2C5_BackgroundManager.Instance.ClickCurtain();
                AR2C5_MoveManager.Instance.ClickCurtain();
            }
            if (gameObject.name == "Window")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR2C5_BackgroundManager.Instance.ClickWindow();
                AR2C5_MoveManager.Instance.ClickWindow();
            }
            if (gameObject.name == "Chandelier")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR2C5_BackgroundManager.Instance.ClickChandelier();
                AR2C5_MoveManager.Instance.ClickChandelier();
            }
            if (gameObject.name == "UnderBox")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR2C5_BackgroundManager.Instance.ClickUnderBox();
                AR2C5_MoveManager.Instance.ClickUnderBed();
            }
            if (gameObject.name == "ToDesk")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C5_MoveManager.Instance.ToDesk();
            }
            if (gameObject.name == "Desk_Left")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR2C5_MoveManager.Instance.ClickRIght();
            }
            if (gameObject.name == "Desk_Right")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR2C5_MoveManager.Instance.ClickLeft();
            }
            if (gameObject.name == "Right_Dial_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<AR2C5_LeftDial>().ClickNum1();
            }
            if (gameObject.name == "Right_Dial_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<AR2C5_LeftDial>().ClickNum2();
            }
            if (gameObject.name == "Right_Dial_3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<AR2C5_LeftDial>().ClickNum3();
            }
            if (gameObject.name == "Right_Dial_4")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                gameObject.GetComponent<AR2C5_LeftDial>().ClickNum4();
            }
            if (gameObject.name == "Left_Submit")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C5_MoveManager.Instance.RightResult();
            }
            if (gameObject.name == "Right_Submit")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C5_MoveManager.Instance.LeftResult();
            }
            if (gameObject.name == "Cup_Submit")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C5_MoveManager.Instance.CupResult();
            }
            if (gameObject.name == "Scissor")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR2C5_MoveManager.Instance.ClickScissors();
            }
            if (gameObject.name == "Choice3_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C5_MoveManager.Instance.Ceremony_1_1();
            }
            if (gameObject.name == "Choice3_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C5_MoveManager.Instance.Ceremony_1_2();
            }
            if (gameObject.name == "Choice3_3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C5_MoveManager.Instance.Ceremony_1_3();
            }
            if (gameObject.name == "ClickLake")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR2C5_MoveManager.Instance.ClicktoLake();
            }
            if (gameObject.name == "AddSkill_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Magic_Use);
                AR2C5_MoveManager.Instance.ClickSkill1();
            }
            if (gameObject.name == "AddSkill_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Magic_Use);
                AR2C5_MoveManager.Instance.ClickSkill2();
            }
            if (gameObject.name == "ClickOther")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR2C5_MoveManager.Instance.Ceremony_3();
            }
            if (gameObject.name == "Old_Back")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C5_MoveManager.Instance.CloseOld();
            }
            if (gameObject.name == "Old_Submit")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C5_MoveManager.Instance.OldResult();
            }
        }
    }
}
