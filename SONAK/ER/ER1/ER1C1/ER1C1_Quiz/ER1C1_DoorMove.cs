using UnityEngine;

public class ER1C1_DoorMove : MonoBehaviour
{
    public static ER1C1_DoorMove Instance;
    
    public GameObject BearDoor;

    public bool StartMove = false;
    public bool BackMove = false;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(Instance);
    }
    void Update()
    {
        if (StartMove == true)
        {
            this.transform.position = this.transform.position + new Vector3(-5.15f, 0, 0) * Time.deltaTime * 1.2f;

            Invoke("StopMove1", 0.6f);
        }

        if (BackMove == true)
        {
            this.transform.position = new Vector3(5, 0, 0);

            StopMove2();
        }
    }

    void StopMove1()
    {
        StartMove = false;
    }

    void StopMove2()
    {
        BackMove = false;
    }
}