using UnityEngine;
using UnityEngine.UI;

public class FishCtrl : MonoBehaviour
{
    public float hitRate;
    public float damageRate;
    public float catchRate;

    public Image imgHP;

    private void OnCollisionEnter(Collision collision) //생선이 물체와 충돌했을 때
    {
        if (collision.collider.tag != "Rod") //바구니일 경우
        {
            return;
        }

        if (Random.Range(0.0f, 1.0f) < hitRate)
        {
            imgHP.fillAmount -= damageRate; //HP바 감소

            if (imgHP.fillAmount <= 0.001f)
            {
                if (Random.Range(0.0f, 1.0f) < catchRate)
                {
                    Stage2Manager.instance.AddCatch(); //잡았을 때
                }
                else
                {
                    ProgressManager.instance.PopupMsg("에구구 놓쳤네", 2); //놓쳤을 때
                }
                gameObject.SetActive(false);

                Invoke("ChangePos", Random.Range(1.5f, 2.0f)); //잡았을 때 랜덤으로 위치 변경해서 다시 리스폰
            }
            else
            {
                print("명중"); //생선이 제대로 맞았을 때 (HP바가 줄어듦으로 따로 안내창은 없음)
            } 
        }
        else
        {
            ProgressManager.instance.PopupMsg("앗 제대로 안 맞았네", 1); //안 맞았을 때 오류라고 생각할 수도 있으므로 안내
        }
    }

    void ChangePos()
    {
        gameObject.SetActive(true);
        imgHP.fillAmount = 1.0f;

        Vector3 pos;
        pos.x = Random.Range(-0.2f, 0.2f);
        pos.y = 0;
        pos.z = Random.Range(-0.2f, 0.2f);

        transform.localPosition = pos;
    }
}
