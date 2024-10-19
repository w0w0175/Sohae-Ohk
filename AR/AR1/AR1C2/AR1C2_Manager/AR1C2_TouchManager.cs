using UnityEngine;
using UnityEngine.EventSystems;

public class AR1C2_TouchManager : MonoBehaviour, IPointerClickHandler
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
            if (gameObject.name == "onClick")
            {
                AR1C2_MovingManager.Instance.Intro_2();
            }
            if (gameObject.name == "IntroBG1")
            {
                AR1C2_MovingManager.Instance.Intro();
            }
            if (gameObject.name == "Choice1")
            {
                AR1C2_MovingManager.Instance.Inform_1();
            }
            if (gameObject.name == "Choice2_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR1C2_MovingManager.Instance.forQ2 == true)
                {
                    AR1C2_MovingManager.Instance.Q2_WalkIn();
                }
                else if (AR1C2_MovingManager.Instance.forQ4 == true)
                {
                    AR1C2_MovingManager.Instance.ClickWalk();
                }
                else
                {
                    AR1C2_MovingManager.Instance.ShowID();
                }
            }
            if (gameObject.name == "Choice2_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR1C2_MovingManager.Instance.forQ2 == true)
                {
                    AR1C2_MovingManager.Instance.forQ2 = false;
                    AR1C2_MovingManager.Instance.Q2_Listening();

                }
                else if (AR1C2_MovingManager.Instance.forQ4 == true)
                {
                    AR1C2_MovingManager.Instance.ClickRun();
                }
                else
                {
                    AR1C2_MovingManager.Instance.Pissedoff();
                }
            }
            if (gameObject.name == "134A")
            {
                AR1C2_MovingManager.Instance.Q1_134A();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "131A" || gameObject.name == "132A" || gameObject.name == "133A" || gameObject.name == "131B" || gameObject.name == "132B" || gameObject.name == "133B" || gameObject.name == "134B")
            {
                AR1C2_MovingManager.Instance.Q1_Fail();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR1C2_Q2Man")
            {
                AR1C2_MovingManager.Instance.Q2_ClickMan();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR1C2_Q2Woman")
            {
                AR1C2_MovingManager.Instance.Q2_ClickWoman();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR1C2_Q2Btn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR1C2_MovingManager.Instance.CheckQ2 == true)
                {
                    AR1C2_MovingManager.Instance.AR1C2_Q2Answer();
                }
                else
                {

                }
            }
            if (gameObject.name == "Q2ChoiceBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR1C2_Q2A.AR1C2_Q2ACheck == true)
                {
                    AR1C2_MovingManager.Instance.Q2_SelectWoman();
                }
                if (AR1C2_Q2B.AR1C2_Q2BCheck == true)
                {
                    AR1C2_MovingManager.Instance.Q2_SelectMan();
                }
            }
            if (gameObject.name == "AddSkill_1")
            {
                AR1C2_MovingManager.Instance.UseARSkill2();
            }
            if (gameObject.name == "AddSkill_2")
            {
                AR1C2_MovingManager.Instance.UseARSkill3();
            }
            if (gameObject.name == "Q4_Block2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C2_MovingManager.Instance.Q4_Success();
            }
            if (gameObject.name == "Q4_Block1" || gameObject.name == "Q4_Block3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C2_MovingManager.Instance.Q4_Fail();
            }
            if (gameObject.name == "RedDoor")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C2_MovingManager.Instance.ChoiceRedDoor();
            }
            if (gameObject.name == "BlueDoor")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C2_MovingManager.Instance.ChoiceBlueDoor();
            }
            if (gameObject.name == "GreenDoor")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C2_MovingManager.Instance.ChoiceGreenDoor();
            }
            if (gameObject.name == "YellowDoor")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C2_MovingManager.Instance.ChoiceYellowDoor();
            }
            if (gameObject.name == "Q5_Select")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR1C2_MovingManager.Instance.Q5Answer();
            }
            if (gameObject.name == "Q5_Return")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR1C2_MovingManager.Instance.Q5Return();
            }
        }
    }
}