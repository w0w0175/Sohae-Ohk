using UnityEngine;

public class ER1_Manager : MonoBehaviour
{
    public static ER1_Manager Instance;

    public GameObject ER1C1;
    public GameObject ER1C2;
    public GameObject ER1C3;

    public GameObject Ver3;
    public GameObject Ver5;
    public GameObject progress0;
    public GameObject progress1;
    public GameObject progress2;
    public GameObject progress3;
    public GameObject progress5_1;
    public GameObject progress5_2;
    public GameObject progress5_3;
    public GameObject progress5_4;
    public GameObject progress5_5;

    public HintButton hintButton;

    void Update()
    {
        if (Instance == null)
            Instance = this;
        SetChapter();
        Progress();
    }
    public void SetChapter()
    {
        switch (GameManager.instance.ChapterNum)
        {
            case 1:
                ER1C1.SetActive(true);
                ER1C2.SetActive(false);
                ER1C3.SetActive(false);
                break;
            case 2:
                ER1C1.SetActive(false);
                ER1C2.SetActive(true);
                ER1C3.SetActive(false);
                break;
            case 3:
                ER1C1.SetActive(false);
                ER1C2.SetActive(false);
                ER1C3.SetActive(true);
                break;
        }
    }
    public void Progress()
    {
        if (ER1C1.activeSelf == true)
        {
            switch (ER1C1_MovingManager.Instance.progress)
            {
                case 0:
                    progress0.SetActive(true);
                    Ver5.SetActive(false);
                    Ver3.SetActive(true);
                    break;

                case 1:
                    progress1.SetActive(true);
                    break;

                case 2:
                    progress2.SetActive(true);
                    break;
                case 3:
                    progress3.SetActive(true);
                    break;
            }
        }
        else if (ER1C2.activeSelf == true)
        {
            switch (ER1C2_MoveManager.Instance.progress)
            {
                case 0:
                    progress0.SetActive(true);
                    Ver5.SetActive(true);
                    Ver3.SetActive(false);
                    break;
                case 1:
                    progress5_1.SetActive(true);
                    break;

                case 2:
                    progress5_2.SetActive(true);
                    break;
                case 3:
                    progress5_3.SetActive(true);
                    break;
                case 4:
                    progress5_4.SetActive(true);
                    break;
                case 5:
                    progress5_5.SetActive(true);
                    break;
            }
        }
        else if (ER1C3.activeSelf == true)
        {
            switch (ER1C3_MoveManager.Instance.progress)
            {
                case 0:
                    progress0.SetActive(true);
                    Ver5.SetActive(true);
                    Ver3.SetActive(false);
                    break;
                case 1:
                    progress5_1.SetActive(true);
                    break;

                case 2:
                    progress5_2.SetActive(true);
                    break;
                case 3:
                    progress5_3.SetActive(true);
                    break;
                case 4:
                    progress5_4.SetActive(true);
                    break;
                case 5:
                    progress5_5.SetActive(true);
                    break;
            }
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
                    text = "양의 색은 매우 다양합니다.\n편견 없이 모든 곳을 다 눌러보세요.#바위 뒤, 구름 위, 나무 위, 동굴 안, 호수 앞";
                }
                else if (index == 2)
                {
                    text = "곰이 무엇을 좋아하는지 잘 살펴보세요.\n예를 들면 동굴 옆?#꿀 (이 곰은 고기를 먹지 않습니다)";
                }
                else if (index == 3)
                {
                    text = "양을 먼저 데리고 건너면\n늑대는 약초를 먹지 않습니다.#양 -> 늑대 -> 양 다시 데려온 뒤 약초 -> 마지막으로 양";
                }
                else if (index == 0)
                {
                    text = "지붕 위로 올라가려면 사다리가 필요합니다. 항상 예의 바른 태도를 유지하세요.";
                }
                break;
            case 2:
                if (index == 5)
                {
                    text = "말 네 마리의 시선을 잘 관찰하세요.#왼쪽 - 왼쪽 - 아래 - 아래";
                }
                else if (index == 6)
                {
                    text = "나뭇가지의 개수가 나뭇가지를\n꺾어야 하는 순서입니다.";
                }
                else if (index == 7)
                {
                    text = "선반의 비밀번호는 꽃봉오리의 색입니다.";
                }
                else if (index == 8)
                {
                    text = "솥에서 나오는 수증기의 모양을 관찰하면\n상자를 열 수 있습니다.#263";
                }
                else if (index == 9)
                {
                    text = "늑대의 발자국은 늑대의 집인\n숲으로 이어져 있습니다.";
                }
                break;
            case 3:
                if (index == 10)
                {
                    text = "메달 뒷면에 적힌 숫자와 단어를 매치하세요.\n첫 번째 줄의 1번째, 3번째 글자...#SAFE";
                }
                else if (index == 11)
                {
                    text = "마을 지도는 달력의 모양을 하고 있습니다.\n7월 17일에 해당하는 구역으로 이동하세요.";
                }
                else if (index == 12)
                {
                    text = "연도가 항상 양수인 것은 아닙니다.#BC100";
                }
                else if (index == 13)
                {
                    text = "장소를 회상하며 동물이 몇 마리 있었는지\n잘 세어보세요.\n양은 총 8마리였습니다!#8411";
                }
                else if (index == 14)
                {
                    text = "약초의 모양은 세 종류입니다.\n세 종류의 약초는\n세 가지의 수를 의미합니다.#3, 7, 5";
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
