using UnityEngine;
using UnityEngine.UI;

public class AR1_Detail : MonoBehaviour
{
    public static AR1_Detail Instance;

    public GameObject HeartKey;
    public GameObject DiaKey;
    public GameObject Answer1;
    public GameObject Answer2;
    public GameObject Answer3;
    public GameObject Inventory;
    public GameObject Explain;
    public GameObject Q2Content;
    public GameObject w1;
    public GameObject w2;
    public GameObject w3;
    public GameObject w4;
    public GameObject w5;
    public GameObject w6;
    public GameObject cblue;
    public GameObject cgreen;
    public GameObject cred;
    public GameObject cpurple;
    public GameObject KeyAnswer;
    public GameObject UsingKey;
    public GameObject MysPaper;
    public GameObject Confidential;
    public GameObject BlockInven;
    public GameObject Black;
    public GameObject Files_1;
    public GameObject Files_2;

    public Text ExBtnText;

    public int whatkey = 0;
    public bool partkey = false;
    public static bool cb, cr, cp, cg, w11, w22, w33, w44, w55, w66 = false;

    bool Q2Texk = false;


    void Awake()
    {
        whatkey = 0;
        partkey = false;
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void ClicktoUse()
    {
        SoundManager.instance.PlaySFX(Sfx.Click_Button);
        if (AR1_Slot.fordetail > 9)
        {
            AR1C3_KeyUse();
            Inventory.SetActive(false);
            AR1_Block.UsingItem = true;
        }
        else
        {
            AR1_Slot.fordetail = 0;
            partkey = true;
            Explain.SetActive(false);
        }
        if (AR1C1_MovingManager.Instance != null)
        {
            if (AR1C1_MovingManager.Instance.forpaper == true || AR1_Slot.ispaper == true)
            {
                AR1_Slot.ispaper = false;
                AR1C1_Paper();
                Inventory.SetActive(false);
                AR1_Block.UsingItem = true;
            }
            if (AR1C1_MovingManager.Instance.forQ2 == true && ExBtnText.text == "사용하기")
            {
                AR1C1_Quiz2();
                Inventory.SetActive(false);
                AR1_Block.UsingItem = true;
            }
            if (AR1C1_MovingManager.Instance.forkey == true && ExBtnText.text == "사용하기")
            {
                AR1C1_Key();
                Inventory.SetActive(false);
                AR1_Block.UsingItem = true;
            }
        }
        if (AR1_Slot.confidential == true)
        {
            AR1_Slot.confidential = false;
            AR1C1_Confidential();
            Inventory.SetActive(false);
            AR1_Block.UsingItem = true;
        }
        if (AR1_Slot.myspaper == true)
        {
            AR1_Slot.myspaper = false;
            AR1C1_MysPaper();
            Inventory.SetActive(false);
            AR1_Block.UsingItem = true;
        }
        if (AR1_Slot.files)
        {
            AR1_Slot.files = false;
            Inventory.SetActive(false);
            AR1_Block.UsingItem = true;
            if (AR1C4_MoveManager.Instance.filechange)
            {
                Files_2.SetActive(true);
                Files_1.SetActive(false);
            }
            else
            {
                Files_1.SetActive(true);
            }
        }
        if (AR1_Slot.note)
        {
            AR1_Slot.note = false;
            AR1C0_MoveManager.Instance.ViewNote();
            Inventory.SetActive(false);
        }
    }
    public void AR1C3_KeyUse()
    {
        Answer1.SetActive(true);
        Answer2.SetActive(true);
        Answer3.SetActive(true);
        if (AR1_Slot.dia && AR1_Slot.fordetail == 12)
        {
            AR1_Slot.dia = false;
            AR1_Slot.fordetail = 0;
            DiaKey.SetActive(true);
            DiaKey.transform.localPosition = new Vector2(-0, -400);
            whatkey = 100;
            BlockInven.SetActive(true);
        }
        else if (AR1_Slot.heart && AR1_Slot.fordetail == 10)
        {
            AR1_Slot.heart = false;
            AR1_Slot.fordetail = 0;
            HeartKey.SetActive(true);
            HeartKey.transform.localPosition = new Vector2(-0, -400);
            whatkey = 200;
            BlockInven.SetActive(true);
        }
    }

    public void AR1C1_Paper()
    {
        AR1C1_MovingManager.Instance.forpaper = false;
        AR1C1_MovingManager.Instance.MybagClose();
        Q2Content.SetActive(!false);
    }
    public void AR1C1_PaperClose()
    {
        Q2Content.SetActive(false);

        if (!Q2Texk)
        {
            Q2Texk = true;

            GameObject.Find("AR1C1_9").GetComponent<AR1_InteractionController>().Text();
        }
    }
    public void AR1C1_Quiz2()
    {
        AR1_Block.UsingItem = true;
        if (AR1_Slot.Putnum == 1)
        {
            w1.SetActive(true);
            w1.transform.localPosition = new Vector2(-0, -400);
            w1.tag = "UsedBook";
            w11 = true;
            if (w1.GetComponent<AR1_Moving>() == null)
            {
                w1.AddComponent<AR1_Moving>();
            }
        }
        if (AR1_Slot.Putnum == 2)
        {
            w2.SetActive(true);
            w2.transform.localPosition = new Vector2(-0, -400);
            w2.tag = "UsedBook";
            w22 = true;
            if (w2.GetComponent<AR1_Moving>() == null)
            {
                w2.AddComponent<AR1_Moving>();
            }
        }
        if (AR1_Slot.Putnum == 3)
        {
            w3.SetActive(true);
            w3.transform.localPosition = new Vector2(-0, -400);
            w3.tag = "UsedBook";
            w33 = true;
            if (w3.GetComponent<AR1_Moving>() == null)
            {
                w3.AddComponent<AR1_Moving>();
            }
        }
        if (AR1_Slot.Putnum == 4)
        {
            w4.SetActive(true);
            w4.transform.localPosition = new Vector2(-0, -400);
            w4.tag = "UsedBook";
            w44 = true;
            if (w4.GetComponent<AR1_Moving>() == null)
            {
                w4.AddComponent<AR1_Moving>();
            }
        }
        if (AR1_Slot.Putnum == 5)
        {
            w5.SetActive(true);
            w5.transform.localPosition = new Vector2(-0, -400);
            w5.tag = "UsedBook";
            w55 = true;
            if (w5.GetComponent<AR1_Moving>() == null)
            {
                w5.AddComponent<AR1_Moving>();
            }
        }
        if (AR1_Slot.Putnum == 6)
        {
            w6.SetActive(true);
            w6.transform.localPosition = new Vector2(-0, -400);
            w6.tag = "UsedBook";
            w66 = true;
            if (w6.GetComponent<AR1_Moving>() == null)
            {
                w6.AddComponent<AR1_Moving>();
            }
        }
        if (AR1_Slot.Putnum == 7)
        {
            cblue.SetActive(true);
            cblue.transform.localPosition = new Vector2(-0, -400);
            cblue.tag = "UsedBook";
            cb = true;
            if (cblue.GetComponent<AR1_Moving>() == null)
            {
                cblue.AddComponent<AR1_Moving>();
            }
        }
        if (AR1_Slot.Putnum == 8)
        {
            cgreen.SetActive(true);
            cgreen.transform.localPosition = new Vector2(-0, -400);
            cgreen.tag = "UsedBook";
            cg = true;
            if (cgreen.GetComponent<AR1_Moving>() == null)
            {
                cgreen.AddComponent<AR1_Moving>();
            }
        }
        if (AR1_Slot.Putnum == 9)
        {
            cpurple.SetActive(true);
            cpurple.transform.localPosition = new Vector2(-0, -400);
            cpurple.tag = "UsedBook";
            cp = true;
            if (cpurple.GetComponent<AR1_Moving>() == null)
            {
                cpurple.AddComponent<AR1_Moving>();
            }
        }
        if (AR1_Slot.Putnum == 10)
        {
            cred.SetActive(true);
            cred.transform.localPosition = new Vector2(-0, -400);
            cred.tag = "UsedBook";
            cr = true;
            if (cred.GetComponent<AR1_Moving>() == null)
            {
                cred.AddComponent<AR1_Moving>();
            }
        }
    }
    public void AR1C1_Key()
    {
        KeyAnswer.SetActive(true);
        UsingKey.SetActive(true);
        UsingKey.transform.localPosition = new Vector2(-0, -400);
        AR1_Block.UsingItem = true;
    }
    public void AR1C1_Confidential()
    {
        Black.SetActive(true);
        Confidential.SetActive(true);
    }
    public void AR1C1_Confidential_Close()
    {
        Black.SetActive(false);
        Confidential.SetActive(false);
    }
    public void AR1C1_MysPaper()
    {
        MysPaper.SetActive(true);
    }
    public void AR1C1_MysPaper_Close()
    {
        MysPaper.SetActive(false);
    }

}
