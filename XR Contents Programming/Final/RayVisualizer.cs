using System.Collections;
using UnityEngine;

public class RayVisualizer : MonoBehaviour
{
    public LineRenderer ray;
    public LayerMask hitRayMask;
    float distance = 100f;

    public GameObject reticleP;
    public bool showReticle = true;

    private void Awake()
    {
        On();
    }

    public void On()
    {
        StartCoroutine(RayProcess());
    }
    public void Off()
    {
        StopCoroutine(RayProcess());

        ray.enabled = false;
        reticleP.SetActive(false);
    }

    IEnumerator RayProcess()
    {
        while (true)
        {
            if (Physics.Raycast(
                transform.position, transform.forward,
                out RaycastHit hitInfo, distance, hitRayMask))
            {
                ray.SetPosition(1, transform.InverseTransformPoint(hitInfo.point));
                ray.enabled = true;

                reticleP.transform.position = hitInfo.point;
                reticleP.SetActive(showReticle);
            }
            else
            {
                ray.enabled = false;
                reticleP.SetActive(false);
            }

            yield return null;
        }
    }
}
