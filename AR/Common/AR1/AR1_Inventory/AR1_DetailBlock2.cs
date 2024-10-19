using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AR1_DetailBlock2 : MonoBehaviour
{
    public GameObject Inv_Block;

    void OnEnable()
    {
        Inv_Block.SetActive(true);
    }

    private void OnDisable()
    {
        Inv_Block.SetActive(false);
    }
}