using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AR1_DetailBlock1 : MonoBehaviour, IPointerClickHandler
{
    public Text ExBtnText;
    public GameObject Inv_Block;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (gameObject.name == "E_Button") // 서류보기
        {
            if(ExBtnText.text == "사용하기" || ExBtnText.text == "분해하기" || ExBtnText.text == "자세히 보기")
            {
                Inv_Block.SetActive(false);
            }
            else if (AR2C2_MoveManager.Instance != null)
            {
                if (AR2C2_MoveManager.Instance.ar2c2)
                {
                    if (ExBtnText.text == "열어보기")
                    {
                        Inv_Block.SetActive(false);
                    }
                } 
            }
            else if (AR1C4_MoveManager.Instance != null)
            {
                if (ExBtnText.text == "자세히 보기")
                {
                    Inv_Block.SetActive(false);
                }
            }
            else if (AR2C5_MoveManager.Instance != null)
            {
                if (ExBtnText.text == "자세히 보기")
                {
                    Inv_Block.SetActive(false);
                }
            }
            else
            {
                Inv_Block.SetActive(true); Debug.Log("혹시 인벤토리가 작동하지 않나요? 연락 주세요.");
            }
        }
    }
}