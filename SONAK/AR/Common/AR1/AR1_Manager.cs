using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR1_Manager : MonoBehaviour
{
    public static AR1_Manager Instance;

    public static bool IsAR1 = false;

    public GameObject progress0;
    public GameObject progress1;
    public GameObject progress2;
    public GameObject progress3;
    public GameObject progress4;
    public GameObject progress5;

    public GameObject AR1C0;
    public GameObject AR1C1;
    public GameObject AR1C2;
    public GameObject AR1C3;
    public GameObject AR1C4;

    public HintButton hintButton;

    void Awake()
    {
        IsAR1 = true; //아이란 루트 1이 실행되고 있음을 알리는 bool
        if (Instance == null)
            Instance = this;
    }
    void OnDisable()
    {
        IsAR1 = false;
    }
    void Update()
    {
        Progress();
        SetChapter();
    }
    public void Progress()
    {
        if (AR1C0.activeSelf)
        {
            switch (AR1C0_MoveManager.Instance.progress) //퀴즈 진행도마다 진행도바가 바뀌게 하는 함수
            {
                case 0:
                    progress0.SetActive(true);
                    break;

                case 1:
                    progress0.SetActive(false);
                    progress1.SetActive(true);
                    break;

                case 2:
                    progress1.SetActive(false);
                    progress2.SetActive(true);
                    break;
                case 3:
                    progress2.SetActive(false);
                    progress3.SetActive(true);
                    break;
                case 4:
                    progress3.SetActive(false);
                    progress4.SetActive(true);
                    break;

                case 5:
                    progress4.SetActive(false);
                    progress5.SetActive(true);
                    break;
            }

        }
        else if (AR1C1.activeSelf)
        {
            switch (AR1C1_MovingManager.Instance.progress)
            {
                case 0:
                    progress0.SetActive(true);
                    break;

                case 1:
                    progress0.SetActive(false);
                    progress1.SetActive(true);
                    break;

                case 2:
                    progress1.SetActive(false);
                    progress2.SetActive(true);
                    break;
                case 3:
                    progress2.SetActive(false);
                    progress3.SetActive(true);
                    break;
                case 4:
                    progress3.SetActive(false);
                    progress4.SetActive(true);
                    break;

                case 5:
                    progress4.SetActive(false);
                    progress5.SetActive(true);
                    break;
            }

        }
        else if (AR1C2.activeSelf)
        {
            switch (AR1C2_MovingManager.Instance.progress)
            {

                case 1:
                    progress0.SetActive(false);
                    progress1.SetActive(true);
                    break;

                case 2:
                    progress1.SetActive(false);
                    progress2.SetActive(true);
                    break;
                case 3:
                    progress2.SetActive(false);
                    progress3.SetActive(true);
                    break;
                case 4:
                    progress3.SetActive(false);
                    progress4.SetActive(true);
                    break;

                case 5:
                    progress4.SetActive(false);
                    progress5.SetActive(true);
                    break;
            }
        }
        else if (AR1C3.activeSelf)
        {
            switch (AR1C3_MoveManager.Instance.progress)
            {

                case 1:
                    progress0.SetActive(false);
                    progress1.SetActive(true);
                    break;

                case 2:
                    progress1.SetActive(false);
                    progress2.SetActive(true);
                    break;
                case 3:
                    progress2.SetActive(false);
                    progress3.SetActive(true);
                    break;
                case 4:
                    progress3.SetActive(false);
                    progress4.SetActive(true);
                    break;

                case 5:
                    progress4.SetActive(false);
                    progress5.SetActive(true);
                    break;
            }
        }
        else if (AR1C4.activeSelf)
        {
            progress0.SetActive(false); //진행도바가 필요 없는 경우 아예 안 보이게 처리
        }
    }
    public void SetChapter()
    {
        switch (GameManager.instance.ChapterNum)
        {
            case 1:
                AR1C0.SetActive(true);
                AR1C1.SetActive(false);
                AR1C2.SetActive(false);
                AR1C3.SetActive(false);
                AR1C4.SetActive(false);
                break;
            case 2:
                AR1C0.SetActive(false);
                AR1C1.SetActive(true);
                AR1C2.SetActive(false);
                AR1C3.SetActive(false);
                AR1C4.SetActive(false);
                break;

            case 3:
                AR1C0.SetActive(false);
                AR1C1.SetActive(false);
                AR1C2.SetActive(true);
                AR1C3.SetActive(false);
                AR1C4.SetActive(false);
                break;
            case 4:
                AR1C0.SetActive(false);
                AR1C1.SetActive(false);
                AR1C2.SetActive(false);
                AR1C3.SetActive(true);
                AR1C4.SetActive(false);
                break;
            case 5:
                AR1C0.SetActive(false);
                AR1C1.SetActive(false);
                AR1C2.SetActive(false);
                AR1C3.SetActive(false);
                AR1C4.SetActive(true);
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
                    text = "발견 장소를 유심히 살펴보세요.#DRUG";
                }
                else if (index == 2)
                {
                    text = "거꾸로 보세요.#he is 3, 정답은 제 3왕자입니다.";
                }
                else if (index == 3)
                {
                    text = "사건 일지를 통해\n파악한 사건 발생 순서대로 연결하세요.#알파벳 Z 모양";
                }
                else if (index == 4)
                {
                    text = "칠판에 있는 사진을 연결하면\n이니셜이 등장합니다.#Zoey 교수";
                }
                else if (index == 5)
                {
                    text = "doll을 거울에 비추면 숫자가 나타납니다.#1106번지";
                }
                break;
            case 2:
                if (index == 6)
                {
                    text = "책상 위 물건을 하나씩 터치해보세요.#가방 안 서류, 지갑 안 열쇠";
                }
                else if (index == 7)
                {
                    text = "과일의 개수가 책의 순서입니다.#보라, 초록, 파랑, 빨강 순으로 책을 배열하세요. (정답인 책만 내 가방 안 설명이 다릅니다)";
                }
                else if (index == 8)
                {
                    text = "바나나는 범인이 아닙니다.#애플";
                }
                else if (index == 9)
                {
                    text = "숫자들을 달력에서 찾아 연결해보세요.#숫자를 연결하면 F, Fimbria";
                }
                break;
            case 3:
                if (index == 10)
                {
                    text = "가장 멀리 떨어져 있다는 내용에서, 가장 모서리에 위치한 네 집 중 하나라는 사실을 알 수 있습니다.#134A";
                }
                else if (index == 11)
                {
                    text = "립스틱을 꼭 입술에 발라야만 하는 건 아닙니다.\n누군가는 인장으로 사용했을지도?#남자가 범인 (여자는 화장 안 함)";
                }
                else if (index == 12)
                {
                    text = "문 위 그려진 색상과 문의 위치가\n일치하는 문만 진짜 문입니다.#빨간 문";
                }
                break;
            case 4:
                if (index == 13)
                {
                    text = "나무가 있을 땐 불 조심.";
                }
                else if (index == 14)
                {
                    text = "열쇠는 보통 화분 아래에 숨깁니다.";
                }
                else if (index == 15)
                {
                    text = "문은 다섯 개이지만 정답은 그보다 하나 적습니다.#4번";
                }
                else if (index == 16)
                {
                    text = "다이아 열쇠를, 열쇠의 단면과 일치하는\n자물쇠에 꽂으세요.#세 번째 문";
                }
                else if (index == 17)
                {
                    text = "아이란은 힘이 약해 도르래를 들 수 없습니다.\n증인은 불을 피울 도구가 없습니다.";
                }
                break;
            case 5:
                if (index == 18)
                {
                    text = "음이 낮은 순서부터 높은 순서로 잔을 배열하세요.#25481376";
                }
                else if (index == 19)
                {
                    text = "의자에 있는 문양을 유심히 살펴보세요.#바이올린";
                }
                else if (index == 20)
                {
                    text = "구구단 8단을 생각해보세요.#8x4=32, 8x3=24 / 8x12=96";
                }
                else if (index == 21)
                {
                    text = "알파벳에서 직선을 하나씩 제거하세요.#0+11=11, 3+1=4, 3+0=3";
                }
                else if (index == 22)
                {
                    text = "1.ZOEY : 교수의 이름\n2.DRUG : 피해자들이 사용한 물건\n3.JONSTINA : 아이란의 성씨\n4.TRUTH : 아이란이 원하는 것";
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
