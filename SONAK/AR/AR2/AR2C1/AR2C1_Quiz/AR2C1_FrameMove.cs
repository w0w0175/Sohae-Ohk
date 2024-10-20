using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using static UnityEngine.EventSystems.EventTrigger;

public class AR2C1_FrameMove : MonoBehaviour
{
    public static AR2C1_FrameMove Instance;

    public GameObject Frame;
    public GameObject FrameMove;
    public GameObject Dia7;

    bool StartMove = false;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    void Update()
    {
        if (StartMove == true)
        {
            this.transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, -14) * Time.deltaTime * 4f;

            Invoke("StopFrameMove", 0.5f);
        }
    }

    public void StartFrameMove()
    {
        StartMove = true;
        FrameMove.SetActive(true);

        AR2C1_MovingManager.Instance.ClickFrame();
    }

    void StopFrameMove()
    {
        StartMove = false;

        Dia7.SetActive(true);

        Destroy(Frame.GetComponent<AR2C1_FrameMove>());
    }
}