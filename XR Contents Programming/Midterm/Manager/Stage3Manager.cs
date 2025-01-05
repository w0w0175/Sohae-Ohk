using System.Security.Permissions;
using UnityEngine;
using UnityEngine.UI;

public class Stage3Manager : MonoBehaviour
{
    static public Stage3Manager instance;

    public GameObject Explanation;
    public GameObject RSP;

    public Text ExT;
    public TextMesh squresult;
    public TextMesh catresult;

    int rspsqu = 0;

    void Start()
    {
        if (instance == null)
            instance = this;

        Explanation.SetActive(true);
        ExT.text = "카드를 인식시켜 주세요";
        squresult.text = "";
    }
    
    public void StartRockScissorsPaper() //스테이지 3 가위바위보 게임 시작
    {
        ProgressManager.instance.PopupMsg("가위 바위 보 중 하나를 선택해주세요", 1);
        Invoke("SelectRSP", 1);
    }

    public void SelectRSP() //가위바위보 선택창이 뜨는 함수
    {
        RSP.SetActive(true);
        rspsqu = Random.Range(0, 2);
        Debug.Log(rspsqu);
        squresult.text = "";
        catresult.text = "";
    }
    public void ResetRSP() //가위바위보 선택창 리셋
    {
        RSP.SetActive(false);
        rspsqu = 5;
        Debug.Log(rspsqu);
        Invoke("SelectRSP", 1);
    }

    public void OnClickRock() //바위를 클릭했을 시
    {
        catresult.text = "바위";
        if (rspsqu == 0) //상대방이 보일 경우
        {
            squresult.text = "보";
            ResetRSP();
            ProgressManager.instance.PopupMsg("이럴 수가! 다시 하자!", 1);
        }
        else if (rspsqu == 1) //상대방이 가위일 경우
        {
            squresult.text = "가위";
            RSP.SetActive(false);

            ProgressManager.instance.PopupMsg("우와 이겼다!", 1);

            Invoke("SuccessResult", 1);
        }
        else if (rspsqu == 2) //상대방이 바위일 경우
        {
            squresult.text = "바위";
            ResetRSP();
            ProgressManager.instance.PopupMsg("같은 걸 내다니! 다시 하자!", 1);
        }
    }

    public void OnClickScissors()
    {
        catresult.text = "가위";
        if (rspsqu == 0)
        {
            squresult.text = "보";
            RSP.SetActive(false);

            ProgressManager.instance.PopupMsg("우와 이겼다!", 1);

            Invoke("SuccessResult", 1);
        }
        else if (rspsqu == 1)
        {
            squresult.text = "가위";
            ResetRSP();
            ProgressManager.instance.PopupMsg("같은 걸 내다니! 다시 하자!", 1);
        }
        else if (rspsqu == 2)
        {
            squresult.text = "바위";
            ResetRSP();
            ProgressManager.instance.PopupMsg("이럴 수가! 다시 하자!", 1);
        }
    }

    public void OnClickPaper()
    {
        catresult.text = "보";
        if (rspsqu == 0)
        {
            squresult.text = "보";
            ResetRSP();
            ProgressManager.instance.PopupMsg("같은 걸 내다니! 다시 하자!", 1);
        }
        else if (rspsqu == 1)
        {
            squresult.text = "가위";
            ResetRSP();
            ProgressManager.instance.PopupMsg("이럴 수가! 다시 하자!", 1);
        }
        else if (rspsqu == 2)
        {
            squresult.text = "바위";
            RSP.SetActive(false);

            ProgressManager.instance.PopupMsg("우와 이겼다!", 1);

            Invoke("SuccessResult", 1);
        }
    }

    public void SuccessResult()
    {
        ProgressManager.instance.ToNext();
    }
    public void OnDetected()
    {
        ProgressManager.instance.StartStage3();
    }
}
