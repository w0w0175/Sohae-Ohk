using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCtrl : MonoBehaviour
{
    public float speed = 0.5f;

    Rigidbody rb;

    Vector3 firstPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        firstPos = transform.localPosition;
    }

    void Update() //상하좌우 키를 통해 캐릭터 움직이기
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
    }

    public void OnFound()
    {
        if (rb != null)
        {
            rb.isKinematic = false;
        }
    }

    public void OnLost()
    {
        if (rb != null)
        {
            rb.isKinematic = true;
        }
    }

    public void OnCollisionEnter(Collision collision) 
    {
        string objName = collision.gameObject.name;

        if (objName == "Item")
        {
            collision.gameObject.SetActive(false);
            Stage1Manager.instance.AddCatch();
        }
        else if (objName == "Exit")
        {
            ProgressManager.instance.ToNext();
        }
        else if (objName == "Trap")
        {
            transform.localPosition = firstPos;
            ProgressManager.instance.PopupMsg("으악 함정이다\n신선한 과일만 가져가야돼~", 2);
        }
    }
}
