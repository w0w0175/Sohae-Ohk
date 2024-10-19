using UnityEngine;

public class AR2C1_Dia7Move : MonoBehaviour
{
    public static AR2C1_Dia7Move Instance;
    bool StartMove = false;
    bool MoveCheck = false;

    public bool IsEndMoving = false;

    public GameObject Dia7;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    void Update()
    {
        if (StartMove == true)
        {
            this.transform.position = this.transform.position + new Vector3(0, -1, 0) * Time.deltaTime * 1.5f;

            Invoke("StopDia7Move", 0.6f);
        }
    }

    void OnEnable()
    {
        IsEndMoving = false;
        if (MoveCheck == false)
        {
            StartMove = true;
            MoveCheck = true;
        }
    }

    void StopDia7Move()
    {
        StartMove = false;
        Invoke("EndMove", 0.4f);
    }
    public void EndMove()
    {
        AR2C1_MovingManager.Instance.isusing = false;
        IsEndMoving = true;
        Destroy(Dia7.GetComponent<AR2C1_Dia7Move>());
    }
}