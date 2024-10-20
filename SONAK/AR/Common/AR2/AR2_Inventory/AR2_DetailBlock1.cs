using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AR2_DetailBlock1 : MonoBehaviour
{
    void OnEnable()
    {
        AR2_Close.UsingItem = true;
    }

    private void OnDisable()
    {
        AR2_Close.UsingItem = false;
    }
}