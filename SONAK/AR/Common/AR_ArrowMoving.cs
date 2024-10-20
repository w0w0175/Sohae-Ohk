using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_ArrowMoving : MonoBehaviour
{
    Vector3 pos;
    float delta = 0.07f;
    float speed = 5.0f;

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        Vector3 v = pos;
        v.y += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}