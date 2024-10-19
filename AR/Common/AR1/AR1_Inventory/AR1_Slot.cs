using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AR1_Slot : MonoBehaviour, IPointerClickHandler
{

    public static AR1_Slot instance;

    private AR1_Item _item;

    [SerializeField] Image image;

    public GameObject Inventory;
    public GameObject Explain;
    public GameObject ExBtn;
    public GameObject DetailImage;

    public Text TitleText;
    public Text ExText;
    public Text ExLong;
    public Text ExBtnText;

    public GameObject Quiz2Content;
   
    public GameObject Q3Paper;
    public GameObject Q4Paper;

    public static int Putnum;
    public static int fordetail = 0;

    public static bool dia = false;           // AR1C3
    public static bool heart = false;         // AR1C3
    public static bool confidential = false;
    public static bool myspaper = false;
    public static bool ispaper = false;
    public static bool files = false;
    public static bool note = false;
    void Awake()
    {
        confidential = false;
        myspaper = false;
        dia = false;
        heart = false;
        ispaper = false;

        if (instance == null)
            instance = this;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        else
        {
            OnClickSlot();
            if (AR1C1_MovingManager.Instance != null)
            {
                if (AR1C1_MovingManager.Instance.firstclick == true)
                {
                    AR1C1_MovingManager.Instance.firstclick = false;
                    AR1C1_MovingManager.Instance.MybagOk();
                }
            }
            
        }
    }
    public AR1_Item item
    {
        get 
        { 
            return _item; 
        }
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

    public void OnClickSlot()
    {
        if (_item != null)
        {
            Explain.SetActive(true);

            if (item.itemName == "AR1C1_KEY")
            {
                TitleText.text = "교수의 열쇠";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                if (AR1C1_MovingManager.Instance.forkey == true)
                {
                    ExText.text = "교수의 책상에서 발견한 열쇠.\n어떤 문을 열 수 있는 걸까?";
                    ExLong.text = "";
                    ExBtn.SetActive(true);
                    ExBtnText.text = "사용하기";
                }
                else
                {
                    ExText.text = "";
                    ExLong.text = "교수의 책상에서 발견한 열쇠.\n어떤 문을 열 수 있는 걸까?";
                    ExBtn.SetActive(false);
                }
            }

            if (item.itemName == "AR1C1_PAPERS")
            {
                TitleText.text = "수상한 서류";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                ExText.text = "알쏭달쏭 수수께끼가 적혀있는 서류.\n이런 서류가 사무실에 있다니, 수상하다.";
                ExBtnText.text = "서류 보기";
                ExLong.text = "";
                ispaper = true;
                ExBtn.SetActive(true);

            }
            if (item.itemName == "AR1C1_CorrectBlue")
            {
                TitleText.text = "푸른 책";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                if (AR1C1_MovingManager.Instance.Q2Around == true && AR1C1_MovingManager.Instance.checkbooks < 4)
                {
                    ExText.text = "파랑새의 깃털이 이런 색일까?\n고급스러운 느낌의 푸른 책.";
                    ExLong.text = "";
                    ExBtn.SetActive(true);
                    ExBtnText.text = "사용하기";

                    Putnum = 7;
                }
                else
                {
                    ExText.text = "";
                    ExLong.text = "파랑새의 깃털이 이런 색일까?\n고급스러운 느낌의 푸른 책.";
                    ExBtn.SetActive(false);
                }
            }

            if (item.itemName == "AR1C1_CorrectGreen")
            {
                TitleText.text = "초록 책";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                if (AR1C1_MovingManager.Instance.Q2Around == true && AR1C1_MovingManager.Instance.checkbooks < 4)
                {
                    ExText.text = "이렇게 짙은 초록빛이라니.\n녹음이 짙게 깔린 듯한 책";
                    ExLong.text = "";
                    ExBtn.SetActive(true);
                    ExBtnText.text = "사용하기";
                    Putnum = 8;
                }
                else
                {
                    ExText.text = "";
                    ExLong.text = "이렇게 짙은 초록빛이라니.\n녹음이 짙게 깔린 듯한 책";
                    ExBtn.SetActive(false);
                }
            }

            if (item.itemName == "AR1C1_CorrectPurple")
            {
                TitleText.text = "보라 책";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;

                if (AR1C1_MovingManager.Instance.Q2Around == true && AR1C1_MovingManager.Instance.checkbooks < 4)
                {
                    ExText.text = "와인처럼 짙은 보라색 책.\n무슨 내용의 책일까?";
                    ExLong.text = "";
                    ExBtn.SetActive(true);
                    ExBtnText.text = "사용하기";
                    Putnum = 9;
                }
                else
                {
                    ExText.text = "";
                    ExLong.text = "와인처럼 짙은 보라색 책.\n무슨 내용의 책일까?";
                    ExBtn.SetActive(false);
                }
            }

            if (item.itemName == "AR1C1_CorrectRed")
            {
                TitleText.text = "붉은 책";            
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                if (AR1C1_MovingManager.Instance.Q2Around == true && AR1C1_MovingManager.Instance.checkbooks < 4)
                {
                    ExText.text = "짙은 붉은빛의 책.\n푹 익어 가장 달콤한 앵두같다.";
                    ExLong.text = "";
                    ExBtn.SetActive(true);
                    ExBtnText.text = "사용하기";
                    Putnum = 10;
                }
                else
                {
                    ExText.text = "";
                    ExLong.text = "짙은 붉은빛의 책.\n푹 익어 가장 달콤한 앵두같다.";
                    ExBtn.SetActive(false);
                }
            }

            for (int i = 1; i < 7; i++)
            {
                if (item.itemName == "AR1C1_Wrong" + i)
                {
                    TitleText.text = "평범한 책";
                    DetailImage.GetComponent<Image>().sprite = item.itemImage;

                    if (AR1C1_MovingManager.Instance.Q2Around == true && AR1C1_MovingManager.Instance.checkbooks < 4)
                    {
                        ExText.text = "아주 평범한 책.\n던지면 무기로 쓸 수 있다.";
                        ExLong.text = "";
                        ExBtn.SetActive(true);
                        ExBtnText.text = "사용하기";
                        Putnum = i;
                    }
                    else
                    {
                        ExText.text = "";
                        ExLong.text = "아주 평범한 책.\n던지면 무기로 쓸 수 있다.";
                        ExBtn.SetActive(false);
                    }
                }
            }

            if (item.itemName == "AR1C1_Confidential")
            {
                TitleText.text = "빼돌려진 수사일지";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                if (AR1C1_MovingManager.Instance.Q3Clear == true)
                {
                    ExLong.text = "";
                    ExText.text = "복사본도 아니고 원본이다.\n아이란 열받는 소리가 들리는 기분...";
                    ExBtnText.text = "서류 보기";
                    ExBtn.SetActive(true);
                    confidential = true;

                }
                else
                {
                    ExLong.text = "복사본도 아니고 원본이다.\n아이란 열받는 소리가 들리는 기분...";
                    ExText.text = "";
                    ExBtn.SetActive(false);
                }
            }

            if (item.itemName == "AR1C1_MysteriousPaper")
            {
                TitleText.text = "글씨가 나타난 종이";
                ExText.text = "비밀스러운 편지가 적혀있는 종이.\n왜 이 편지를 읽지 못했을지 궁금하다.";
                ExBtnText.text = "종이 보기";
                ExLong.text = "";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                ExBtn.SetActive(true);
                myspaper = true;
            }

            if (item.itemName == "AR1C3_DiaKey")
            {
                TitleText.text = "다이아 모양 열쇠";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                if (AR1C3_MoveManager.Instance.ForQ4)
                {
                    ExText.text = "열쇠 꾸러미에서 발견한 다이아 모양 열쇠.";
                    ExLong.text = "";
                    ExBtnText.text = "사용하기";
                    ExBtn.SetActive(true);
                    dia = true;
                    fordetail = 12;
                }
                else
                {
                    ExLong.text = "열쇠 꾸러미에서 발견한 다이아 모양 열쇠.";
                    ExText.text = "";
                    ExBtn.SetActive(false);
                }
            }

            if (item.itemName == "AR1C3_HeartKey")
            {
                TitleText.text = "하트 열쇠";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                if (AR1C3_MoveManager.Instance.ForQ4)
                {
                    ExText.text = "열쇠 꾸러미에서 발견한 하트 모양 열쇠.";
                    ExBtnText.text = "사용하기";
                    ExLong.text = "";
                    ExBtn.SetActive(true);

                    heart = true;
                    fordetail = 10;
                }
                else
                {
                    ExLong.text = "열쇠 꾸러미에서 발견한 하트 모양 열쇠.";
                    ExText.text = "";
                    ExBtn.SetActive(false);
                }  
            }

            if (item.itemName == "AR1C3_Keys")
            {
                TitleText.text = "열쇠 꾸러미";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                if (AR1C3_MoveManager.Instance.UsingKeys && AR1C3_MoveManager.Instance.progress == 4)
                {
                    ExText.text = "은신처에서 발견한 열쇠 꾸러미.";
                    ExBtnText.text = "분해하기";
                    ExLong.text = "";
                    ExBtn.SetActive(true);
                    fordetail = 2;
                }
                else
                {
                    ExText.text = "";
                    ExLong.text = "은신처에서 발견한 열쇠 꾸러미.";
                    ExBtn.SetActive(false);
                }
            }

            if (item.itemName == "AR1C4_File")
            {
                TitleText.text = "사건 파일";
                ExText.text = "피해자들에 대한 여러 기록을 정리한 문서.";
                ExBtnText.text = "자세히 보기";
                ExLong.text = "";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                ExBtn.SetActive(true);
                files = true;

            }
            if (item.itemName == "AR1C0_Note")
            {
                TitleText.text = "쪽지";
                ExText.text = "피해 귀족들이 주고받던 암호 쪽지.";
                ExBtnText.text = "자세히 보기";
                ExLong.text = "";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                ExBtn.SetActive(true);
                note = true;
            }
            if (item.itemName == "AR1C0_Pictures")
            {
                TitleText.text = "사진 더미";
                ExText.text = "피해자들이 살해당한 네 곳의 장소를 촬영한 증거물.";
                ExBtnText.text = "자세히 보기";
                ExLong.text = "";
                DetailImage.GetComponent<Image>().sprite = item.itemImage;
                ExBtn.SetActive(true);
            }
        }
    }
}