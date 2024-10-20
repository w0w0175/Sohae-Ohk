using UnityEngine;
using UnityEngine.EventSystems;

public class ER1C1_TouchManager : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        else
        {
            if (gameObject.name == "BackBtn")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                ER1C1_MovingManager.Instance.ClicktoMain();
                if (ER1C1_MovingManager.Instance.forHill)
                {
                    ER1C1_BackgroundManager.Instance.ClickMain();
                }
                else
                {
                    ER1C1_BackgroundManager2.Instance.ClickMain();
                }

            }
            if (gameObject.name == "Choice2_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (ER1C1_MovingManager.Instance.forRock)
                {
                    ER1C1_MovingManager.Instance.Rock_2_1();
                }
                if (ER1C1_MovingManager.Instance.forCave)
                {
                    ER1C1_MovingManager.Instance.Inside_1();
                }
                if (ER1C1_MovingManager.Instance.forPB)
                {
                    ER1C1_MovingManager.Instance.Bird_3_1();
                }
                if (ER1C1_MovingManager.Instance.forGrandpa)
                {
                    ER1C1_MovingManager.Instance.Grandpa_1_1();
                }

            }
            if (gameObject.name == "Choice2_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (ER1C1_MovingManager.Instance.forRock)
                {
                    ER1C1_MovingManager.Instance.Rock_2_2();
                }
                if (ER1C1_MovingManager.Instance.forCave)
                {
                    ER1C1_MovingManager.Instance.Inside_2();
                }
                if (ER1C1_MovingManager.Instance.forPB)
                {
                    ER1C1_MovingManager.Instance.Bird_3_2();
                }
                if (ER1C1_MovingManager.Instance.forGrandpa)
                {
                    ER1C1_MovingManager.Instance.Grandpa_1_2();
                }
            }
            if (gameObject.name == "Choice3_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (ER1C1_MovingManager.Instance.forPB)
                {
                    ER1C1_MovingManager.Instance.Bird_3_2_2_1();
                }
            }
            if (gameObject.name == "Choice3_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (ER1C1_MovingManager.Instance.forPB)
                {
                    ER1C1_MovingManager.Instance.Bird_3_2_2_2();
                }
            }
            if (gameObject.name == "Choice3_3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                if (ER1C1_MovingManager.Instance.forPB)
                {
                    ER1C1_MovingManager.Instance.Bird_3_2_2_3();
                }
            }
            if (gameObject.name == "BlackSheep_Click")
            {
                ER1C1_MovingManager.Instance.ClickRockAfter();
                ER1C1_BackgroundManager.Instance.ClickRock();
            }
            if (gameObject.name == "BlackSheep")
            {
                ER1C1_MovingManager.Instance.ClickBlack();
            }
            if (gameObject.name == "GetGreen")
            {
                ER1C1_MovingManager.Instance.ClickGetGreen();
            }
            if (gameObject.name == "Rock_Before")
            {
                ER1C1_MovingManager.Instance.ClickRock();
                ER1C1_BackgroundManager.Instance.ClickRock();
            }
            if (gameObject.name == "GreenSheep")
            {
                if (!ER1C1_MovingManager.Instance.gsheep)
                {
                    ER1C1_MovingManager.Instance.ClickGreenSheep();
                }
                else
                {
                    ER1C1_MovingManager.Instance.ClickGreenSheepAfter();
                }
                ER1C1_BackgroundManager.Instance.ClickGreenSheep();
            }
            if (gameObject.name == "ED_Skill_Add")
            {
                SoundManager.instance.PlaySFX(Sfx.Magic_Use);

                ER1C1_MovingManager.Instance.AddSkill();
            }
            if (gameObject.name == "PinkSheep")
            {
                ER1C1_MovingManager.Instance.ClickPinkSheep();
                ER1C1_BackgroundManager.Instance.ClickPinkSheep();
            }
            if (gameObject.name == "PinkBird")
            {
                ER1C1_MovingManager.Instance.ClickPinkBird();
                ER1C1_BackgroundManager.Instance.ClickPinkBird();
            }
            if (gameObject.name == "ToLakeandCave")
            {
                ER1C1_MovingManager.Instance.ClickLakeandCave();
            }
            if (gameObject.name == "C_Honey")
            {
                ER1C1_MovingManager.Instance.ClickHoney();
                ER1C1_BackgroundManager2.Instance.ClickHoney();
            }
            if (gameObject.name == "C_Cave")
            {
                ER1C1_MovingManager.Instance.ClickCave();
                ER1C1_BackgroundManager2.Instance.ClickCave();
            }
            if (gameObject.name == "C_Picture")
            {
                ER1C1_MovingManager.Instance.ClickPicture();
                ER1C1_BackgroundManager2.Instance.ClickPicture();
            }
            if (gameObject.name == "C_Inside")
            {
                ER1C1_MovingManager.Instance.ClickInside();
                ER1C1_BackgroundManager2.Instance.ClickInside();
                Debug.Log("anjwl");
            }
            if (gameObject.name == "C_Lake")
            {
                ER1C1_MovingManager.Instance.ClickLake();
                ER1C1_BackgroundManager2.Instance.ClickLake();
            }
            if (gameObject.name == "ToHill")
            {
                ER1C1_MovingManager.Instance.StartHill();
            }
            if (gameObject.name == "Cliff_Explain")
            {
                ER1C1_MovingManager.Instance.ClickCliffExplain();
            }
            if (gameObject.name == "Cliff_GameE")
            {
                ER1C1_MovingManager.Instance.ClickCliffGameExplain();
            }
            if (gameObject.name == "C_Cottonsheep")
            {
                ER1C1_MovingManager.Instance.ClickCottonSheep();
            }
            if (gameObject.name == "C_SleepingG")
            {
                ER1C1_MovingManager.Instance.ClickGrandpa();
            }
            if (gameObject.name == "C_Ladder")
            {
                ER1C1_MovingManager.Instance.ClickLadder();
            }
            if (gameObject.name == "C_White")
            {
                ER1C1_MovingManager.Instance.ClickWhiteSheep();
            }
        }
    }
}
