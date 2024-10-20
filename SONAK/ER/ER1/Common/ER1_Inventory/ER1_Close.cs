using UnityEngine;
using UnityEngine.UI;

public class ER1_Close : MonoBehaviour
{
    public static ER1_Close Instance;

    public GameObject I_E;
    public GameObject Inventory;
    public GameObject BlockInven;

    public bool UsingItem = false;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }
    void OnEnable()
    {
        UsingItem = false;
    }

    void Update()
    {
        if (UsingItem)
        {
            BlockInven.SetActive(true);
            Color color = gameObject.GetComponent<Image>().color;
            color = new Color32(150, 150, 150, 255);
            gameObject.GetComponent<Image>().color = color;
        }
        else
        {
            BlockInven.SetActive(false);
            Color color = gameObject.GetComponent<Image>().color;
            color = new Color32(255, 255, 255, 255);
            gameObject.GetComponent<Image>().color = color;
        }
    }
    public void ClickExplainClose()
    {
        I_E.SetActive(false);
        ER1_Slot.kettleuse = false;
        ER1_Slot.woodsuse = false;
        ER1_Slot.fooduse = false;
        ER1_Slot.medaluse = false;
        SoundManager.instance.PlaySFX(Sfx.Click_Button);
    }

    public void ClickInventoryClose()
    {
        Inventory.SetActive(false);
        SoundManager.instance.PlaySFX(Sfx.Click_Button);
    }
    public void ClickInventoryOpen()
    {
        Inventory.SetActive(true);
        I_E.SetActive(false);
        SoundManager.instance.PlaySFX(Sfx.Inventory_Open);
    }
}