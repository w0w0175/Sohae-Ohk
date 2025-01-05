using UnityEngine;
using UnityEngine.AI;

public class Bug : MonoBehaviour
{
    NavMeshAgent agent;
    Animator animator;
    AudioSource ads;

    bool isDestroy = false;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        ads = GetComponent<AudioSource>();
    }

    void Start()
    {
        agent.SetDestination(new Vector3(1.229f, 0.6f, 1.15f));
        agent.speed *= Random.Range(0.01f, 0.06f);
    }

    public void Destroyed()
    {
        if (isDestroy)
            return;
        isDestroy = true;

        agent.enabled = false;
        animator.SetBool("IsDestroyed", true);
        ads.Play();

        Destroy(gameObject, 3);
    }
}
