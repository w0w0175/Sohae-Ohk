using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class AR_TouchManager : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (gameObject.name == "E_Button")
        {
            if (AR1_Manager.IsAR1 == true)
            {
                gameObject.GetComponent<AR1_Detail>().ClicktoUse();
            }
            else
            {
                gameObject.GetComponent<AR2_Detail>().ClicktoEButton();
            }
        }
        if (gameObject.name == "IconBag")
        {
            if (AR1_Manager.IsAR1)
            {
                if (AR1C1_MovingManager.Instance != null)
                {
                    if (AR1C1_MovingManager.Instance.firstclick)
                    {
                        AR1C1_MovingManager.Instance.MyBagClick();
                        AR1_OpenClose.Instance.ClicktoOpen();
                    }
                    else
                    {
                        AR1_OpenClose.Instance.ClicktoOpen();
                    }
                }
                else
                {
                    AR1_OpenClose.Instance.ClicktoOpen();
                }
            }
            else if (AR2C4_MoveManager.Instance != null)
            {
                if (AR2C4_MoveManager.Instance.Forquiz5)
                {
                    AR2C4_MoveManager.Instance.BQ5_1();
                    AR2_Close.Instance.ClickInventoryOpen();
                }
                else
                {
                    AR2_Close.Instance.ClickInventoryOpen();
                }
            }
            else
            {
                AR2_Close.Instance.ClickInventoryOpen();
            }

        }
        if (gameObject.name == "E_XButton")
        {
            if (AR1_Manager.IsAR1 == true)
            {
                AR1_OpenClose.Instance.ClicktoCloseEx();
            }
            else
            {
                AR2_Close.Instance.ClickExplainClose();
            }
        }
        if (gameObject.name == "XBUTTON")
        {
            if (AR1_Manager.IsAR1 == true)
            {
                AR1_OpenClose.Instance.ClicktoCloseInven();
            }
            else
            {
                AR2_Close.Instance.ClickInventoryClose();
            }
        }
        if (gameObject.name == "E_XButton")
        {
            if (AR1_Manager.IsAR1 == true)
            {
                AR1_OpenClose.Instance.ClicktoCloseEx();
            }
            else
            {
                AR2_Close.Instance.ClickExplainClose();
            }
        }
    }
}