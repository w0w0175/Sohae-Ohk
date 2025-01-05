using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    float spider = 0;

    private void Awake()
    {
        spider = Random.Range(15f, 21f);
    }

    void Start()
    {
        StartCoroutine(SpiderSpawn());
    }

    IEnumerator SpiderSpawn()
    {
        while (true) 
        {
            yield return new WaitForSeconds(spider);

            spider = Random.Range(15f, 21f);
            Instantiate(prefab, transform.position, transform.rotation, transform);
        }
        
    }
}
