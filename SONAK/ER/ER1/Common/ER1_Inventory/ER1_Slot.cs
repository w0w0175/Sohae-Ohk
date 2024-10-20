using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ER1_Slot : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Image image;

    private ER1_Item _item;

    public GameObject I_E;
    public GameObject E_button;
    public GameObject DetailImage;

    public Text Title;
    public Text Explain;
    public Text E_text;
    public Text ExplainLong;

    public static bool kettleuse = false;
    public static bool wateruse = false;
    public static bool woodsuse = false;
    public static bool fooduse = false;
    public static bool medaluse = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        else
        {
            OnclickSlot();
        }
    }

    public ER1_Item item
    {
        get { return _item; }
        set
        {
            _item = value;

            if (_item != null)
            {
                image.sprite = item.itemImage;
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }
    public void OnclickSlot()
    {
        
        if (_item != null)
        {
            I_E.SetActive(true);

            if (item.itemName == "ER1C1_Meat")
            {
                Title.text = "고기";
                Explain.text = "";
                ExplainLong.text = "방금 받은 신선한 고기.";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "ER1C1_Honey")
            {
                Title.text = "꿀";
                Explain.text = "";
                ExplainLong.text = "벌집에서 직접 채취한 야생 꿀.";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "ER1C1_Gloves")
            {
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                if (ER1C1_MovingManager.Instance.Istree)
                {
                    if (ER1C1_MovingManager.Instance.forGloves == true) //&& ER1_DialogueManager.isDialogue == false)
                    {
                        ExplainLong.text = "";
                        Title.text = "장갑";
                        Explain.text = "에르덴투야가 늘 들고다니는 장갑.";
                        E_button.SetActive(true);
                        E_text.text = "사용하기";
                    }
                    else
                    {
                        Title.text = "장갑";
                        Explain.text = "";
                        ExplainLong.text = "에르덴투야가 늘 들고다니는 장갑.";
                        E_button.SetActive(false);
                    }
                }
                else
                {
                    Title.text = "장갑";
                    Explain.text = "";
                    ExplainLong.text = "에르덴투야가 늘 들고다니는 장갑.";
                    E_button.SetActive(false);
                }
            }
            else if (item.itemName == "ER1C1_Ladder")
            {
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                if (ER1C1_MovingManager.Instance.UsingLadder)
                {
                    ExplainLong.text = "";
                    Title.text = "사다리";
                    Explain.text = "어느 집 뒷편에서 발견한 사다리.";
                    E_button.SetActive(true);
                    E_text.text = "사용하기";
                }
                else
                {
                    Title.text = "사다리";
                    Explain.text = "";
                    ExplainLong.text = "어느 집 뒷편에서 발견한 사다리.";
                    E_button.SetActive(false);
                }
            }
            else if (item.itemName == "ER1C1_Bird")
            {
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                Title.text = "새모이";
                Explain.text = "";
                ExplainLong.text = "엄청 평범한 새모이.";
                E_button.SetActive(false);
            }
            else if (item.itemName == "ER1C2_Food")
            {
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                Title.text = "음식";
                
                if (ER1C2_MoveManager.Instance.KitRight && ER1C2_MoveManager.Instance.UseFood)
                {
                    ExplainLong.text = "";
                    Explain.text = "스튜를 끓이기 위한 여러 가지 재료.";
                    E_button.SetActive(true);
                    E_text.text = "사용하기";
                    fooduse = true;
                }
                else
                {
                    Explain.text = "";
                    ExplainLong.text = "스튜를 끓이기 위한 여러 가지 재료.";
                    E_button.SetActive(false);
                }
            }
            else if (item.itemName == "ER1C2_Kettle")
            {
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                if (ER1C2_MoveManager.Instance.GetWater)
                {
                    Title.text = "물주전자";
                    Explain.text = "선반에서 발견한 물주전자.\n도자기라서 다소 무겁다.";
                    ExplainLong.text = "";
                    E_button.SetActive(true);
                    E_text.text = "사용하기";
                    kettleuse = true;
                }
                else
                {
                    if (ER1C2_MoveManager.Instance.GotWater)
                    {
                        Title.text = "물이 든 물주전자";
                        if (ER1C2_MoveManager.Instance.KitRight && ER1C2_MoveManager.Instance.UseWater && ER1C2_MoveManager.Instance.FireEnd)
                        {
                            Explain.text = "선반에서 발견한 물주전자.\n도자기라서 다소 무겁다.\n안에 물이 들어있다.";
                            ExplainLong.text = "";
                            E_button.SetActive(true);
                            E_text.text = "사용하기";
                            wateruse = true;
                        }
                        else
                        {
                            Explain.text = "";
                            ExplainLong.text = "선반에서 발견한 물주전자.\n도자기라서 다소 무겁다.\n안에 물이 들어있다.";
                            E_button.SetActive(false);
                        }
                    }
                    else
                    {
                        Title.text = "물주전자";
                        Explain.text = "";
                        ExplainLong.text = "선반에서 발견한 물주전자.\n도자기라서 다소 무겁다.";
                        E_button.SetActive(false);
                    }
                }
            }
            else if (item.itemName == "ER1C2_Woods")
            {
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                Title.text = "바싹 마른 나뭇가지";
                if (ER1C2_MoveManager.Instance.KitRight)
                {
                    ExplainLong.text = "";
                    Explain.text = "장작으로 활용하기 좋다.";
                    E_button.SetActive(true);
                    E_text.text = "사용하기";
                    woodsuse = true;
                }
                else
                {
                    Explain.text = "";
                    ExplainLong.text = "장작으로 활용하기 좋다.";
                    E_button.SetActive(false);
                }
            }
            else if (item.itemName == "ER1C3_Medal")
            {
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                Title.text = "낡은 메달";
                ExplainLong.text = "";
                Explain.text = "운동대회에서 받은 메달. 에르덴투야는 못생기고 불편하다고 생각해서 그냥 마을 회관에 걸어두었다.";
                E_button.SetActive(true);
                E_text.text = "자세히 보기";
                medaluse = true;
            }
        }
    }
}