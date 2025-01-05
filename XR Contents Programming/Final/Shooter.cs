using System.Collections;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public LayerMask hittableMask;

    float shootDelay = 0.1f;
    float maxDistance = 50f;

    private void Start()
    {
        //StartCoroutine(ShootProcess());
    }
    IEnumerator ShootProcess()
    {
        var wfs = new WaitForSeconds(shootDelay);

        while (true)
        {
            Shoot();
            yield return wfs;
        }
    }

    public void Shoot()
    {
        if (Physics.Raycast(
            transform.position, transform.forward,
            out RaycastHit hitInfo, maxDistance, hittableMask))
        {
            var hitObject = hitInfo.transform.GetComponent<Hittable>();
            hitObject?.Hit();
        }
    }
}
