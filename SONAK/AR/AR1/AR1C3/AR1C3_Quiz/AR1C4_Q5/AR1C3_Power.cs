using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AR1C3_Power : MonoBehaviour, IDropHandler
{
    public GameObject AW;
    public GameObject WA;
    public GameObject BW;
    public GameObject BA;
    public GameObject Q5_1;
    public GameObject Q5_2;
    Color color;

    public static bool iswdrop = false;
    public static bool isadrop = false;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Q5_1.SetActive(false);
            Q5_2.SetActive(true);

            if (AR1C3_Amoving.Amove == true)
            {
                AR1C3_Amoving.Amove = false;
                WA.SetActive(true);
                //BA.SetActive(false);
                BA.GetComponent<RectTransform>().anchoredPosition = new Vector2(-351.25f, 447);

                color = BA.GetComponent<Image>().color;
                color.a = 0;
                BA.GetComponent<Image>().color = color;

                BW.GetComponent<RectTransform>().anchoredPosition = new Vector2(-358, -153.74f);
                isadrop = true;
                AR1C3_Q5Manager.Instance.ARInfrontofPower();
            }
            else if (AR1C3_Wmoving.Wmove == true)
            {
                AR1C3_Wmoving.Wmove = false;
                AW.SetActive(true);
                BW.SetActive(false);

                iswdrop = true;
                AR1C3_Q5Manager.Instance.WInfrontofPower();
            }

        }
    }
}