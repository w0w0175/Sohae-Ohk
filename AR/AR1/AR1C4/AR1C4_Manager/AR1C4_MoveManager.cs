using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using System.Collections;
using System.Reflection;

public class AR1C4_MoveManager : MonoBehaviour
{
    public static AR1C4_MoveManager Instance;
    public Timer timer;

    public TMP_Text MainText;
    public TMP_Text tx;

    public TMP_InputField IF_1;
    public TMP_InputField IF_2;
    public TMP_InputField IF_3;
    public TMP_InputField IF_4;
    public TMP_InputField Quiz2;

    public string writerText = "";

    public GameObject OpeningTitle;
    public GameObject Black;
    public GameObject Intro;
    public GameObject Bar;
    public GameObject Bar_Glass;
    public GameObject Icon;
    public GameObject CE_Bar;
    public GameObject GlassNote;
    public GameObject WineQuiz;
    public GameObject InstQuiz;
    public GameObject MenuQuiz;
    public GameObject Wine_Big;
    public GameObject BbQuiz;
    public GameObject SuspectQuiz;
    public GameObject Factory;
    public GameObject CE_Factory;
    public GameObject DoorQuiz;
    public GameObject Factory_door;
    public GameObject DoorQ2;
    public GameObject FactoryOffice;
    public GameObject Skill_S;
    public GameObject Skill_FX;
    public GameObject J_Office;
    public GameObject Village;
    public GameObject Files_Contents;
    public GameObject Files_C1;
    public GameObject Files_C2;
    public GameObject Files_C3;
    public GameObject Files_C4;
    public GameObject Files_Back;
    public GameObject Files_Next;
    public GameObject Files_Contents_2;
    public GameObject Files_C1_2;
    public GameObject Files_C2_2;
    public GameObject Files_C3_2;
    public GameObject Files_C4_2;
    public GameObject Files_Back_2;
    public GameObject Files_Next_2;

    public bool GlassCheck = false;
    public bool BBCheck = false;
    public bool DoorCheck = false;
    public bool GlassesEnd = false;
    public bool filechange = false;

    public int progress = 0;

    bool SuspectEnd = false;

    bool TextCheck = false;
    bool IntroCheck = false;

    int ForFiles = 0;
    int ForFiles_2 = 0;
    int Num = 0;

    int[] AR1C4_time = new int[] { 9, 0 };

