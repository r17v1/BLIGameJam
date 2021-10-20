using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlls : MonoBehaviour
{
    // Start is called before the first frame update
  
    //float angle = 0;
    Movement movement;
    ProjectileSpawner projectileSpawner;
    bool shooting=false;
    void Start()
    {
        movement = GetComponent<Movement>();
        projectileSpawner = GetComponentInChildren<ProjectileSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector2 moveDir = new Vector2(horizontal, vertical).normalized;
        movement.Move(moveDir,shooting);
        

        if (Input.GetAxis("Fire1") > 0)
        {
            projectileSpawner.shoot();
            shooting = true;
        }
        else if (Input.GetAxis("Fire2") > 0)
        {
            projectileSpawner.specialAttack();
            shooting = true;
        }
        else
        {
            shooting = false;
        }

        if (moveDir.magnitude > 0 && !shooting)
            movement.Rotate(Helper.VelocityToAngle(moveDir));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Portal")
        {
            transform.position = collision.gameObject.GetComponent<Portal>().exitPortal.position;
            transform.Translate(new Vector3(2.3f, 0, 0));
        }
    }
}
