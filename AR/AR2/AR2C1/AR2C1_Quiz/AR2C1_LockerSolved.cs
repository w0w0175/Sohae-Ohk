using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR2C1_LockerSolved : MonoBehaviour
{
    public static AR2C1_LockerSolved Instance;

    public GameObject Clover2;
    public GameObject Heart3;
    public GameObject Dia7;
    public GameObject Spade5;

    public GameObject Locker;      
    public GameObject Upperlocker; 
    public GameObject OpenLocker;

    public bool IsLockerFail = false;
    public bool IsLockerSuccess = false;

    private RectTransform lockerbody;
    private RectTransform upperloc;

    void Awake()
    {
        if (Instance == null)
            Instance = this;

        IsLockerFail = false;

        upperloc = Upperlocker.GetComponent<RectTransform>();
        lockerbody = Locker.GetComponent<RectTransform>();
    }

    public void OnClickUpperLocker()
    {
        StartCoroutine(clickupper());

        if (Clover2.activeSelf && Heart3.activeSelf && Dia7.activeSelf && Spade5.activeSelf == true)
        {
            StartCoroutine(forlockeranswer());
            //자물쇠가열렷슴다~
        }
        else
        {
            StartCoroutine(forlockerwrong());
            IsLockerFail = true;
        }
    }

    IEnumerator clickupper()
    {
        upperloc.position = new Vector3(upperloc.position.x, upperloc.position.y - 0.4f, upperloc.position.z);

        yield return new WaitForSeconds(0.3f);

        upperloc.position = new Vector3(upperloc.position.x, upperloc.position.y + 0.4f, upperloc.position.z);
    }

    IEnumerator forlockeranswer()
    {
        yield return new WaitForSeconds(0.7f);

        Upperlocker.SetActive(false);
        OpenLocker.SetActive(true);
        
        yield return new WaitForSeconds(0.5f);

        if (AR2C4_MoveManager.Instance != null)
        {
            if (AR2C4_MoveManager.Instance.ar2c4)
            {
                AR2C4_MoveManager.Instance.LockerSuccess();
            }
        }
        else
        {
            AR2C1_MovingManager.Instance.LockerSuccess();
        }    

        yield break;
    }

    IEnumerator forlockerwrong()
    {
        yield return new WaitForSeconds(0.5f);

        upperloc.position = new Vector3(upperloc.position.x - 0.1f, upperloc.position.y, upperloc.position.z);
        lockerbody.position = new Vector3(lockerbody.position.x - 0.1f, lockerbody.position.y, lockerbody.position.z);

        yield return new WaitForSeconds(0.1f);

        upperloc.position = new Vector3(upperloc.position.x + 0.2f, upperloc.position.y, upperloc.position.z);
        lockerbody.position = new Vector3(lockerbody.position.x + 0.2f, lockerbody.position.y, lockerbody.position.z);

        yield return new WaitForSeconds(0.1f);

        upperloc.position = new Vector3(upperloc.position.x - 0.2f, upperloc.position.y, upperloc.position.z);
        lockerbody.position = new Vector3(lockerbody.position.x - 0.2f, lockerbody.position.y, lockerbody.position.z);

        yield return new WaitForSeconds(0.1f);

        upperloc.position = new Vector3(upperloc.position.x + 0.1f, upperloc.position.y, upperloc.position.z);
        lockerbody.position = new Vector3(lockerbody.position.x + 0.1f, lockerbody.position.y, lockerbody.position.z);

        yield return new WaitForSeconds(0.5f);

        if (AR2C4_MoveManager.Instance != null)
        {
            if (AR2C4_MoveManager.Instance.ar2c4)
            {
                AR2C4_MoveManager.Instance.LockerFail();
            } 
        }
        else
        {
            AR2C1_MovingManager.Instance.LockerFail();
        }
        //GameObject.Find("AR2C1_QHFail").GetComponent<AR2_InteractionController>().Text();
        yield break;
    }
}