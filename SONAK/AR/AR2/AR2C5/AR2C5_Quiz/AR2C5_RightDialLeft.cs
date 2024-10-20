using UnityEngine;
using UnityEngine.EventSystems;

public class AR2C5_RightDialLeft : MonoBehaviour, IPointerClickHandler
{
    public static AR2C5_RightDialLeft Instance;
    
    static int num1 = 0;

    Collider2D col;

    public GameObject Flower1;
    public GameObject Heart1;
    public GameObject Water1;
    public GameObject Dia1;
    public GameObject Sun1;
    public GameObject Grass1;

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
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Input.touchCount > 1)
            return;
        else
        {
            ClickDialLeft();
        }
    }
    public void ResetDial()
    {
        num1 = 2;
        Heart1.SetActive(false);
        Flower1.SetActive(true);
        Water1.SetActive(false);
        Dia1.SetActive(false);
        Sun1.SetActive(false);
        Grass1.SetActive(false);
    }
    public void ClickDialLeft()
    {

        switch (num1)
        {
            case 0:
                Dia1.SetActive(true);
                Grass1.SetActive(false);
                num1 = 1 ;
                break;
            case 1:
                Dia1.SetActive(false);
                Water1.SetActive(true);
                num1 = 2;
                break;
            case 2:
                Flower1.SetActive(true);
                Water1.SetActive(false);
                num1 = 3;
                break;
            case 3:
                Sun1.SetActive(true);
                Flower1.SetActive(false);
                num1 = 4;
                break;
            case 4:
                Heart1.SetActive(true);
                Sun1.SetActive(false);
                num1 = 5;
                break;
            case 5:
                Grass1.SetActive(true);
                Heart1.SetActive(false);
                num1 = 0;
                break;
        }
    }
}
