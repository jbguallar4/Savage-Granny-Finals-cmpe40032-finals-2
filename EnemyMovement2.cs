using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement2 : MonoBehaviour
{

    public Transform target;
    NavMeshAgent agent;
    Animator anim; 
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);

        if(distance > 0.8)
        {
            agent.updatePosition = true;
            agent.SetDestination(target.position);  
            anim.SetTrigger("Running");
        }

        else
        {
            agent.updatePosition = false;
            anim.SetTrigger("Attack"); 
        }
    }
}
