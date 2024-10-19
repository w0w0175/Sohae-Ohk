using UnityEngine;

public class AR1C3_KeyCheck : MonoBehaviour
{
    void Awake()
    {
        if (gameObject.GetComponent<AR1C3_Keymoving>() == null)
        {
            gameObject.AddComponent<AR1C3_Keymoving>();
        }
    }
}
