using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FoodMaterial : MonoBehaviour
{
    Vector3 pos;
    string objName;
    XRGrabInteractable xrgrab;

    private void Awake()
    {
        pos = transform.localPosition;
        objName = gameObject.name;
    }

    private void OnEnable()
    {
        if (xrgrab != enabled)
        {
            gameObject.GetComponent<XRGrabInteractable>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other) //메인디쉬와 충돌했을 때
    {
        if (other.gameObject.name == "MainPlate")
        {
            switch (objName) //이름으로 구분
            {
                case "Bun1":
                    GameManager.instance.isbun1 = true;
                    break;
                case "Bun2":
                    GameManager.instance.isbun2 = true;
                    break;
                case "Salami":
                    GameManager.instance.issalami = true;
                    break;
                case "Lamb":
                    GameManager.instance.islamb = true;
                    break;
                case "Cookie":
                    GameManager.instance.iscookie = true;
                    break;
                case "Salmon":
                    GameManager.instance.issalmon = true;
                    break;
                case "Pepper":
                    GameManager.instance.ispepper = true;
                    break;
                case "Steak":
                    GameManager.instance.issteak = true;
                    break;
            }
        }
    }

    private void OnTriggerExit(Collider other) //메인디쉬와 충돌이 끝났을 때
    {
        if (other.gameObject.name == "MainPlate")
        {
            switch (objName) //이름으로 구분
            {
                case "Bun1":
                    GameManager.instance.isbun1 = false;
                    break;
                case "Bun2":
                    GameManager.instance.isbun2 = false;
                    break;
                case "Salami":
                    GameManager.instance.issalami = false;
                    break;
                case "Lamb":
                    GameManager.instance.islamb = false;
                    break;
                case "Cookie":
                    GameManager.instance.iscookie = false;
                    break;
                case "Salmon":
                    GameManager.instance.issalmon = false;
                    break;
                case "Pepper":
                    GameManager.instance.ispepper = false;
                    break;
                case "Steak":
                    GameManager.instance.issteak = false;
                    break;
            }
        }
    }
    public void OnSelectExit() //컨트롤러가 음식을 놨을 때
    {
        if (gameObject.name == "Bun1")
        {
            if (GameManager.instance.isbun1)
            {
                transform.localPosition = new Vector3(-0.187f, -0.351f, 0.607f); //메인디쉬 쪽 포지션 고정
            }
            else
            {
                transform.localPosition = pos; //메인디쉬 쪽에 없으면 원래 위치로
            }
        }
        else if (gameObject.name == "Bun2")
        {
            if (GameManager.instance.isbun2)
            {
                transform.localPosition = new Vector3(-0.185f, -0.32f, 0.5931f);
            }
            else
            {
                transform.localPosition = pos;
            }
        }
        else if (gameObject.name == "Pepper")
        {
            if (GameManager.instance.ispepper)
            {
                transform.localPosition = new Vector3(-0.168f, -0.459f, 0.5762f);
            }
            else
            {
                transform.localPosition = pos;
            }
        }
        else if (gameObject.name == "Salami")
        {
            if (GameManager.instance.issalami)
            {
                transform.localPosition = new Vector3(-0.184f, -0.39f, 0.621f);
            }
            else
            {
                transform.localPosition = pos;
            }
        }
        else if (gameObject.name == "Cookie")
        {
            if (GameManager.instance.iscookie)
            {
                transform.localPosition = new Vector3(-0.195f, -0.443f, 0.596f);
            }
            else
            {
                transform.localPosition = pos;
            }
        }
        else if (gameObject.name == "Salmon")
        {
            if (GameManager.instance.issalmon)
            {
                transform.localPosition = new Vector3(-0.207f, -0.429f, 0.613f);
            }
            else
            {
                transform.localPosition = pos;
            }
        }
        else if (gameObject.name == "Lamb")
        {
            if (GameManager.instance.islamb)
            {
                transform.localPosition = new Vector3(-0.2041f, -0.4044f, 0.5552f);
            }
            else
            {
                transform.localPosition = pos;
            }
        }
        else if (gameObject.name == "Steak")
        {
            if (GameManager.instance.issteak)
            {
                transform.localPosition = new Vector3(-0.192f, -0.445f, 0.629f);
            }
            else
            {
                transform.localPosition = pos;
            }
        }

    }

    private void OnDisable() //꺼질 때 원리 위치로
    {
        transform.localPosition = pos;
    }
}
