using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player, target;
    public float detectionDistance;
    Vector3 initialPosition;
    NavMeshAgent agent;
    Animator anim;
    public bool toTarget = true;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        anim = GetComponent<Animator>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        float distance = (player.position - transform.position).magnitude;

        Vector3 currentTarget;
        float stoppingDistance=0;
        
        if( distance <= detectionDistance) 
        {
            currentTarget = player.position;
            stoppingDistance = 8f;
        }
        else if(toTarget)
        {
            currentTarget = target.position;
            stoppingDistance = 0f;
        }
        else
        {
            currentTarget = initialPosition;
            stoppingDistance = 0f;
        }

        agent.stoppingDistance = stoppingDistance;
        agent.SetDestination(currentTarget);
           

        Vector2 velocity = new Vector2(agent.velocity.x, agent.velocity.y).normalized;
        if (velocity.magnitude > 0)
        {

            transform.rotation = Quaternion.Euler(0f, 0f, Helper.VelocityToAngle(velocity));
            anim.SetBool("moving", true);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, 0f, Helper.VelocityToAngle(currentTarget - transform.position));
            anim.SetBool("moving", false);
        }

        float dtt =(target.position.x - transform.position.x) * (target.position.x - transform.position.x) + (target.position.y - transform.position.y) * (target.position.y - transform.position.y);
        if (dtt < 0.1)
            toTarget = false;
        dtt = (initialPosition.x - transform.position.x) * (initialPosition.x - transform.position.x) + (initialPosition.y - transform.position.y) * (initialPosition.y - transform.position.y);
        if (dtt < 0.1)
            toTarget = true;
    }
}


