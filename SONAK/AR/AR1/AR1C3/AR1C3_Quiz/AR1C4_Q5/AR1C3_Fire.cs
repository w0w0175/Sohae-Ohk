using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AR1C3_Fire : MonoBehaviour, IDropHandler
{
    public GameObject WW;
    public GameObject AA;
    public GameObject BW;
    public GameObject BA;
    public GameObject Blockfire;

    public static bool iswdrop = false;
    public static bool isadrop = false;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (AR1C3_Amoving.Amove == true)
            {
                AR1C3_Amoving.Amove = false;
                BA.SetActive(false);
                AA.SetActive(true);
                Blockfire.SetActive(true);
                
                AR1C3_Q5Manager.Instance.ARInfrontofFire();
                isadrop = true;
            }
            else if (AR1C3_Wmoving.Wmove == true)
            {
                AR1C3_Wmoving.Wmove = false;
                WW.SetActive(true);
                BW.GetComponent<RectTransform>().anchoredPosition = new Vector2(-351.25f, 447);

                iswdrop = true;
                Color color = BW.GetComponent<Image>().color;
                color.a = 0;
                BW.GetComponent<Image>().color = color;

                AR1C3_Q5Manager.Instance.WInfrontofFire();
            }  
        }
    }
}