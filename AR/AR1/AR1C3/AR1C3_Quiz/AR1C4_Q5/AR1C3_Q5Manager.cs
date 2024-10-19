using System.Collections;
using UnityEngine;

public class AR1C3_Q5Manager : MonoBehaviour
{
    public static AR1C3_Q5Manager Instance;

    public GameObject Q5;
    public GameObject fire;
    public GameObject power;
    public GameObject SkillQ5;
    public GameObject Skill5FX;
    public GameObject Icon;

    public bool Q5Again = false;
    bool IsArfire = false;
    bool IsWpower = false;

    void Update()
    {
        /*if (AR1C3_Wmoving.IsWomanSuccess == 1)
        {
            AR1C3_Wmoving.IsWomanSuccess = 0;
        }
        if (AR1C3_Wmoving.IsWomanSuccess == 2)
        {
            AR1C3_Wmoving.IsWomanSuccess = 0;
        }*/
    }
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        IsArfire = false;
        IsWpower = false;
    }
    public void ARInfrontofFire() //아이란을 화로 앞에 배치했을 때
    {
        IsArfire = true; fire.SetActive(false);

        GameObject.Find("AR1C3_27").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q5SkillUsed()
    {
        SkillQ5.SetActive(true);
    }
    public void Q5SkillEffect()
    {
        SkillQ5.SetActive(false);
        Q5.SetActive(false);
        Skill5FX.SetActive(true);
        Icon.SetActive(false);
        SoundManager.instance.PlaySFX(Sfx.Magic_Use);

        Invoke("Q5SkillEffect_1", 4.5f);
    }
    public void Q5SkillEffect_1()
    {
        Icon.SetActive(true);
        Skill5FX.SetActive(false);
        Q5.SetActive(true);
        GameObject.Find("AR1C3_28").GetComponent<AR1_InteractionController>().Text();
    }
    public void ARInfrontofPower() //아이란이 도르래 앞에 있을 때
    {
        GameObject.Find("AR1C3_30").GetComponent<AR1_InteractionController>().Text();
    }
    public void WInfrontofPower() //증인을 도르래 앞에 뒀을 때
    {
        IsWpower = true; power.SetActive(false);

        GameObject.Find("AR1C3_29").GetComponent<AR1_InteractionController>().Text();
    }
    public void WInfrontofFire() // 증인 화로
    {
        GameObject.Find("AR1C3_31").GetComponent<AR1_InteractionController>().Text();
    }
    public void Q5Check()
    {
        AR1_Manager.Instance.DisableHintButton();
        if (IsWpower == true && IsArfire == true)
        {
            Q5Success();
        }
        else
        {
            GameObject.Find("AR1C3_26").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void Q5Success()
    {
        GameObject.Find("AR1C3_32").GetComponent<AR1_InteractionController>().Text();
        AR1C3_MoveManager.Instance.AR1C3_outro();
    }
}