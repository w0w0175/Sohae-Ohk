using UnityEngine;

public class ItemCtrl : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }
}
