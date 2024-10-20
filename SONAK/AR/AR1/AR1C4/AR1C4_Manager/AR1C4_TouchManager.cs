using UnityEngine;
using UnityEngine.EventSystems;

public class AR1C4_TouchManager : MonoBehaviour, IPointerClickHandler
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
            if (gameObject.name == "Intro_Confirm")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_Intro.Instance.IntroStart();
            }
            if (gameObject.name == "Glasses")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR1C4_MoveManager.Instance.ClickGlasses();
            }
            if (gameObject.name == "GlassWithNote")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR1C4_MoveManager.Instance.ClickGlassNote();
            }
            if (gameObject.name == "Chair")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR1C4_MoveManager.Instance.ClickChair();
            }
            if (gameObject.name == "Pic_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                if (AR1C4_BlackboardManager.Instance.IsSelected1 == false)
                {
                    AR1C4_BlackboardManager.Instance.IsSelected1 = true;
                    AR1C4_BlackboardManager.Instance.MakeLines();
                    AR1C4_BlackboardManager.Instance.ImageChange(gameObject);
                }
                else
                {
                    AR1C4_BlackboardManager.Instance.IsSelected1 = false;
                    AR1C4_BlackboardManager.Instance.ReturnImage(gameObject);
                }
            }
            if (gameObject.name == "Pic_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                if (AR1C4_BlackboardManager.Instance.IsSelected2 == false)
                {
                    AR1C4_BlackboardManager.Instance.IsSelected2 = true;
                    AR1C4_BlackboardManager.Instance.MakeLines();
                    AR1C4_BlackboardManager.Instance.ImageChange(gameObject);
                }
                else
                {
                    AR1C4_BlackboardManager.Instance.IsSelected2 = false;
                    AR1C4_BlackboardManager.Instance.ReturnImage(gameObject);
                }
            }
            if (gameObject.name == "Pic_3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                if (AR1C4_BlackboardManager.Instance.IsSelected3 == false)
                {
                    AR1C4_BlackboardManager.Instance.IsSelected3 = true;
                    AR1C4_BlackboardManager.Instance.MakeLines();
                    AR1C4_BlackboardManager.Instance.ImageChange(gameObject);
                }
                else
                {
                    AR1C4_BlackboardManager.Instance.IsSelected3 = false;
                    AR1C4_BlackboardManager.Instance.ReturnImage(gameObject);
                }
            }
            if (gameObject.name == "Pic_4")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                if (AR1C4_BlackboardManager.Instance.IsSelected4 == false)
                {
                    AR1C4_BlackboardManager.Instance.IsSelected4 = true;
                    AR1C4_BlackboardManager.Instance.MakeLines();
                    AR1C4_BlackboardManager.Instance.ImageChange(gameObject);
                }
                else
                {
                    AR1C4_BlackboardManager.Instance.IsSelected4 = false;
                    AR1C4_BlackboardManager.Instance.ReturnImage(gameObject);
                }
            }
            if (gameObject.name == "Inst_XBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.ClickInstXBtn();
            }
            if (gameObject.name == "Inst_Answer1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.ClickP();
            }
            if (gameObject.name == "Inst_Answer2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.ClickV();
            }
            if (gameObject.name == "Inst_Answer3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.ClickF();
            }
            if (gameObject.name == "Menu_Answer")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.MenuResult();
            }
            if (gameObject.name == "Suspect_Answer1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.SuspectFail_Z();
            }
            if (gameObject.name == "Suspect_Answer3" || gameObject.name == "Suspect_Answer4")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.SuspectFail();
            }
            if (gameObject.name == "Suspect_Answer2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.SuspectSuccess();
            }
            if (gameObject.name == "Door")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
                AR1C4_MoveManager.Instance.ClickDoor();
            }
            if (gameObject.name == "Quiz2_Submit")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.DoorQuiz2Result();
            }
            if (gameObject.name == "AddSkill")
            {
                AR1C4_MoveManager.Instance.AddSkill();
            }
            if (gameObject.name == "Files_Back")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.ClickFilesBack();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Files_Next")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.ClickFilesNext();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Files_Close")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.ClickFilesReadClose();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Files_Back_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.ClickFilesBack_2();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Files_Next_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.ClickFilesNext_2();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Files_Close_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1C4_MoveManager.Instance.ClickFilesReadClose_2();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
        }
    }
}
