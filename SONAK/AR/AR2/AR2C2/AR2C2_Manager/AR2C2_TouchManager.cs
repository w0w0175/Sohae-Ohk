using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class AR2C2_TouchManager : MonoBehaviour, IPointerClickHandler
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
            if (gameObject.name == "Q2BackBtn")
            {
                AR2C2_MoveManager.Instance.PlanAgain();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "AR2C2_Domeondo_Text")
            {
                AR2C2_MoveManager.Instance.Old_6();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Choice1_1")
            {
                AR2C2_MoveManager.Instance.AtHallway();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "AR2C2_1_1" || gameObject.name == "AR2C2_1_2" || gameObject.name == "AR2C2_1_3" || gameObject.name == "AR2C2_1_4")
            {
                gameObject.GetComponent<AR2C2_Quiz1>().ClickNums();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C2_Quiz1Answer")
            {
                AR2C2_MoveManager.Instance.Quiz1Result();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "ClickHallwayDoor")
            {
                AR2C2_MoveManager.Instance.ClickHallwayDoor();
                SoundManager.instance.PlaySFX(Sfx.Door_Open);

            }
            if (gameObject.name == "Toplanback")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR2C2_MoveManager.Instance.toplanback == true)
                {
                    AR2C2_MoveManager.Instance.PlanFront();
                }
                else
                {
                    AR2C2_MoveManager.Instance.PlanBack();
                }
            }
            if (gameObject.name == "I_toBackBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR2_Detail.planBack == true)
                {
                    AR2_Detail.Instance.PlanFront();
                }
                else
                {
                    AR2_Detail.Instance.PlanBack();
                }
            }
            if (gameObject.name == "Quiz2AnswerBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR2C2_MoveManager.Instance.Quiz2Answer();
            }
            if (gameObject.name == "Quiz2_Correct_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR2C2_MoveManager.Instance.Quiz2Success();
            }
            if (gameObject.name == "Quiz2_Wrong_1" || gameObject.name == "Quiz2_Wrong_2" || gameObject.name == "Quiz2_Wrong_3" || gameObject.name == "Quiz2_Wrong_4" || gameObject.name == "Quiz2_Wrong_5" || gameObject.name == "Quiz2_Wrong_6" || gameObject.name == "Quiz2_Wrong_7")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR2C2_MoveManager.Instance.Quiz2Fail();
            }
            if (gameObject.name == "ToPaperBackBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR2C2_MoveManager.Instance.topaperback == true)
                {
                    AR2C2_MoveManager.Instance.ToPaperBack(); AR2_Detail.Instance.ToPaperBack();
                }
                else
                {
                    AR2C2_MoveManager.Instance.ToPaperFront(); AR2_Detail.Instance.ToPaperFront();
                }
            }
            if (gameObject.name == "Quiz3_ClosedBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR2C2_MoveManager.Instance.ClosePaper(); AR2_Detail.Instance.ClosePaper();
            }
            if (gameObject.name == "I_PlanCloseBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR2_Detail.Instance.ClosePlan();
            }
            if (gameObject.name == "Q3_answer")
            {
                AR2C2_MoveManager.Instance.Quiz3Success();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Q3_wrong1" || gameObject.name == "Q3_wrong2" || gameObject.name == "Q3_wrong3" || gameObject.name == "Q3_wrong4")
            {
                AR2C2_MoveManager.Instance.Quiz3Fail();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Second")
            {
                if (AR2C2_MoveManager.Instance.IsTalking == true)
                {

                }
                else
                {
                    AR2C2_MoveManager.Instance.ClickSecond();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
            }
            if (gameObject.name == "Girl")
            {
                if (AR2C2_MoveManager.Instance.IsTalking == true)
                {

                }
                else
                {
                    AR2C2_MoveManager.Instance.ClickLittleGirl();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
            }
            if (gameObject.name == "First")
            {
                if (AR2C2_MoveManager.Instance.IsTalking == true)
                {

                }
                else
                {
                    AR2C2_MoveManager.Instance.ClickFirst();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
            }
            if (gameObject.name == "Last")
            {
                if (AR2C2_MoveManager.Instance.IsTalking == true)
                {

                }
                else
                {
                    AR2C2_MoveManager.Instance.ClickLast();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
            }
            if (gameObject.name == "Boy")
            {
                if (AR2C2_MoveManager.Instance.IsTalking == true)
                {

                }
                else
                {
                    AR2C2_MoveManager.Instance.ClickBoy();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
            }
            if (gameObject.name == "Dad")
            {
                if (AR2C2_MoveManager.Instance.IsTalking == true)
                {

                }
                else
                {
                    AR2C2_MoveManager.Instance.ClickDad();
                    SoundManager.instance.PlaySFX(Sfx.Click_UI);
                }
            }
            if (gameObject.name == "Choice2_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR2C2_MoveManager.Instance.Isfirst == true)
                {
                    AR2C2_MoveManager.Instance.First_1_1();
                }
                if (AR2C2_MoveManager.Instance.Issecond == true)
                {
                    AR2C2_MoveManager.Instance.Second_1_1();
                }
                if (AR2C2_MoveManager.Instance.Isgirl == true)
                {
                    AR2C2_MoveManager.Instance.littlegirl_1_1();
                }
                if (AR2C2_MoveManager.Instance.Isboy == true)
                {
                    AR2C2_MoveManager.Instance.Boy_1_1();
                }
                if (AR2C2_MoveManager.Instance.Isdad == true)
                {
                    AR2C2_MoveManager.Instance.Dad_1_1();
                }
            }
            if (gameObject.name == "Choice2_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR2C2_MoveManager.Instance.Isfirst == true)
                {
                    AR2C2_MoveManager.Instance.First_1_2();
                }
                if (AR2C2_MoveManager.Instance.Issecond == true)
                {
                    AR2C2_MoveManager.Instance.Second_1_2();
                }
                if (AR2C2_MoveManager.Instance.Isgirl == true)
                {
                    AR2C2_MoveManager.Instance.littlegirl_1_2();
                }
                if (AR2C2_MoveManager.Instance.Isboy == true)
                {
                    AR2C2_MoveManager.Instance.Boy_1_2();
                }
                if (AR2C2_MoveManager.Instance.Isdad == true)
                {
                    AR2C2_MoveManager.Instance.Dad_1_2();
                }
            }
            if (gameObject.name == "Q5_Answer_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C2_MoveManager.Instance.Quiz5Success();
            }
            if (gameObject.name == "Q5_Answer_1" || gameObject.name == "Q5_Answer_3" || gameObject.name == "Q5_Answer_4" || gameObject.name == "Q5_Answer_5")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C2_MoveManager.Instance.Quiz5Fail();
            }
            if (gameObject.name == "ChoiceFood")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C2_MoveManager.Instance.ClickChoicefood();
            }
            if (gameObject.name == "BacktoQuiz5")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C2_MoveManager.Instance.ClickBackQ5();
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
