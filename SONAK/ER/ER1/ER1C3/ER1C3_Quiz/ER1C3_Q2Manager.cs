using UnityEngine;
using UnityEngine.EventSystems;

public class ER1C3_Q2Manager : MonoBehaviour, IPointerClickHandler
{
    public GameObject Green;
    Vector2 pos;
    Camera cam;
    void OnDisable()
    {
        Green.SetActive(false);
    }
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        Green = transform.GetChild(0).gameObject;
    }
    void Update()
    {
        if (Green.activeSelf && Green.GetComponent<RectTransform>().anchoredPosition.x >= -150 && Green.GetComponent<RectTransform>().anchoredPosition.x <= -110
            && Green.GetComponent<RectTransform>().anchoredPosition.y >= -65 && Green.GetComponent<RectTransform>().anchoredPosition.y <= -25)

        {
            ER1C3_MoveManager.Instance.Q2Check = true;
        }
        else
        {
            ER1C3_MoveManager.Instance.Q2Check = false;
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Green.SetActive(true);
        pos = eventData.position;
        pos = cam.ScreenToWorldPoint(pos);

        Green.transform.position = pos;
        SoundManager.instance.PlaySFX(Sfx.Click_UI);
    }


}
