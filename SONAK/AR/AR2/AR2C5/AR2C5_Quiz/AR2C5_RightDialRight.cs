using UnityEngine;
using UnityEngine.EventSystems;

public class AR2C5_RightDialRight : MonoBehaviour, IPointerClickHandler
{
    public static AR2C5_RightDialRight Instance;

    public static int num2 = 0;

    Collider2D col;

    public GameObject Flower2;
    public GameObject Heart2;
    public GameObject Water2;
    public GameObject Dia2;
    public GameObject Sun2;
    public GameObject Grass2;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        ResetDial();

        if (col == null)
        {
            col = gameObject.AddComponent<BoxCollider2D>();
        }
        col = GetComponent<Collider2D>();
        col.isTrigger = true;
    }

    void OnDisable()
    {
        ResetDial();
    }

    public void ResetDial()
    {
        num2 = 4;
        Heart2.SetActive(true);
        Flower2.SetActive(false);
        Water2.SetActive(false);
        Dia2.SetActive(false);
        Sun2.SetActive(false);
        Grass2.SetActive(false);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        else
        {
            ClickDialRight();
        }
    }
    public void ClickDialRight()
    {

        switch (num2)
        {
            case 0:
                Dia2.SetActive(true);
                Grass2.SetActive(false);
                num2 = 1;
                break;
            case 1:
                Dia2.SetActive(false);
                Water2.SetActive(true);
                num2 = 2;
                break;
            case 2:
                Flower2.SetActive(true);
                Water2.SetActive(false);
                num2 = 3;
                break;
            case 3:
                Sun2.SetActive(true);
                Flower2.SetActive(false);
                num2 = 4;
                break;
            case 4:
                Heart2.SetActive(true);
                Sun2.SetActive(false);
                num2 = 5;
                break;
            case 5:
                Grass2.SetActive(true);
                Heart2.SetActive(false);
                num2 = 0;
                break;
        }
    }
    }