    public EventTrigger TxtBtn;
    private EventTrigger.Entry entry;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    void Update()
    {
        if (GlassCheck)
        {
            GlassCheck = false;
            Invoke("GlassesSuccess", 1f);
        }
        if (BBCheck)
        {
            BBCheck = false;
            Invoke("BbSuccess", 1f);
        }
        if (DoorCheck)
        {
            DoorCheck = false;
            if (DoorCheck)
            {
                DoorCheck = false;
            }
            Invoke("DoorSuccess", 0.2f);
        }

        if (Num == 4)
        {
            Num = -1;

            entry.callback.RemoveAllListeners();
            entry.callback.AddListener(ExplainEnd);
        }
    }
    void OnDisable()
    {
        AR1_Slot.files = false;
        progress = 0;
    }
    public void TimeStart()
    {
        timer.StartTimer(AR1C4_time[0], AR1C4_time[1]);
    }
    public void ChapterStart()
    {
        MainText.text = "정보상, 핌브리아 거리";
        Intro.SetActive(false);
        Icon.SetActive(true);
        CE_Bar.SetActive(true);

        TimeStart();

        GameObject.Find("AR1C4_1").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickGlasses()
    {
        if (GlassesEnd && progress != 1)
        {
            SoundManager.instance.PlaySFX(Sfx.Glass_1);
            SoundManager.instance.PlaySFX(Sfx.Glass_4);
            SoundManager.instance.PlaySFX(Sfx.Glass_8);

            GameObject.Find("AR1C4_2").GetComponent<AR1_InteractionController>().Text();
        }
        else if (progress == 1)
        {
            Black.SetActive(true);
            InstQuiz.SetActive(true);
            CE_Bar.SetActive(false);
        }
        else
        {
            GameObject.Find("AR1C4_26").GetComponent<AR1_InteractionController>().Text();

            CE_Bar.SetActive(false);
            Black.SetActive(true);
            WineQuiz.SetActive(true);
            AR1_Manager.Instance.EnableHintButton(18);
            // AR1_Block.UsingItem = true;
        }
    }
    public void GlassesSuccess()
    {
        Black.SetActive(false);
        WineQuiz.SetActive(false);
        GlassesEnd = true;
        AR1_Manager.Instance.DisableHintButton();
        // AR1_Block.UsingItem = false;

        GameObject.Find("AR1C4_3").GetComponent<AR1_InteractionController>().Text();
    }
    public void Instrumental()
    {
        Black.SetActive(true);
        InstQuiz.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(19);
        progress = 1;
    }
    public void ClickV()
    {
        Black.SetActive(false);
        InstQuiz.SetActive(false);
        AR1_Manager.Instance.DisableHintButton();
        SoundManager.instance.PlaySFX(Sfx.Violin);

        GameObject.Find("AR1C4_6").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickP()
    {
        Black.SetActive(false);
        InstQuiz.SetActive(false);
        AR1_Manager.Instance.DisableHintButton();

        GameObject.Find("AR1C4_4").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickF()
    {
        Black.SetActive(false);
        InstQuiz.SetActive(false);
        AR1_Manager.Instance.DisableHintButton();

        GameObject.Find("AR1C4_5").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickInstXBtn()
    {
        Black.SetActive(false);
        InstQuiz.SetActive(false);
        CE_Bar.SetActive(true);
    }
    public void InstAgain()
    {
        Black.SetActive(true);
        InstQuiz.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(19);
    }
    public void MenuStart()
    {
        Black.SetActive(true);
        MenuQuiz.SetActive(true);
        progress = 2;

        AR1_Manager.Instance.EnableHintButton(22);
    }
    public void MenuResult()
    {
        if (IF_1.text == "" || IF_2.text == "" || IF_3.text == "" || IF_4.text == "")
        {
            return;
        }
        else
        {
            Wine_Big.SetActive(true);
            Black.SetActive(false);
            MenuQuiz.SetActive(false);

            if (IF_1.text.ToUpper() == "OEY" && IF_2.text.ToUpper() == "DRU" && IF_3.text.ToUpper() == "ONSTIN" && IF_4.text.ToUpper() == "TRUT")
            {
                GameObject.Find("AR1C4_8").GetComponent<AR1_InteractionController>().Text();
            }
            else
            {
                GameObject.Find("AR1C4_7").GetComponent<AR1_InteractionController>().Text();
            }

            AR1_Manager.Instance.DisableHintButton();
        }
    }
    public void MenuAgain()
    {
        Wine_Big.SetActive(false);
        Black.SetActive(true);
        MenuQuiz.SetActive(true);
        IF_1.text = "";
        IF_2.text = "";
        IF_3.text = "";
        IF_4.text = "";
        AR1_Manager.Instance.EnableHintButton(22);
    }
    public void Menu_1()
    {
        Wine_Big.SetActive(false);
        GameObject.Find("AR1C4_8 (1)").GetComponent<AR1_InteractionController>().Text();
    }
    public void MenuEnd()
    {
        Bar_Glass.SetActive(true);
        CE_Bar.SetActive(true);
        GlassNote.SetActive(true);
        if (SuspectEnd)
        {
            Invoke("FactoryStart", 0.5f);
        }
    }
    public void ClickGlassNote()
    {
        CE_Bar.SetActive(false);
        Bar.transform.localScale = new Vector2(2, 2);
        Bar.GetComponent<RectTransform>().anchoredPosition = new Vector2(589, 524);
        filechange = true;

        GameObject.Find("AR1C4_9").GetComponent<AR1_InteractionController>().Text();
    }
    public void GlassNote_1()
    {
        Black.SetActive(true);
        BbQuiz.SetActive(true);

        GameObject.Find("AR1C4_10").GetComponent<AR1_InteractionController>().Text();
    }
    public void BbSuccess()
    {
        Black.SetActive(false);
        BbQuiz.SetActive(false);
        Bar.transform.localScale = new Vector2(1, 1);
        Bar.GetComponent<RectTransform>().anchoredPosition = new Vector2(80, 0);

        GameObject.Find("AR1C4_11").GetComponent<AR1_InteractionController>().Text();
    }
    public void SuspectStart()
    {
        SuspectQuiz.SetActive(true);
        progress = 3;
    }
    public void SuspectSuccess()
    {
        Black.SetActive(false);
        SuspectQuiz.SetActive(false);

        GameObject.Find("AR1C4_14").GetComponent<AR1_InteractionController>().Text();
    }
    public void Suspectfinish()
    {
        CE_Bar.SetActive(true);
        SuspectEnd = true;
    }
    public void SuspectFail()
    {
        GameObject.Find("AR1C4_13").GetComponent<AR1_InteractionController>().Text();
    }
    public void SuspectFail_Z()
    {
        GameObject.Find("AR1C4_12").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickChair()
    {
        CE_Bar.SetActive(false);
        Bar.GetComponent<RectTransform>().anchoredPosition = new Vector2(-183, 1093);
        Bar.transform.localScale = new Vector2(2, 2);
        GameObject.Find("AR1C4_27").GetComponent<AR1_InteractionController>().Text();
    }
    public void Chair_1()
    {
        CE_Bar.SetActive(true);
        Bar.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        Bar.transform.localScale = new Vector2(1, 1);
    }
    public void FactoryStart()
    {
        Bar.SetActive(false);
        CE_Bar.SetActive(false);
        Factory.SetActive(true);
        CE_Factory.SetActive(true);
        MainText.text = "마도공학 연구 공장, 지하";

        GameObject.Find("AR1C4_15").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickDoor()
    {
        CE_Factory.SetActive(false);
        Black.SetActive(true);
        DoorQuiz.SetActive(true);
        AR1_Manager.Instance.EnableHintButton(20);
    }
    public void DoorSuccess()
    {
        Black.SetActive(false);
        DoorQuiz.SetActive(false);
        Invoke("DoorSuccess_1", 0.01f);
        AR1_Manager.Instance.DisableHintButton();
    }
    public void DoorSuccess_1()
    {
        GameObject.Find("AR1C4_16").GetComponent<AR1_InteractionController>().Text();
    }
    public void DoorQuiz2()
    {
        Factory_door.SetActive(true);

        GameObject.Find("AR1C4_17").GetComponent<AR1_InteractionController>().Text();
    }
    public void DoorQuiz2_1()
    {
        Factory.transform.localScale = new Vector2(3, 3);
        Factory.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 474);
        DoorQ2.SetActive(true);
        progress = 4;
        AR1_Manager.Instance.EnableHintButton(21);
    }
    public void DoorQuiz2Result()
    {
        AR1_Manager.Instance.DisableHintButton();
        if (Quiz2.text == "3")
        {
            DoorQ2.SetActive(false);
            Factory.transform.localScale = new Vector2(1, 1);
            Factory.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);

            GameObject.Find("AR1C4_18").GetComponent<AR1_InteractionController>().Text();
        }
        else
        {
            DoorQ2.SetActive(false);
            GameObject.Find("AR1C4_19").GetComponent<AR1_InteractionController>().Text();
            SoundManager.instance.PlaySFX(Sfx.Security_Alarm);
        }
    }
    public void Door2Again()
    {
        DoorQ2.SetActive(true);
        Quiz2.text = "";
        AR1_Manager.Instance.EnableHintButton(21);
    }
    public void OfficeStart()
    {
        Factory.SetActive(false);
        CE_Factory.SetActive(false);
        FactoryOffice.SetActive(true);
        MainText.text = "공장주의 사무실";

        GameObject.Find("AR1C4_20").GetComponent<AR1_InteractionController>().Text();
    }
    public void SkillStart()
    {
        Skill_S.SetActive(true);
    }
    public void AddSkill()
    {
        Skill_S.SetActive(false);

        GameObject.Find("AR1C4_21").GetComponent<AR1_InteractionController>().Text();
    }
    public void UseSkill()
    {
        Icon.SetActive(false);
        Skill_FX.SetActive(true);

        SoundManager.instance.PlaySFX(Sfx.Magic_Use);

        Invoke("AfterSkill", 8.5f);
    }
    public void AfterSkill()
    {
        Icon.SetActive(true);

        GameObject.Find("AR1C4_22").GetComponent<AR1_InteractionController>().Text();
    }
    public void StartExplain() // 아웃트로 시작
    {
        entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        TxtBtn.triggers.Add(entry);

        Icon.SetActive(false);

        Factory_door.SetActive(false);
        OpeningTitle.SetActive(true);

        entry.callback.RemoveAllListeners();
        entry.callback.AddListener(TextStart);

        IntroCheck = true;
        StartCoroutine(TextArr1());
    }
    IEnumerator _typing(string narration)
    {
        bool t_white = false, t_beige = false;
        bool t_ignore = false;

        writerText = "";

        for (int i = 0; i < narration.Length; i++)
        {
            if (TextCheck)
            {
                TextCheck = false;

                tx.text = Allcontexts(narration);

                break;
            }
            else
            {
                switch (narration[i])
                {
                    case 'ⓦ': t_white = true; t_beige = false; t_ignore = true; break;
                    case 'ⓑ': t_white = false; t_beige = true; t_ignore = true; break;
                }

                string t_letter = narration[i].ToString();

                if (!t_ignore)
                {
                    if (t_white) { t_letter = "<color=#FFFFFF>" + t_letter + "</color>"; }
                    else if (t_beige) { t_letter = "<color=#E9CDBD>" + t_letter + "</color>"; }

                    writerText += t_letter;
                    tx.text = writerText;
                }
                t_ignore = false;

                yield return new WaitForSeconds(0.1f);
            }
        }
        Num++; IntroCheck = false;
    }

    string Allcontexts(string narration)
    {
        string AllText = narration;
        AllText = AllText.Replace("@", ",");
        AllText = AllText.Replace("\\n", "\n");
        AllText = AllText.Replace("\"", "");
        AllText = AllText.Replace("ⓡ", "<color=#FF0000>");
        AllText = AllText.Replace("ⓦ", "</color>");
        AllText = AllText.Replace("ⓑ", "<color=#E9CDBD>");
        AllText = AllText.Replace("ⓘ", "<i>");

        return AllText;
    }

    IEnumerator TextArr1()
    {
        yield return StartCoroutine(_typing("공장주 나탈리는\n마약에 중독되어 이성을 잃었고,\n가루를 만드는 실험과 관련된\n모든 내용을 순순히 자백했습니다."));
        // yield return StartCoroutine(_typing("1"));
    }

    void TextStart(BaseEventData p)
    {
        if (IntroCheck && !TextCheck)
        {
            TextCheck = true;
        }

        if (Num == 1 && !IntroCheck)
        {
            IntroCheck = true;

            StartCoroutine(TextArr2());
        }
        else if (Num == 2 && !IntroCheck)
        {
            IntroCheck = true;

            StartCoroutine(TextArr3());
        }
        else if (Num == 3 && !IntroCheck)
        {
            IntroCheck = true;

            StartCoroutine(TextArr4());
        }
    }

    IEnumerator TextArr2()
    {
        yield return StartCoroutine(_typing("아이란은 경찰들에게\n명령하여 공장주의\n재산을 몰수하였고,\n해당 재산을 사용하여\n피해자의 유족에게\n보상금을 지급하였습니다."));
        // yield return StartCoroutine(_typing("2"));
    }

    IEnumerator TextArr3()
    {
        yield return StartCoroutine(_typing("다만..."));
        // yield return StartCoroutine(_typing("2"));
    }

    IEnumerator TextArr4()
    {
        yield return StartCoroutine(_typing("나탈리가 푸른 가루를\n연구하게끔 지원하고,\n푸른 가루를 제 3황자파에만\n퍼뜨린 배후가 누구인지는\n도저히 밝혀낼 수 없었습니다."));
        // yield return StartCoroutine(_typing("2"));
    }

    void ExplainEnd(BaseEventData p) // 아웃트로 끝
    {
        tx.text = "";

        OpeningTitle.SetActive(false);

        entry.callback.RemoveAllListeners();
        TxtBtn.triggers.Remove(entry);

        FactoryOffice.SetActive(false);
        J_Office.SetActive(true);
        Icon.SetActive(true);
        MainText.text = "존스티나 공작령, 특수 사건 전담 사무소";

        GameObject.Find("AR1C4_23").GetComponent<AR1_InteractionController>().Text();
    }
    public void Office_1()
    {
        J_Office.SetActive(false);
        Village.SetActive(true);

        GameObject.Find("AR1C4_24").GetComponent<AR1_InteractionController>().Text();
    }
    public void Office_2()
    {
        Village.SetActive(false);
        J_Office.SetActive(true);

        GameObject.Find("AR1C4_25").GetComponent<AR1_InteractionController>().Text();
    }
    public void ClickFilesBack()
    {
        if (ForFiles == 1)
        {
            ForFiles = 0;
            Files_C1.SetActive(true);
            Files_C2.SetActive(false);
            Files_Back.SetActive(false);

        }
        else if (ForFiles == 2)
        {
            ForFiles = 1;
            Files_C2.SetActive(true);
            Files_C3.SetActive(false);

        }
        else
        {
            ForFiles = 2;
            Files_C3.SetActive(true);
            Files_C4.SetActive(false);
            Files_Next.SetActive(true);

        }
    }
    public void ClickFilesNext()
    {
        if (ForFiles == 0)
        {
            ForFiles = 1;
            Files_C1.SetActive(false);
            Files_C2.SetActive(true);
            Files_Back.SetActive(true);
        }
        else if (ForFiles == 1)
        {
            ForFiles = 2;
            Files_C2.SetActive(false);
            Files_C3.SetActive(true);
        }
        else
        {
            ForFiles = 3;
            Files_C3.SetActive(false);
            Files_C4.SetActive(true);
            Files_Next.SetActive(false);
        }
    }
    public void ClickFilesReadClose()
    {
        Files_Contents.SetActive(false);
        AR1_Block.UsingItem = false;
    }
    public void ClickFilesBack_2()
    {
        if (ForFiles_2 == 1)
        {
            ForFiles_2 = 0;
            Files_C1_2.SetActive(true);
            Files_C2_2.SetActive(false);
            Files_Back_2.SetActive(false);

        }
        else if (ForFiles_2 == 2)
        {
            ForFiles_2 = 1;
            Files_C2_2.SetActive(true);
            Files_C3_2.SetActive(false);

        }
        else
        {
            ForFiles_2 = 2;
            Files_C3_2.SetActive(true);
            Files_C4_2.SetActive(false);
            Files_Next_2.SetActive(true);

        }
    }
    public void ClickFilesNext_2()
    {
        if (ForFiles_2 == 0)
        {
            ForFiles_2 = 1;
            Files_C1_2.SetActive(false);
            Files_C2_2.SetActive(true);
            Files_Back_2.SetActive(true);
        }
        else if (ForFiles_2 == 1)
        {
            ForFiles_2 = 2;
            Files_C2_2.SetActive(false);
            Files_C3_2.SetActive(true);
        }
        else
        {
            ForFiles_2 = 3;
            Files_C3_2.SetActive(false);
            Files_C4_2.SetActive(true);
            Files_Next_2.SetActive(false);
        }
    }
    public void ClickFilesReadClose_2()
    {
        Files_Contents_2.SetActive(false);
        AR1_Block.UsingItem = false;
    }
}
