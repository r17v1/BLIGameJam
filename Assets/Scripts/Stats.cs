using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject explosion;
    public float health;
    public bool alive = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            alive = false;
            if (gameObject.tag == "Enemy")
            {
                GameObject explosionGameObject = Instantiate(explosion, transform.position, transform.rotation);
                Destroy(gameObject);
                Destroy(explosionGameObject, 2);
            }
        }
    }
}
