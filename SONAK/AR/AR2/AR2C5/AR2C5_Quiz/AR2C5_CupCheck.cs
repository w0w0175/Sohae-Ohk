using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AR2C5_CupCheck : MonoBehaviour
{
    void Awake()
    {
        if (gameObject.name == "Answer_1")
        {
            if (gameObject.GetComponent<AR2C5_CupDrop1>() == null)
            {
                gameObject.AddComponent<AR2C5_CupDrop1>();
            }
        }
        else if (gameObject.name == "Answer_2")
        {
            if (gameObject.GetComponent<AR2C5_CupDrop2>() == null)
            {
                gameObject.AddComponent<AR2C5_CupDrop2>();
            }
        }
        else if (gameObject.name == "Answer_3")
        {
            if (gameObject.GetComponent<AR2C5_CupDrop3>() == null)
            {
                gameObject.AddComponent<AR2C5_CupDrop3>();
            }
        }
    }
}
