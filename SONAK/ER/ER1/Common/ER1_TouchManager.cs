using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ER1_TouchManager : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        else
        {
            if (gameObject.name == "XBUTTON")
            {
                ER1_Close.Instance.ClickInventoryClose();
            }
            if (gameObject.name == "E_XButton")
            {
                ER1_Close.Instance.ClickExplainClose();
            }
            if (gameObject.name == "E_Button")
            {
                ER1_Detail.Instance.ClicktoUse();
            }
            if (gameObject.name == "IconBag")
            {
                ER1_Close.Instance.ClickInventoryOpen();
            }
        }
    }
}
