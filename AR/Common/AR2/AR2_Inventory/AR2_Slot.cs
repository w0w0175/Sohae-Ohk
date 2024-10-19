using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class AR2_Slot : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Image image;

    private AR2_Item _item;
    
    public GameObject I_E;
    public GameObject E_button;
    public GameObject DetailImage;
    GameObject arrow_old;

    public Text Title;
    public Text Explain;
    public Text ExplainLong;
    public Text Detail;

    public static bool Openold = false;
    public static bool oldq5 = false;
    public static bool IsGod = false;
    public static bool Ispaper = false;
    public static bool Isplan = false;
    public static bool Isdiary = false;
    public static bool IsScissor = false;
    public static bool IsKey = false;
    public static bool IsCurtain = false;
    public static bool IsC5Old = false;
    public AR2_Item item
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
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        else
        {
            Onclickslot();
        }
    }
    public void Onclickslot()
    {
        if (_item != null)
        {
            I_E.SetActive(true);
            if (AR2_Close.forarrow_old)
            {
                AR2_Close.forarrow_old = false;
                arrow_old = GameObject.Find("ForInventory_Old");
                if (arrow_old.activeSelf)
                {
                    arrow_old.SetActive(false);
                }
            }
            if (GameObject.Find("E_XButton").GetComponent<AR_TouchManager>() == null)
            {
                GameObject.Find("E_XButton").AddComponent<AR_TouchManager>();
            }

            if (item.itemName == "AR2C1_Clover2")
            {
                Title.text = "트럼프 카드 클로버 2";
                ExplainLong.text = "누군가가 실수로, 또는 고의로 잃어버린 카드 한 장.";
                Explain.text = "";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "AR2C1_Dia7")
            {
                Title.text = "트럼프 카드 다이아 7";
                ExplainLong.text = "누군가가 실수로, 또는 고의로 잃어버린 카드 한 장.";
                Explain.text = "";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "AR2C1_Diary")
            {
                Title.text = "아이란의 일기장";
                ExplainLong.text = "아이란의 손때가 묻은 일기장.";
                Explain.text = "";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "AR2C1_Gun")
            {
                Title.text = "수상하게 깨끗한 장총";
                ExplainLong.text = "분명 낡은 나무 상자에 들어 있었는데도" + System.Environment.NewLine + "엄청나게 깨끗하고 새 물건같은 장총.";
                Explain.text = "";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "AR2C1_Heart3")
            {
                Title.text = "트럼프 카드 하트 3";
                ExplainLong.text = "누군가가 실수로, 또는 고의로 잃어버린 카드 한 장.";
                Explain.text = "";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "AR2C1_Key")
            {
                if (AR2C1_MovingManager.Instance.forkey == true)
                {
                    ExplainLong.text = "";
                    Title.text = "열쇠";
                    Explain.text = "램프에서 발견한 열쇠.";
                    E_button.SetActive(true);
                    Detail.text = "사용하기";
                    DetailImage.GetComponent<Image>().sprite = item.itemImage;
                }
                else
                {
                    Title.text = "열쇠";
                    ExplainLong.text = "램프에서 발견한 열쇠.";
                    Explain.text = "";
                    E_button.SetActive(false);
                    DetailImage.GetComponent<Image>().sprite = item.itemImage;
                }
            }
            else if (item.itemName == "AR2C1_Old")
            {
                Title.text = "아주 낡은 예법서";
                ExplainLong.text = "나탈리스 왕국의 귀족이라면 모름지기 지켜야 할 예법들이 적혀 있는 예법서." + System.Environment.NewLine + "하도 낡아서 최신 내용인지 조금 의심스럽다." + System.Environment.NewLine + "확인해야 한다.";
                Explain.text = "";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "AR2C2_Etiq")
            {
                if (AR2C2_MoveManager.Instance.ar2c2 && AR2C2_MoveManager.Instance.plusold)
                {
                    Title.text = "아주 낡은 예법서";
                    ExplainLong.text = "";
                    Explain.text = "나탈리스 왕국의 귀족이라면 모름지기 지켜야 할 예법들이 적혀 있는 예법서.";
                    E_button.SetActive(true);
                    Detail.text = "열어보기";
                    Openold = true;
                    DetailImage.GetComponent<Image>().sprite = item.itemImage;
                }
                else if (AR2C2_MoveManager.Instance.IsPlan && AR2C2_MoveManager.Instance.plusold == false)
                {
                    Title.text = "아주 낡은 예법서";
                    ExplainLong.text = "나탈리스 왕국의 귀족이라면 모름지기 지켜야 할 예법들이 적혀 있는 예법서." + System.Environment.NewLine + "하도 낡아서 최신 내용인지 조금 의심스럽다." + System.Environment.NewLine + "확인해야 한다.";
                    Explain.text = "";
                    E_button.SetActive(false);
                    DetailImage.GetComponent<Image>().sprite = item.itemImage;
                }
            }
            else if (item.itemName == "AR2C4_quette")
            {
                if (AR2C4_MoveManager.Instance.Forquiz5)
                {
                    Title.text = "아주 낡은 예법서";
                    ExplainLong.text = "";
                    Explain.text = "나탈리스 왕국의 귀족이라면 모름지기 지켜야 할 예법들이 적혀 있는 예법서.";
                    E_button.SetActive(true);
                    Detail.text = "열어보기";
                    oldq5 = true;
                    DetailImage.GetComponent<Image>().sprite = item.itemImage;
                }
                else if (AR2C4_MoveManager.Instance.ForGod)
                {
                    AR2C4_MoveManager.Instance.ForGod = false;
                    Title.text = "아주 낡은 예법서";
                    ExplainLong.text = "";
                    Explain.text = "나탈리스 왕국의 귀족이라면 모름지기 지켜야 할 예법들이 적혀 있는 예법서.";
                    E_button.SetActive(true);
                    Detail.text = "자세히 보기";
                    IsGod = true;
                    DetailImage.GetComponent<Image>().sprite = item.itemImage;
                }
                else
                {
                    Title.text = "아주 낡은 예법서";
                    ExplainLong.text = "나탈리스 왕국의 귀족이라면 모름지기 지켜야 할 예법들이 적혀 있는 예법서." + System.Environment.NewLine + "하도 낡아서 최신 내용인지 조금 의심스럽다." + System.Environment.NewLine + "확인해야 한다.";
                    Explain.text = "";
                    E_button.SetActive(false);
                    DetailImage.GetComponent<Image>().sprite = item.itemImage;
                }
            }
            else if (item.itemName == "AR2C1_Spade5")
            {
                Title.text = "트럼프 카드 스페이드 5";
                ExplainLong.text = "누군가가 실수로, 또는 고의로 잃어버린 카드 한 장.";
                Explain.text = "";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "AR2C1_Adopt")
            {
                Title.text = "아이란의 입양 문서";
                ExplainLong.text = "아이란이 입양되었을 때 작성된 문서." + System.Environment.NewLine + "잉크가 손에 묻지 않게 조심하자.";
                E_button.SetActive(true);
                Explain.text = "";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "AR2C2_Spoon")
            {
                Title.text = "은수저";
                ExplainLong.text = "전담 하녀에게 받은 은수저." + System.Environment.NewLine + "순은이라 독을 감지할 수 있다.";
                Explain.text = "";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "AR2C2_Paper")
            {
                Title.text = "문 앞에 놓인 쪽지";
                Explain.text = "누군가 놓고 간 쪽지. 쪽지를 쓴 사람은 아이란을 좋아하는 사람일까, 싫어하는 사람일까?";
                ExplainLong.text = "";
                E_button.SetActive(true);
                Detail.text = "자세히 보기";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                Ispaper = true;
                if (AR2C2_MoveManager.Instance.toQ3)
                {
                    GameObject.Find("arrow1").SetActive(false);
                    GameObject.Find("PaperIntend").transform.Find("BlockClick_Common2").gameObject.SetActive(true);
                    Destroy(GameObject.Find("E_XButton").GetComponent<AR_TouchManager>());
                }
            }
            else if (item.itemName == "AR2C2_Plan")
            {
                if (1 >= AR2C2_MoveManager.Instance.progress)
                {
                    Title.text = "저택 도면도";
                    ExplainLong.text = "예법서에서 떨어진 저택 도면도.\n존스티나 공작가 전체 도면을 볼 수 있다.";
                    Explain.text = "";
                    E_button.SetActive(false);
                    DetailImage.GetComponent<Image>().sprite = item.itemImage;
                }
                else
                {
                    Title.text = "저택 도면도";
                    Explain.text = "예법서에서 떨어진 저택 도면도.\n존스티나 공작가 전체 도면을 볼 수 있다.";
                    ExplainLong.text = "";
                    E_button.SetActive(true);
                    Detail.text = "자세히 보기";
                    Isplan = true;
                    DetailImage.GetComponent<Image>().sprite = item.itemImage;
                }
                
            }
            else if (item.itemName == "AR2C4_Envelope")
            {
                Title.text = "버려진 초대장 봉투";
                ExplainLong.text = "회색 머리카락이 붙어 있는 봉투.";
                Explain.text = "";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "AR2C4_Invation")
            {
                Title.text = "궁정 다과회 초대장";
                ExplainLong.text = "쓰레기통에 버려져 있던 궁정 다과회 초대장.";
                Explain.text = "";
                E_button.SetActive(false);
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
            }
            else if (item.itemName == "AR2C5_Curtain")
            {
                Title.text = "튼튼한 끈";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                if (AR2C5_MoveManager.Instance.IsCurtain)
                {
                    Explain.text = "커튼을 잘라 만든 끈. 아이란 정도의 무게는 충분히 안전하게 감당할 수 있다.";
                    ExplainLong.text = "";
                    E_button.SetActive(true);
                    Detail.text = "사용하기";
                    IsCurtain = true;
                }
               else
                {
                    ExplainLong.text = "커튼을 잘라 만든 끈. 아이란 정도의 무게는 충분히 안전하게 감당할 수 있다.";
                    Explain.text = "";
                    E_button.SetActive(false);
                }
                
                
                
            }
            else if (item.itemName == "AR2C5_Key")
            {
                Title.text = "열쇠";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                if (AR2C5_MoveManager.Instance.IsKey)
                {
                    Explain.text = "샹들리에 사이 숨겨진 열쇠.";
                    ExplainLong.text = "";
                    E_button.SetActive(true);
                    Detail.text = "사용하기";
                    IsKey = true;
                }
                else
                {
                    ExplainLong.text = "샹들리에 사이 숨겨진 열쇠.";
                    Explain.text = "";
                    E_button.SetActive(false);
                }
            }
            else if (item.itemName == "AR2C5_OEQ")
            {
                Title.text = "아주 낡은 예법서";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                if (AR2C5_MoveManager.Instance.OldEnd)
                {
                    ExplainLong.text = "나탈리스 왕국의 귀족이라면 모름지기 지켜야 할 예법들이 적혀 있는 예법서." + System.Environment.NewLine + "하도 낡아서 최신 내용인지 조금 의심스럽다." + System.Environment.NewLine + "확인해야 한다.";
                    Explain.text = "";
                    E_button.SetActive(false);
                }
                else
                {
                    Explain.text = "나탈리스 왕국의 귀족이라면 모름지기 지켜야 할 예법들이 적혀 있는 예법서." + System.Environment.NewLine + "하도 낡아서 최신 내용인지 조금 의심스럽다." + System.Environment.NewLine + "확인해야 한다.";
                    ExplainLong.text = "";
                    E_button.SetActive(true);
                    Detail.text = "자세히 보기";
                    IsC5Old = true;
                }

            }
            else if (item.itemName == "AR2C5_Scissors")
            {
                Title.text = "튼튼한 가위";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                if (AR2C5_MoveManager.Instance.IsCut)
                {
                    Explain.text = "커튼처럼 두꺼운 천도 문제 없이 자를 수 있을 만큼 튼튼하고 날이 날카로운 가위.";
                    ExplainLong.text = "";
                    E_button.SetActive(true);
                    Detail.text = "사용하기";
                    IsScissor = true;
                }
                else
                {
                    
                    ExplainLong.text = "커튼처럼 두꺼운 천도 문제 없이 자를 수 있을 만큼 튼튼하고 날이 날카로운 가위.";
                    Explain.text = "";
                    E_button.SetActive(false);
                    
                }
               
            }
        }
    }
}