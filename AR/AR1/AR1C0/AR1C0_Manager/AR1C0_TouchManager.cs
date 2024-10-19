using UnityEngine;
using UnityEngine.EventSystems;

public class AR1C0_TouchManager : MonoBehaviour, IPointerClickHandler
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
                AR1C0_MoveManager.Instance.ClickRight();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "ToLeft")
            {
                AR1C0_MoveManager.Instance.ClickLeft();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Profile_C")
            {
                AR1C0_MoveManager.Instance.ClickProfiles();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Blackboard_C")
            {
                AR1C0_MoveManager.Instance.ClickBlackboard();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Files_C")
            {
                AR1C0_MoveManager.Instance.ClickFiles();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Files_Close")
            {
                AR1C0_MoveManager.Instance.ClickFilesReadClose();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Files_Explain")
            {
                AR1C0_MoveManager.Instance.Files_1();
            }
            if (gameObject.name == "Files_Read")
            {
                AR1C0_MoveManager.Instance.ClickFilesRead();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Files_Enter")
            {
                AR1C0_MoveManager.Instance.ClickFilesAnswer();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Files_Back")
            {
                AR1C0_MoveManager.Instance.ClickFilesBack();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Files_Next")
            {
                AR1C0_MoveManager.Instance.ClickFilesNext();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Files_Submit")
            {
                AR1C0_MoveManager.Instance.FilesResult();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Files_AnswerBack")
            {
                AR1C0_MoveManager.Instance.ClickFilesAnswerBack();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Quiz2_Answer1")
            {
                AR1C0_MoveManager.Instance.ForQuiz2 = 1;
                AR1C0_MoveManager.Instance.ClickQuiz2People();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Quiz2_Answer2")
            {
                AR1C0_MoveManager.Instance.ForQuiz2 = 2;
                AR1C0_MoveManager.Instance.ClickQuiz2People();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Quiz2_Answer3")
            {
                AR1C0_MoveManager.Instance.ForQuiz2 = 3;
                AR1C0_MoveManager.Instance.ClickQuiz2People();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Quiz2_Back")
            {
                AR1C0_MoveManager.Instance.ClickQuiz2Back();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Quiz2_Submit")
            {
                AR1C0_MoveManager.Instance.ClickQuiz2Submit();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Pic_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                if (AR1C0_BlackboardManager.Instance.IsSelected1 == false)
                {
                    AR1C0_BlackboardManager.Instance.IsSelected1 = true;
                    AR1C0_BlackboardManager.Instance.MakeLines();
                    AR1C0_BlackboardManager.Instance.ImageChange(gameObject);
                }
                else
                {
                    AR1C0_BlackboardManager.Instance.IsSelected1 = false;
                    AR1C0_BlackboardManager.Instance.ReturnImage(gameObject);
                }
            }
            if (gameObject.name == "Pic_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                if (AR1C0_BlackboardManager.Instance.IsSelected2 == false)
                {
                    AR1C0_BlackboardManager.Instance.IsSelected2 = true;
                    AR1C0_BlackboardManager.Instance.MakeLines();
                    AR1C0_BlackboardManager.Instance.ImageChange(gameObject);
                }
                else
                {
                    AR1C0_BlackboardManager.Instance.IsSelected2 = false;
                    AR1C0_BlackboardManager.Instance.ReturnImage(gameObject);
                }
            }
            if (gameObject.name == "Pic_3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                if (AR1C0_BlackboardManager.Instance.IsSelected3 == false)
                {
                    AR1C0_BlackboardManager.Instance.IsSelected3 = true;
                    AR1C0_BlackboardManager.Instance.MakeLines();
                    AR1C0_BlackboardManager.Instance.ImageChange(gameObject);
                }
                else
                {
                    AR1C0_BlackboardManager.Instance.IsSelected3 = false;
                    AR1C0_BlackboardManager.Instance.ReturnImage(gameObject);
                }
            }
            if (gameObject.name == "Pic_4")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                if (AR1C0_BlackboardManager.Instance.IsSelected4 == false)
                {
                    AR1C0_BlackboardManager.Instance.IsSelected4 = true;
                    AR1C0_BlackboardManager.Instance.MakeLines();
                    AR1C0_BlackboardManager.Instance.ImageChange(gameObject);
                }
                else
                {
                    AR1C0_BlackboardManager.Instance.IsSelected4 = false;
                    AR1C0_BlackboardManager.Instance.ReturnImage(gameObject);
                }
            }
            if (gameObject.name == "Blackboard_Submit")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                if (AR1C0_MoveManager.Instance.BlackEnd)
                {
                    AR1C0_MoveManager.Instance.BlackboardBack();
                }
                else
                {
                    AR1C0_BlackboardManager.Instance.BBResult();
                }
            }
            if (gameObject.name == "Quiz4_GoBack")
            {
                AR1C0_MoveManager.Instance.Quiz4Back();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Quiz5_Answer1")
            {
                AR1C0_MoveManager.Instance.Quiz5Fail();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Quiz5_Answer2")
            {
                AR1C0_MoveManager.Instance.Quiz5Fail();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Quiz5_Answer3")
            {
                AR1C0_MoveManager.Instance.Quiz5Success();
            }
            if (gameObject.name == "Quiz5_Answer4")
            {
                AR1C0_MoveManager.Instance.Quiz5Fail();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Typer_C")
            {
                AR1C0_MoveManager.Instance.ClickTyper();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Note_CloseBtn")
            {
                AR1C0_MoveManager.Instance.CloseNote();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Blackboard_Back")
            {
                AR1C0_BlackboardManager.Instance.PlayAgain();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Blackboard_Close")
            {
                AR1C0_MoveManager.Instance.BlackboardBack();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Quiz4_Confirm")
            {
                AR1C0_MoveManager.Instance.Quiz4Result();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Q4Left")
            {
                AR1C0_MoveManager.Instance.Q4ToLeft();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Q4Right")
            {
                AR1C0_MoveManager.Instance.Q4ToRight();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
        }
    }
}
