using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AR2C3_TouchManager : MonoBehaviour, IPointerClickHandler
{
    
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        else
        {
            if (gameObject.name == "AR2C3_Start")
            {
                AR2C3_MoveManager.Instance.IntroEnd();
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
            }
            if (gameObject.name == "Choice1_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                Text text = gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();

                if (text.text == "일단 밖으로 나간다")
                {
                    AR2C3_MoveManager.Instance.ClickToHallway();
                }
                else if (text.text == "주방으로 가본다")
                {
                    AR2C3_MoveManager.Instance.ClickToKitchen();
                }
                else if (text.text == "방에 가만히 있는다")
                {
                    AR2C3_MoveManager.Instance.ClickToRoom();
                }
                else if (text.text == "테인 존스티나")
                {
                    AR2C3_MoveManager.Instance.ClickFirst();
                }
                else if (text.text == "알렉스 존스티나")
                {
                    AR2C3_MoveManager.Instance.ClickSecond();
                }
            }
            if (gameObject.name == "Choice2_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                Text text = gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();

                if (text.text == "매일 찾아오는 거 좀 부담스러워.")
                {
                    AR2C3_MoveManager.Instance.Room_2_1();
                }
                else if (text.text == "먼저 말을 붙여본다")
                {
                    AR2C3_MoveManager.Instance.Library_1_1();
                }
                else if (text.text == "일단 밖으로 나간다")
                {
                    AR2C3_MoveManager.Instance.ClickToHallway();
                }
                else if (text.text == "주방으로 가본다")
                {
                    AR2C3_MoveManager.Instance.ClickToKitchen();
                }
                else if (text.text == "무시한다")
                {
                    AR2C3_MoveManager.Instance.Kitchen_3_1();
                }
                else if (text.text == "인사한다")
                {
                    AR2C3_MoveManager.Instance.Garden_1_1();
                }
                else if (text.text == "테인 존스티나")
                {
                    AR2C3_MoveManager.Instance.ClickFirst();
                }
                else if (text.text == "그러지 뭐.\n공부야 재밌으니까.")
                {
                    AR2C3_MoveManager.Instance.First_1_1();
                }
                else if (text.text == "말없이 고개를 숙인다")
                {
                    AR2C3_MoveManager.Instance.Second_1_1();
                }
            }
            if (gameObject.name == "Choice2_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                Text text = gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();

                if (text.text == "(부담스럽다는 걸 티내지 않는다.)")
                {
                    AR2C3_MoveManager.Instance.Room_2_2();
                }
                else if (text.text == "각자 책만 읽는다")
                {
                    AR2C3_MoveManager.Instance.Library_1_2();
                }
                else if (text.text == "방에 가만히 있는다")
                {
                    AR2C3_MoveManager.Instance.ClickToRoom();
                }
                else if (text.text == "주방으로 가본다")
                {
                    AR2C3_MoveManager.Instance.ClickToKitchen();
                }
                else if (text.text == "굶었냐고 물어본다")
                {
                    AR2C3_MoveManager.Instance.Kitchen_3_2();
                }
                else if (text.text == "못 본 척 도망친다")
                {
                    AR2C3_MoveManager.Instance.Garden_1_2();
                }
                else if (text.text == "알렉스 존스티나")
                {
                    AR2C3_MoveManager.Instance.ClickSecond();
                }
                else if (text.text == "더 이상 별로\n공부하고 싶지 않아.")
                {
                    AR2C3_MoveManager.Instance.First_1_2();
                }
                else if (text.text == "됐어. 가봤자 무시당해.")
                {
                    AR2C3_MoveManager.Instance.Second_1_2();
                }
            }
            if (gameObject.name == "Choice3_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                Text text = gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();

                if (text.text == "일단 밖으로 나간다")
                {
                    AR2C3_MoveManager.Instance.ClickToHallway();
                }
                else if (text.text == "무슨 일이야?")
                {
                    AR2C3_MoveManager.Instance.Room_1_1();
                }
                else if (text.text == "할 게 없어서 걷는데")
                {
                    AR2C3_MoveManager.Instance.Hallway_1_1();
                }
                else if (text.text == "좋아")
                {
                    AR2C3_MoveManager.Instance.Hallway_2_1();
                }
            }
            if (gameObject.name == "Choice3_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                Text text = gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();

                if (text.text == "주방으로 가본다")
                {
                    AR2C3_MoveManager.Instance.ClickToKitchen();
                }
                else if (text.text == "왜 찾아왔어?")
                {
                    AR2C3_MoveManager.Instance.Room_1_2();
                }
                else if (text.text == "그건 왜?")
                {
                    AR2C3_MoveManager.Instance.Hallway_1_2();
                }
                else if (text.text == "싫어")
                {
                    AR2C3_MoveManager.Instance.Hallway_2_2();
                }
            }
            if (gameObject.name == "Choice3_3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);

                Text text = gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();

                if (text.text == "방에 가만히 있는다")
                {
                    AR2C3_MoveManager.Instance.ClickToRoom();
                }
                else if (text.text == "반가워")
                {
                    AR2C3_MoveManager.Instance.Room_1_3();
                }
                else if (text.text == "......")
                {
                    AR2C3_MoveManager.Instance.Hallway_1_3();
                }
                else if (text.text == "대답하지 않는다")
                {
                    AR2C3_MoveManager.Instance.Hallway_2_3();
                }
            }
            if (gameObject.name == "QuestChoice4_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C3_MoveManager.Instance.LibraryQuestFail();
            }
            if (gameObject.name == "QuestChoice4_2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C3_MoveManager.Instance.LibraryQuestFail();
            }
            if (gameObject.name == "QuestChoice4_3")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C3_MoveManager.Instance.LibraryQuestSuccess();
            }
            if (gameObject.name == "QuestChoice4_4")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C3_MoveManager.Instance.LibraryQuestFail();
            }
            if (gameObject.name == "Quest_Select1")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C3_MoveManager.Instance.kitchenFail();
            }
            if (gameObject.name == "Quest_Select2")
            {
                SoundManager.instance.PlaySFX(Sfx.Click_Button);
                AR2C3_MoveManager.Instance.kitchenSuccess();
            }
            if (gameObject.name == "AddSkill_1")
            {
                SoundManager.instance.PlaySFX(Sfx.Magic_Use);
                AR2C3_MoveManager.Instance.Library_3();
            }
            if (gameObject.name == "OutroClick")
            {
                if (AR2C3_MoveManager.Instance.LastCheck)
                {
                    AR2C3_MoveManager.Instance.TextStart2();
                }
                else
                {
                    AR2C3_MoveManager.Instance.TextStart1();
                }
            }
        }
    }
}
