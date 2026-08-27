using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private float health = 10;

    private NavMeshAgent agent;

    private Transform player;

    [SerializeField]
    private GameObject knife;

    [SerializeField]
    private List<Transform> patrolPoint = new List<Transform>();

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").transform;
        agent.stoppingDistance = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) <= 10)
        {
            agent.destination = player.position;
        }
        else
        {
            agent.destination = patrolPoint[0].position;
        }


        if (Vector3.Distance(transform.position, player.position) <= agent.stoppingDistance)
        {
            knife.SetActive(true);
        }
        else
        {
            knife.SetActive(false);
        }

    }

    public void TakeDamage(float value)
    {
        health -= value;
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
