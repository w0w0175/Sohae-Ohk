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
            && Green.GetComponent<RectTransform>().anchoredPosition.y >= -65 && Green.GetComponent<RectTransform>().anchoredPosition.y <= -25) //만약 범위가 정답 범위일 경우

        {
            ER1C3_MoveManager.Instance.Q2Check = true;
        }
        else
        {
            ER1C3_MoveManager.Instance.Q2Check = false;
        }
    }
    public void OnPointerClick(PointerEventData eventData) //클릭했을 때 주변 범위에 초록색 상자를 만드는 함수
    {
        Green.SetActive(true);
        pos = eventData.position;
        pos = cam.ScreenToWorldPoint(pos);

        Green.transform.position = pos;
        SoundManager.instance.PlaySFX(Sfx.Click_UI);
    }


}
