using UnityEngine;
using UnityEngine.EventSystems;

public class AR2C4_TouchManager : MonoBehaviour, IPointerClickHandler
{
    Collider2D col;

    bool QCheck = false;

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
            if (gameObject.name == "AR2C4_Chandelier")
            {
                AR2C4_BackgroundManager.Instance.ClickChandelier();
                AR2C4_MoveManager.Instance.ClickChandelier();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Trash")
            {
                AR2C4_BackgroundManager.Instance.ClickTrash();
                AR2C4_MoveManager.Instance.ClickTrash();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Bookcase")
            {
                AR2C4_MoveManager.Instance.ClickBookcase();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "BackBtn")
            {
                AR2C4_BackgroundManager.Instance.ClicktoMain();
                AR2C4_MoveManager.Instance.BackBtnFalse();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "FC_Quest_Answer1")
            {
                AR2C4_MoveManager.Instance.ClickButler();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "FC_Quest_Answer2")
            {
                AR2C4_MoveManager.Instance.ClickMaid();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "FC_Back")
            {
                AR2C4_BackgroundManager.Instance.ClicktoMain();
                AR2C4_MoveManager.Instance.ClickFC_Close();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "G_Quest_Answer1")
            {
                AR2C4_MoveManager.Instance.ChoiceGodSuccess();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "G_Quest_Answer2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C4_MoveManager.Instance.GodFail2();
            }
            if (gameObject.name == "G_Quest_Answer3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C4_MoveManager.Instance.GodFail3();
            }
            if (gameObject.name == "G_Quest_Answer4")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C4_MoveManager.Instance.GodFail4();
            }
            if (gameObject.name == "Fail_2")
            {
                AR2C4_MoveManager.Instance.GodFail_2_1();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Fail_3")
            {
                AR2C4_MoveManager.Instance.GodFail_3_1();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Fail_4")
            {
                AR2C4_MoveManager.Instance.GodFail_4_1();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "God_Success")
            {
                AR2C4_MoveManager.Instance.GodSuceess_2();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "G_Back")
            {
                AR2C4_BackgroundManager.Instance.ClicktoMain();
                AR2C4_MoveManager.Instance.ClickG_Close();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "AR2C4_Longbox")
            {
                AR2C4_MoveManager.Instance.ClickLongBox();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Firstright")
            {
                AR2C4_MoveManager.Instance.ClickFirstRight();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Firstleft")
            {
                AR2C4_MoveManager.Instance.ClickFirstLeft();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Secondleft")
            {
                AR2C4_MoveManager.Instance.ClickSecondLeft();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Secondright")
            {
                AR2C4_MoveManager.Instance.ClickSecondRight();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Thirdbox")
            {
                AR2C4_MoveManager.Instance.ClickThirdBox();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Thirdleft")
            {
                AR2C4_MoveManager.Instance.ClickThirdLeft();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Thirdright")
            {
                AR2C4_MoveManager.Instance.ClickThirdRight();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Q3_Before_1")
            {
                AR2C4_MoveManager.Instance.Quiz3_1();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Q3_Before_2")
            {
                AR2C4_MoveManager.Instance.Quiz3_2();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Q3_Before_3")
            {
                AR2C4_MoveManager.Instance.Quiz3_3();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Q3_Next_1")
            {
                AR2C4_MoveManager.Instance.Quiz3_2();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Q3_Next_2")
            {
                AR2C4_MoveManager.Instance.Quiz3_3();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Q3_Next_3")
            {
                AR2C4_MoveManager.Instance.Quiz3_4();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Q3_Submit")
            {
                gameObject.GetComponent<AR2C4_Quiz3Result>().Q3Result();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "B_Close")
            {
                AR2C4_MoveManager.Instance.BookContent_Close();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Letter")
            {
                AR2C4_MoveManager.Instance.ClickLetter();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Old_Close")
            {
                AR2_Detail.Instance.Old_Q5_Close();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR2C4_MoveManager.Instance.Forquiz5)
                {
                    AR2C4_MoveManager.Instance.BQ5_2();
                }
            }
            if (gameObject.name == "PresentBox")
            {
                AR2C4_MoveManager.Instance.Quiz5Start();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "Q5_Submit")
            {
                AR2C4_MoveManager.Instance.Q5Result();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Content_Close")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (!QCheck)
                {
                    QCheck = true;
                    AR2C4_MoveManager.Instance.progress++;
                }

                if (!AR2C4_MoveManager.Instance.Q2Out)
                {
                    AR2C4_MoveManager.Instance.ChoiceGodmother();
                }

                AR2_Detail.Instance.CloseoldforGod();
            }
            if (gameObject.name == "Q4_Submit")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (AR2C4_Quiz4.Q4)
                {
                    AR2C4_MoveManager.Instance.Q4Success();
                }
                else
                {
                    AR2C4_MoveManager.Instance.Q4Fail();
                }

            }
            if (gameObject.name == "UpperLocker")
            {
                GameObject go = GameObject.Find("AR2C4_Hidden");
                AR2C4_MoveManager.Instance.BoxResult();
                go.GetComponent<AR2C1_LockerSolved>().OnClickUpperLocker();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Clover")
            {
                gameObject.GetComponent<AR2C1_ForLocker>().ClickNums();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Heart")
            {
                gameObject.GetComponent<AR2C1_ForLocker>().ClickNums();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Dia")
            {
                gameObject.GetComponent<AR2C1_ForLocker>().ClickNums();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "AR2C4_Spade")
            {
                gameObject.GetComponent<AR2C1_ForLocker>().ClickNums();
                SoundManager.instance.PlaySFX(Sfx.Click_UI);
            }
            if (gameObject.name == "QuizFindC")
            {
                AR2C4_MoveManager.Instance.CriminalAgain();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "QuizGod")
            {
                AR2C4_MoveManager.Instance.GodAgain();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
        }
    }

}
