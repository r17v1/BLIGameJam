using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public float speedWhileShooting = 5f;
    public float animationSpeedNormal = 0.8f, amimationSpeedShooting = 0.4f;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector2 direction,bool shooting)
    {
        float currentSpeed = shooting ? speedWhileShooting : speed;
        float animatorSpeed = shooting ? amimationSpeedShooting : animationSpeedNormal;
        anim.speed = animatorSpeed;
        Vector2 moveVal = direction * currentSpeed * Time.deltaTime;
        transform.Translate(moveVal, Space.World);
        anim.SetBool("moving", moveVal.magnitude > 0f ? true : false);
    }
    public void Rotate(float angle)
    {
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
