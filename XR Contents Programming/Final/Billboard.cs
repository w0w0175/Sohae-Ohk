using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform camTr;

    void LateUpdate()
    {
        transform.LookAt(transform.position +  (camTr.rotation * Vector3.forward));
    }
}
