using UnityEngine;
using UnityEngine.EventSystems;
public class AR1C1_KeyAnswer : MonoBehaviour, IDropHandler
{
    public static AR1C1_KeyAnswer Instance;

    public bool isKeyTouched = false;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().localPosition = new Vector2(297, 278);
            AR1_Block.UsingItem = false;
            SoundManager.instance.PlaySFX(Sfx.Sliding_Door);
            AR1C1_MovingManager.Instance.ToSecretRoom();

            isKeyTouched = true;
        }
    }
}

