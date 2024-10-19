using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR1C3_Key : MonoBehaviour
{
    public GameObject Dialogue;

    void OnEnable()
    {
        Dialogue.SetActive(false);
    }
}