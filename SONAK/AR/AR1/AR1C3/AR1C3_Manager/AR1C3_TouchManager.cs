using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AR1C3_TouchManager : MonoBehaviour, IPointerClickHandler
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
            if (gameObject.name == "QuestOK")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR1C3_Intro.NextText == true)
                {
                    AR1C3_Intro.NextText = false;
                    AR1C3_Intro.Instance.AR1C3_Quest_2();
                }
                else
                {
                    AR1C3_Intro.Instance.EndQuest();
                    AR1C3_MoveManager.Instance.BeforeQuiz1();
                }
            }
            if (gameObject.name == "Choice2_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR1C3_MoveManager.Instance.Quiz1Start();
            }
            if (gameObject.name == "Choice2_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR1C3_MoveManager.Instance.RightSelected();
                AR1C3_MoveManager.Instance.BacktoQuiz2();
            }
            if (gameObject.name == "FindKey")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR1C3_MoveManager.Instance.Quiz1FindKey();
            }
            if (gameObject.name == "BurnDoor")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR1C3_MoveManager.Instance.Quiz1BurnDoor();
            }
            if (gameObject.name == "UseButton")
            {
                AR1C3_MoveManager.Instance.Quiz1SkillUse();
            }
            if (gameObject.name == "Q2_Carpet")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C3_MoveManager.Instance.Quiz2Carpet();
            }
            if (gameObject.name == "Q2_Canvas")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C3_MoveManager.Instance.Quiz2Canvas();
            }
            if (gameObject.name == "Q2_Plant")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C3_MoveManager.Instance.Quiz2Plant();
            }
            if (gameObject.name == "Q2_Picture")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C3_MoveManager.Instance.Quiz2Picture();
            }
            if (gameObject.name == "Q2_Closet")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C3_MoveManager.Instance.Quiz2Closet();
            }
            if (gameObject.name == "Q3_1" || gameObject.name == "Q3_2" || gameObject.name == "Q3_3" || gameObject.name == "Q3_4" || gameObject.name == "Q3_5")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C3_MoveManager.Instance.Quiz3Confirm();
                gameObject.GetComponent<ObjectChange>().GameObjectChange();
            }
            if (gameObject.name == "Q3_Selected_1" || gameObject.name == "Q3_Selected_2" || gameObject.name == "Q3_Selected_3" || gameObject.name == "Q3_Selected_4" || gameObject.name == "Q3_Selected_5")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C3_MoveManager.Instance.Quiz3Cancel();
                gameObject.GetComponent<ObjectChange>().GameObjectChange();
            }
            if (gameObject.name == "Q3_Confirm")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR1C3_MoveManager.Instance.Quiz3Answer();
            }
            if (gameObject.name == "Q5_SkillUse")
            {
                AR1C3_Q5Manager.Instance.Q5SkillEffect();
            }
            if (gameObject.name == "OutroOK")
            {
                AR1C3_MoveManager.Instance.OutroBoxOut();
            }
        }
    }
}