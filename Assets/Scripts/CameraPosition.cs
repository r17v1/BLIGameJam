using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public int speed;
    public int distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = new Vector3(0, 0, distance);
        transform.position = Vector3.Lerp(transform.position, player.transform.position-dist, speed*Time.deltaTime);
    }
}
