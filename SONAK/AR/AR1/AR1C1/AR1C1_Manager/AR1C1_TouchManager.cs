using UnityEngine;
using UnityEngine.EventSystems;

public class AR1C1_TouchManager : MonoBehaviour, IPointerClickHandler
{
    Collider2D col;

    bool Cal = false;

    void OnEnable()
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
            if (gameObject.name == "MoveE1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C1_ForBackground.Instance.ClickLeft();
                AR1C1_MovingManager.Instance.MainLeft();
            }
            if (gameObject.name == "MoveE2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C1_MovingManager.Instance.clickagain = 1;
                AR1C1_MovingManager.Instance.MoveFalse();
                AR1C1_MovingManager.Instance.AfterClick();
                AR1C1_ForBackground.Instance.ClickEmptyCase();
                if (AR1C1_MovingManager.Instance.progress == 2)
                {
                    AR1C1_MovingManager.Instance.Q2Again();
                }
            }
            if (gameObject.name == "MoveC2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C1_MovingManager.Instance.clickagain = 2;
                AR1C1_MovingManager.Instance.MoveFalse();
                AR1C1_MovingManager.Instance.AfterClick();
                AR1C1_ForBackground.Instance.Clickbookcase();
            }
            if (gameObject.name == "MoveC1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C1_ForBackground.Instance.ClickRight();
                AR1C1_MovingManager.Instance.MainRight();
            }
            if (gameObject.name == "MoveD")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C1_ForBackground.Instance.ClickDesk();
                AR1C1_MovingManager.Instance.quiz1start = true;
            }
            if (gameObject.name == "BackBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                // 비밀방 확인
                // AR1C1_MovingManager.Secretroom = true;
                if (AR1C1_MovingManager.Instance.NextSecretroom == true)
                {
                    AR1C1_ForBackGround2.Instance.ClicktoMain();
                    AR1C1_MovingManager.Instance.CloseBackBtn();
                    AR1C1_MovingManager.Instance.ClickCal_2();

                }
                else
                {
                    AR1C1_ForBackground.Instance.ClicktoMain();
                    AR1C1_MovingManager.Instance.ToMain();
                    AR1C1_MovingManager.Instance.NotMove();
                }
            }
            if (gameObject.name == "Right")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                if (AR1C1_ForBackground.Instance.formainbg == 3)
                {
                    AR1C1_ForBackground.Instance.ClickEmptyCase();

                    AR1C1_MovingManager.Instance.clickagain = 1;
                }
                if (AR1C1_ForBackground.Instance.formainbg == 5 && AR1C1_ForBackground.Instance.formoving == true)
                {
                    AR1C1_ForBackground.Instance.Clickbookcase();

                    AR1C1_MovingManager.Instance.clickagain = 2;
                }
                if (AR1C1_ForBackground.Instance.formainbg == 4 && AR1C1_ForBackground.Instance.formoving == true)
                {
                    AR1C1_ForBackground.Instance.ClickRight();
                    AR1C1_MovingManager.Instance.MainRight();
                }
            }
            if (gameObject.name == "Left")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                if (AR1C1_ForBackground.Instance.formainbg == 6)
                {
                    AR1C1_ForBackground.Instance.Clickbookcase();

                    AR1C1_MovingManager.Instance.clickagain = 2;
                }
                if (AR1C1_ForBackground.Instance.formainbg == 4 && AR1C1_ForBackground.Instance.formoving == true)
                {
                    AR1C1_ForBackground.Instance.ClickEmptyCase();

                    AR1C1_MovingManager.Instance.clickagain = 1;
                }
                if (AR1C1_ForBackground.Instance.formainbg == 5 && AR1C1_ForBackground.Instance.formoving == true)
                {
                    AR1C1_ForBackground.Instance.ClickLeft();
                    AR1C1_MovingManager.Instance.MainLeft();
                }
                if (AR1C1_MovingManager.Instance.forQ2 == true)
                {
                    AR1C1_MovingManager.Instance.quiz2start = true;
                }
            }
            if (gameObject.name == "ButtonImg")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                AR1C1_MovingManager.Instance.PopupClose();
            }
            if (gameObject.name == "KeyBtn")
            {
                AR1C1_MovingManager.Instance.ClickKey();
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
            }
            if (gameObject.name == "PaperBtn")
            {
                AR1C1_MovingManager.Instance.ClickPaper();
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
            }
            if (gameObject.name == "Q2_CloseBtn")
            {
                AR1_Detail.Instance.AR1C1_PaperClose();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR1_Block.UsingItem = false;
            }
            if (gameObject.name == "CorrectGreen")
            {
                AR1C1_MovingManager.Instance.collectingbooks = 1;
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
                AR1C1_MovingManager.Instance.ClicktoPickBooks();
            }
            if (gameObject.name == "CorrectRed")
            {
                AR1C1_MovingManager.Instance.collectingbooks = 2;
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
                AR1C1_MovingManager.Instance.ClicktoPickBooks();

            }
            if (gameObject.name == "CorrectBlue")
            {
                AR1C1_MovingManager.Instance.collectingbooks = 3;
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
                AR1C1_MovingManager.Instance.ClicktoPickBooks();

            }
            if (gameObject.name == "CorrectPurple")
            {
                AR1C1_MovingManager.Instance.collectingbooks = 4;
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
                AR1C1_MovingManager.Instance.ClicktoPickBooks();

            }
            if (gameObject.name == "Wrong1")
            {
                AR1C1_MovingManager.Instance.collectingbooks = 5;
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
                AR1C1_MovingManager.Instance.ClicktoPickBooks();

            }
            if (gameObject.name == "Wrong2")
            {
                AR1C1_MovingManager.Instance.collectingbooks = 6;
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
                AR1C1_MovingManager.Instance.ClicktoPickBooks();

            }
            if (gameObject.name == "Wrong3")
            {
                AR1C1_MovingManager.Instance.collectingbooks = 7;
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
                AR1C1_MovingManager.Instance.ClicktoPickBooks();

            }
            if (gameObject.name == "Wrong4")
            {
                AR1C1_MovingManager.Instance.collectingbooks = 8;
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
                AR1C1_MovingManager.Instance.ClicktoPickBooks();

            }
            if (gameObject.name == "Wrong5")
            {
                AR1C1_MovingManager.Instance.collectingbooks = 9;
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
                AR1C1_MovingManager.Instance.ClicktoPickBooks();

            }
            if (gameObject.name == "Wrong6")
            {
                AR1C1_MovingManager.Instance.collectingbooks = 10;
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
                AR1C1_MovingManager.Instance.ClicktoPickBooks();

            }
            if (gameObject.name == "Q2_CancelBtn")
            {
                AR1C1_MovingManager.Instance.ReturnBooks();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Q2_PutBtn")
            {
                AR1C1_MovingManager.Instance.AnswerBooks();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "AR1C1_S_Paper")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C1_ForBackGround2.Instance.ClickPaper();
            }
            if (gameObject.name == "AR1C1_Calendar")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C1_ForBackGround2.Instance.ClickCalendar();
                if (!Cal)
                {
                    Cal = true;
                    AR1C1_MovingManager.Instance.ClickCalendar();
                }
                else
                {
                    AR1C1_MovingManager.Instance.ClickCal_1();
                }
            }
            if (gameObject.name == "AR1C1_Map")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C1_ForBackGround2.Instance.ClickMap();
                if (AR1C1_MovingManager.Instance.Q5Around == true)
                {
                    AR1C1_MovingManager.Instance.ClicktoMap_final();
                }
                else
                {
                    AR1C1_MovingManager.Instance.ClickToMap();
                }

            }
            if (gameObject.name == "AR1C1_Confidential")
            {
                AR1C1_ForBackGround2.Instance.ClickConfidential();
                SoundManager.instance.PlaySFX(Sfx.Item_Pickup);
                if (AR1C1_ForBackGround2.Instance.forQ4Confidential == true)
                {
                    AR1C1_ForBackGround2.Instance.forQ4Confidential = false;
                    AR1C1_MovingManager.Instance.ClicktoConfidential();
                }
            }
            if (gameObject.name == "Q5_Text1")
            {
                AR1C1_MovingManager.Instance.ClicktoMap_1();
            }
            if (gameObject.name == "Q5_Text2")
            {
                AR1C1_MovingManager.Instance.LastText();
            }
            if (gameObject.name == "Click_Map")
            {
                AR1C1_MovingManager.Instance.ClickToMap();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Q3_Skill_Btn")
            {
                AR1C1_MovingManager.Instance.Q3BtnClick();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Q3_OpenBtn")
            {
                AR1C1_MovingManager.Instance.EndSkill();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "AppleButton")
            {
                AR1C1_MovingManager.Instance.ClickApple();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "BananaButton")
            {
                AR1C1_MovingManager.Instance.ClickBanana();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "CreamButton")
            {
                AR1C1_MovingManager.Instance.ClickCream();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "DoughnutButton")
            {
                AR1C1_MovingManager.Instance.ClickDoughnut();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Scientia")
            {
                AR1C1_MovingManager.Instance.ClickScientia();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Medium")
            {
                AR1C1_MovingManager.Instance.ClickMedium();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Religio")
            {
                AR1C1_MovingManager.Instance.ClickReligio();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Fimbria")
            {
                AR1C1_MovingManager.Instance.ClickFimbria();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Q5_MapBtn")
            {
                AR1C1_ForBackGround2.Instance.ClicktoMain();
                AR1C1_MovingManager.Instance.Q5LookAround();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Q5_Select")
            {
                AR1C1_MovingManager.Instance.Q5Answer();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Q5_Return")
            {
                AR1C1_MovingManager.Instance.Q5Return();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

            }
            if (gameObject.name == "Mys_Close")
            {
                AR1_Detail.Instance.AR1C1_MysPaper_Close();
                AR1_Block.UsingItem = false;
            }
            if (gameObject.name == "Con_Close")
            {
                AR1_Detail.Instance.AR1C1_Confidential_Close();
                AR1_Block.UsingItem = false;
            }
            if (gameObject.name == "Clickempty")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C1_MovingManager.Instance.MainEmptycase();
                AR1C1_MovingManager.Instance.CheckCorrectBook();
            }
            if (gameObject.name == "Clickbookcase")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_UI);

                AR1C1_MovingManager.Instance.MainBookcase();
            }
        }
    }
}