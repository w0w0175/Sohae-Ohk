using UnityEngine;
using UnityEngine.UI;

public class AR1_Block : MonoBehaviour
{
    public static bool UsingItem;

    public GameObject BI;
    public GameObject inventory;

    void Update()
    {
        if (UsingItem)
        {
            BI.SetActive(true);
            Color color = inventory.GetComponent<Image>().color;
            color = new Color32(150, 150, 150, 255);
            inventory.GetComponent<Image>().color = color;
        }
        else
        {
            BI.SetActive(false);
            Color color = inventory.GetComponent<Image>().color;
            color = new Color32(255, 255, 255, 255);
            inventory.GetComponent<Image>().color = color;
        }
    }
}
