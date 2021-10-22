using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerObj;
    public Transform target;
    public float detectionDistance, shootingDistance;
    Vector3 initialPosition;
    NavMeshAgent agent;
    Animator anim;
    ProjectileSpawner projectileSpawner;
    public bool toTarget = true;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        anim = GetComponent<Animator>();
        initialPosition = transform.position;
        projectileSpawner = GetComponentInChildren<ProjectileSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform player = playerObj.transform;
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

        if (distance <= shootingDistance)
        {
            projectileSpawner.shoot();
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


