using System.Collections;
using UnityEngine;

public class BugEnd : MonoBehaviour
{
    AudioSource ads;
    private void Awake()
    {
        ads = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        var bug = other.GetComponent<Bug>();
        if (bug != null)
        {
            StartCoroutine(Gamefail());
        }
    }

    IEnumerator Gamefail()
    {
        ads.Play();

        yield return new WaitForSeconds(2.5f);

        GameManager.instance.GameOver();
    }
}
