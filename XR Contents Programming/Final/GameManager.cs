using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;
    
    public List<Sprite> sprites = new List<Sprite>();

    public GameObject order1;
    public GameObject btn1;
    public GameObject explanation;
    public GameObject Environment;
    public GameObject BackGU;
    public GameObject Back_btn;
    public GameObject Back_exp;

    public Image Back_img;
    public Sprite start;
    public Sprite gamefail;
    public Sprite gamesuccess;

    public Text exT;
    public Text odT;
    public Text Back_expT;
    public Text Back_btnT;

    public GameObject bun1;
    public GameObject bun2;
    public GameObject pepper;
    public GameObject salami;
    public GameObject steak;
    public GameObject salmon;
    public GameObject cookie;
    public GameObject lamb;
    public GameObject spawner;

    Image img1;

    int index;
    int fail = 0;
    int success = 0;
    int gp1 = 0;

    AudioSource ads;
    public AudioClip suc;
    public AudioClip fa;
    public AudioClip back;
    public AudioClip correct;
    public AudioClip wrong;

    public bool isbun1 = false;
    public bool isbun2 = false;
    public bool ispepper = false;
    public bool issalami = false;
    public bool iscookie = false;
    public bool issalmon = false;
    public bool islamb = false;
    public bool issteak = false;

    bool checkstart = true;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        img1 = order1.GetComponent<Image>();
        ads = GetComponent<AudioSource>();

        index = Random.Range(0,6);
    }
    private void Start()
    {
        ResetEverything();
        ads.Play();
        StartCoroutine(Explaining_UI("드디어 버거집을 차렸다!\n지금부터 열심히 팔아볼까?", 3f));

        Debug.Log($"index 값: {index}, 유효 범위 체크: {(index >= 0 && index <= 5)}");
    }

    public void ClickNext() //다음 & 완성 버튼을 위한 함수
    {
        switch (gp1)
        {
            case 0:
                if (!ispepper && !issteak || ispepper && issteak)
                    return;
                else if (ispepper && !issteak)
                {
                    steak.SetActive(false);
                    pepper.GetComponent<XRGrabInteractable>().enabled = false;
                    gp1++;
                }
                else if (issteak && !ispepper)
                {
                    pepper.SetActive(false);
                    steak.GetComponent<XRGrabInteractable>().enabled = false;
                    gp1++;
                }
                salmon.SetActive(true);
                cookie.SetActive(true);

                break;
            case 1:
                if (!iscookie && !issalmon || iscookie && issalmon)
                    return;
                else if (iscookie && !issalmon)
                {
                    salmon.SetActive(false);
                    cookie.GetComponent<XRGrabInteractable>().enabled = false;
                    gp1++;
                }
                else if (issalmon && !iscookie)
                {
                    cookie.SetActive(false);
                    salmon.GetComponent<XRGrabInteractable>().enabled = false;
                    gp1++;
                }
                salami.SetActive(true);
                lamb.SetActive(true);

                break;
            case 2:
                odT.text = "완성";
                if (!issalami && !islamb || issalami && islamb)
                    return;
                else if (issalami && !islamb)
                {
                    lamb.SetActive(false);
                    salami.GetComponent<XRGrabInteractable>().enabled = false;
                    gp1++;
                }
                else if (islamb && !issalami)
                {
                    salami.SetActive(false);
                    lamb.GetComponent<XRGrabInteractable>().enabled = false;
                    gp1++;
                }
                bun1.SetActive(true);
                bun2.SetActive(true);

                break;
            case 3:
                if (!isbun1 && !isbun2 || isbun1 && isbun2)
                    return;
                else if (isbun1 && !isbun2)
                {
                    bun2.SetActive(false);
                    bun1.GetComponent<XRGrabInteractable>().enabled = false;
                }
                else if (isbun2 && !isbun1)
                {
                    bun1.SetActive(false);
                    bun2.GetComponent<XRGrabInteractable>().enabled = false;
                }

                HamburgurAnswer();
                break;
        }
    }
    
    void HamburgurAnswer() //정답 체크를 위한 함수
    {
        Debug.Log("HamburgurAnswer() 실행 시작");
        gp1 = 0;
        Debug.Log($"현재 index 값: {index}");
        Debug.Log("Switch문 실행 전");

        switch (index)
        {
            case 0:
                Debug.Log("case 0 진입");
                if (isbun1 && islamb && iscookie && ispepper)
                {
                    if (success == 3)
                    {
                        GameOver();
                    }
                    else
                    {
                        success++;
                        ads.PlayOneShot(correct);
                        StartCoroutine(Explaining("너무 맛있어요!", 2f));
                    }
                }
                else
                {
                    if (fail == 2)
                    {
                        GameOver();
                    }
                    else
                    {
                        fail++;
                        ads.PlayOneShot(wrong);
                        StartCoroutine(Explaining("제가 시킨 버거가 아니에요!", 2f));
                    }
                }
                break;
            case 1:
                if (isbun2 && issalami && issalmon && issteak)
                {
                    if (success == 3)
                    {
                        GameOver();
                    }
                    else
                    {
                        success++;
                        ads.PlayOneShot(correct);
                        StartCoroutine(Explaining("너무 맛있어요!", 2f));
                    }
                }
                else
                {
                    if (fail == 2)
                    {
                        GameOver();
                    }
                    else
                    {
                        fail++;
                        ads.PlayOneShot(wrong);
                        StartCoroutine(Explaining("제가 시킨 버거가 아니에요!", 2f));
                    }
                }
                break;
            case 2:
                if (isbun2 && islamb && issalmon && ispepper)
                {
                    if (success == 3)
                    {
                        GameOver();
                    }
                    else
                    {
                        success++;
                        ads.PlayOneShot(correct);
                        StartCoroutine(Explaining("너무 맛있어요!", 2f));
                    }
                }
                else
                {
                    if (fail == 2)
                    {
                        GameOver();
                    }
                    else
                    {
                        fail++;
                        ads.PlayOneShot(wrong);
                        StartCoroutine(Explaining("제가 시킨 버거가 아니에요!", 2f));
                    }
                }
                break;
            case 3:
                if (isbun1 && issalami && iscookie && issteak)
                {
                    if (success == 3)
                    {
                        GameOver();
                    }
                    else
                    {
                        success++;
                        ads.PlayOneShot(correct);
                        StartCoroutine(Explaining("너무 맛있어요!", 2f));
                    }
                }
                else
                {
                    if (fail == 2)
                    {
                        GameOver();
                    }
                    else
                    {
                        fail++;
                        ads.PlayOneShot(wrong);
                        StartCoroutine(Explaining("제가 시킨 버거가 아니에요!", 2f));
                    }
                }
                break;
            case 4:
                if (isbun2 && islamb && issalmon && issteak)
                {
                    if (success == 3)
                    {
                        GameOver();
                    }
                    else
                    {
                        success++;
                        ads.PlayOneShot(correct);
                        StartCoroutine(Explaining("너무 맛있어요!", 2f));
                    }
                }
                else
                {
                    if (fail == 2)
                    {
                        GameOver();
                    }
                    else
                    {
                        fail++;
                        ads.PlayOneShot(wrong);
                        StartCoroutine(Explaining("제가 시킨 버거가 아니에요!", 2f));
                    }
                }
                break;
            case 5:
                if (isbun1 && issalami && iscookie && ispepper)
                {
                    if (success == 3)
                    {
                        GameOver();
                    }
                    else
                    {
                        success++;
                        ads.PlayOneShot(correct);
                        StartCoroutine(Explaining("너무 맛있어요!", 2f));
                    }
                }
                else
                {
                    if (fail == 2)
                    {
                        GameOver();
                    }
                    else
                    {
                        fail++;
                        ads.PlayOneShot(wrong);
                        StartCoroutine(Explaining("제가 시킨 버거가 아니에요!", 2f));
                    }
                }
                break;
        }

        Debug.Log("HamburgurAnswer() 종료");

        ResetEverything();
    }

    void NextStep() //버거 성공 or 실패 후 상태 리셋
    {
        index = Random.Range(0, 6);
        img1.sprite = sprites[index];
        pepper.SetActive(true);
        steak.SetActive(true);

        btn1.SetActive(true);
        odT.text = "다음";
    }

    IEnumerator Explaining(string n, float t) //버거 성공 or 실패 후 설명창
    {
        Debug.Log("success : "+ success);
        Debug.Log("fail : " + fail);
        explanation.SetActive(true);
        exT.text = n;

        yield return new WaitForSeconds(t);
        explanation.SetActive(false);
        NextStep();
    }

    public void GameStart() //게임 다시하기 or 시작하기 버튼을 위한 함수
    {
        if (Back_btnT.text == "다시하기")
        {
            SceneManager.LoadScene("Main");
        }
        else
        {
            order1.SetActive(true);
            Environment.SetActive(true);
            BackGU.SetActive(false);
            spawner.SetActive(true);
            NextStep();

            ads.clip = back;
            ads.Play();
            ads.loop = true;
        }
    }
    public void GameOver() //게임이 끝났을 때 실행되는 함수
    {
        ResetEverything();
        Environment.SetActive(false);
        BackGU.SetActive(true);
        spawner.SetActive(false);

        ads.loop = false;
        if (fail == 2 && success < 3)
        {
            StartCoroutine(Explaining_UI("버거를 엉망진창으로 줬더니..\n소문나서 가게 망했네", 3f));
            ads.clip = fa;
            Back_img.GetComponent<Image>().sprite = gamefail;
        }
        else if (success == 3 && fail < 2)
        {
            StartCoroutine(Explaining_UI("와 버거 맛집이라고 소문나서\n부자 됐다!", 3f));
            ads.clip = suc;
            Back_img.GetComponent<Image>().sprite = gamesuccess;
        }
        else if (success < 3 && fail < 2)
        {
            StartCoroutine(Explaining_UI("가게에 벌레 나온다고\n소문이 쫙 나서 가게 망했네", 3f));
            ads.clip = fa;
            Back_img.GetComponent<Image>().sprite = gamefail;
        }
        ads.Play();
    }

    IEnumerator Explaining_UI(string n, float t) //인트로 or 게임 오버 화면을 위한 설명창
    {
        Back_exp.SetActive(true);
        Back_btn.SetActive(false);
        Back_expT.text = n;

        yield return new WaitForSeconds(t);
        Back_exp.SetActive(false);
        Back_btn.SetActive(true);
        if (checkstart)
        {
            checkstart = false;
            Back_btnT.text = "시작하기";
        }
        else
            Back_btnT.text = "다시하기";
    }

    void ResetEverything() //모든 상태 초기화
    {
        isbun1 = false;
        isbun2 = false;
        ispepper = false;
        issalami = false;
        iscookie = false;
        issalmon = false;
        islamb = false;
        issteak = false;

        bun1.SetActive(false);
        bun2.SetActive(false);
        steak.SetActive(false);
        pepper.SetActive(false);
        salmon.SetActive(false);
        cookie.SetActive(false);
        lamb.SetActive(false);
        salami.SetActive(false);
        btn1.SetActive(false);
    }
}
