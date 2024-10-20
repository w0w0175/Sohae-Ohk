using UnityEngine;

public class AR2_Manager : MonoBehaviour
{
    public static AR2_Manager Instance;

    public bool IsAR2 = false;
    public static bool AR2C1_Gun = false;

    public GameObject ver3;
    public GameObject v3_1;
    public GameObject v3_2;
    public GameObject v3_3;
    public GameObject ver5;
    public GameObject v5_1;
    public GameObject v5_2;
    public GameObject v5_3;
    public GameObject v5_4;
    public GameObject v5_5;

    public GameObject AR2C1;
    public GameObject AR2C2;
    public GameObject AR2C3;
    public GameObject AR2C4;
    public GameObject AR2C5;

    public HintButton hintButton;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        IsAR2 = true;
    }
    void OnDisable()
    {
        IsAR2 = false;
    }
    void Update()
    {
        if (AR2C1.activeSelf)
        {
            ver3.SetActive(true);
            ver5.SetActive(false);
        }
        else if (AR2C2.activeSelf)
        {
            ver3.SetActive(false);
            ver5.SetActive(true);
        }
        else if (AR2C3.activeSelf)
        {
            ver3.SetActive(false);
            ver5.SetActive(false);
        }
        else if (AR2C4.activeSelf)
        {
            ver3.SetActive(false);
            ver5.SetActive(true);
        }
        else if (AR2C5.activeSelf)
        {
            ver3.SetActive(false);
            ver5.SetActive(true);
        }
        Progress();
        SetChapter();
    }
    public void Progress()
    {
        if (AR2C1.activeSelf)
        {
            switch (AR2C1_MovingManager.Instance.progress)
            {
                case 1:
                    v3_1.SetActive(true);
                    break;

                case 2:
                    v3_1.SetActive(false);
                    v3_2.SetActive(true);
                    break;

                case 3:
                    v3_2.SetActive(false);
                    v3_3.SetActive(true);
                    break;
            }
        }
        else if (AR2C2.activeSelf)
        {
            switch (AR2C2_MoveManager.Instance.progress)
            {
                case 1:
                    v5_1.SetActive(true);
                    break;

                case 2:
                    v5_1.SetActive(false);
                    v5_2.SetActive(true);
                    break;

                case 3:
                    v5_2.SetActive(false);
                    v5_3.SetActive(true);
                    break;

                case 4:
                    v5_3.SetActive(false);
                    v5_4.SetActive(true);
                    break;

                case 5:
                    v5_4.SetActive(false);
                    v5_5.SetActive(true);
                    break;
            }
        }
        else if (AR2C4.activeSelf)
        {
            switch (AR2C4_MoveManager.Instance.progress)
            {
                case 1:
                    v5_1.SetActive(true);
                    break;

                case 2:
                    v5_1.SetActive(false);
                    v5_2.SetActive(true);
                    break;

                case 3:
                    v5_2.SetActive(false);
                    v5_3.SetActive(true);
                    break;

                case 4:
                    v5_3.SetActive(false);
                    v5_4.SetActive(true);
                    break;

                case 5:
                    v5_4.SetActive(false);
                    v5_5.SetActive(true);
                    break;
            }
        }
        else if (AR2C5.activeSelf)
        {
            switch (AR2C5_MoveManager.Instance.progress)
            {
                case 1:
                    v5_1.SetActive(true);
                    break;

                case 2:
                    v5_1.SetActive(false);
                    v5_2.SetActive(true);
                    break;

                case 3:
                    v5_2.SetActive(false);
                    v5_3.SetActive(true);
                    break;

                case 4:
                    v5_3.SetActive(false);
                    v5_4.SetActive(true);
                    break;

                case 5:
                    v5_4.SetActive(false);
                    v5_5.SetActive(true);
                    break;
            }
        }
    }
    public void SetChapter()
    {
        switch (GameManager.instance.ChapterNum)
        {
            case 1:
                AR2C1.SetActive(true);
                AR2C2.SetActive(false);
                AR2C3.SetActive(false);
                AR2C4.SetActive(false);
                AR2C5.SetActive(false);
                break;
            case 2:
                AR2C1.SetActive(false);
                AR2C2.SetActive(true);
                AR2C3.SetActive(false);
                AR2C4.SetActive(false);
                AR2C5.SetActive(false);
                break;
            case 3:
                AR2C1.SetActive(false);
                AR2C2.SetActive(false);
                AR2C3.SetActive(true);
                AR2C4.SetActive(false);
                AR2C5.SetActive(false);
                break;
            case 4:
                AR2C1.SetActive(false);
                AR2C2.SetActive(false);
                AR2C3.SetActive(false);
                AR2C4.SetActive(true);
                AR2C5.SetActive(false);
                break;
            case 5:
                AR2C1.SetActive(false);
                AR2C2.SetActive(false);
                AR2C3.SetActive(false);
                AR2C4.SetActive(false);
                AR2C5.SetActive(true);
                break;
        }
    }
    public void EnableHintButton(int index = -1)
    {
        if (index == -1) return;

        string text = "";

        switch (GameManager.instance.ChapterNum)
        {
            case 1:
                if (index == 1)
                {
                    text = "창문 밖 풍경을 바라보세요.#지도와 창문 밖 풍경을 비교하면, 이 곳이 존스티나 저택이라는 사실을 알 수 있습니다.";
                }
                else if (index == 2)
                {
                    text = "가지고 있는 열쇠를 이용하세요.";
                }
                else if (index == 3)
                {
                    text = "등잔 밑이 어둡습니다.\n불을 밝혀보세요.";
                }
                break;
            case 2:
                if (index == 5)
                {
                    text = "소문자를 보면\n진짜 저녁식사 시간을 알 수 있습니다.#19:00";
                }
                else if (index == 6)
                {
                    text = "화면을 기울여서 보면\n숫자가 보입니다.#1987";
                }
                else if (index == 7)
                {
                    text = "사람들의 머리 색과 종이 뒷면을 유심히 살펴보세요.#오른쪽 아래 자리";
                }
                else if (index == 8)
                {
                    text = "3번은 거짓입니다.#오므라이스";
                }
                break;
            case 3:
                if (index == 100)
                {
                    text = "소녀와 적당한 거리를 유지하세요.\n나머지 가족에 대한 힌트는\n말 많은 방계 소년이 가지고 있습니다.\n부엌으로 가세요.";
                }
                else if (index == 110)
                {
                    text = "첼리의 말이 거짓이라면,\n고개를 끄덕이는 것은 아니라는 의미입니다.\n따라서 이 경우, 집사는 오른쪽으로 가는 것이\n위험하다고 알려준 것입니다.\n첼리의 말이 진실이라면,\n마찬가지로 오른쪽으로 가서는 안 됩니다.\n따라서 이 문제는 누구의 말이 진실인지 무관하게\n가야 하는 방향이 정해져 있습니다.";
                }
                else if (index == 120)
                {
                    text = "소녀와 적당한 거리를 유지하세요.\n나머지 가족에 대한 힌트는\n말 많은 방계 소년이 가지고 있습니다.\n방계에게 다정하게 대해 주어야\n나머지 가족에 대한 힌트를 얻을 수 있습니다.";
                }
                break;
            case 4:
                if (index == 10)
                {
                    text = "쓰레기통을 유심히 살펴보세요.";
                }
                else if (index == 11)
                {
                    text = "봉투를 유심히 살펴보세요.#회색 머리카락을 가진 집사";
                }
                else if (index == 12)
                {
                    text = "존스티나 공작가를\n견제할 수 있을 정도로\n강한 사람을 선택하세요.#히엠스 공작";
                }
                else if (index == 13)
                {
                    text = "결국 목, 토, 일에는 경기를 하지 않았고,\n금요일에는 모두 승리했으며,\n월, 화, 수도 마찬가지로 모두 승리한 것입니다.#20회 (모두 승리)";
                }
                else if (index == 14)
                {
                    text = "플프프플프플히히 #플라멘 영식, 프레타 후작부인, 프레타 영애, 플라멘 백작부인, 프레타 후작, 플라멘 백작, 히엠스 공작, 히엠스 영애";
                }
                else if (index == 15)
                {
                    text = "왕비 2/3: 나머지 1/3\n공작부인 1/4, 나머지 1/12\n히엠스 공작 1/12, 나머지 1/60";
                }
                break;
            case 5:
                if (index == 16)
                {
                    text = "각 요일을 떠올려보세요.#물방울(수요일), 태양(일요일)";
                }
                else if (index == 17)
                {
                    text = "어떤 숫자에 거울을 대면 1881이 됩니다.#거울 숫자는 1001, 예법서는 53, 답은 0948";
                }
                else if (index == 18)
                {
                    text = "9를 거꾸로 돌리면 6이 됩니다.#6+11+13";
                }
                else if (index == 19)
                {
                    text = "예법서는 총 53쪽입니다.";
                }
                else if (index == 20)
                {
                    text = "호수를 꼭 살펴보세요.";
                }
                break;
        }

        hintButton.SetHint(text);
    }
    public void DisableHintButton()
    {
        hintButton.DisableButton();
    }
}
