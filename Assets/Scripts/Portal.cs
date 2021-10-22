using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform exitPortal;

    public void Teleport(GameObject player)
    {
        player.transform.position = exitPortal.position;
        player.transform.Translate(new Vector3(1.55f, 0, 0));
    }
}
