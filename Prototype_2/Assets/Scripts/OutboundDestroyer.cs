using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutboundDestroyer : MonoBehaviour
{
    private float northBound = 35;
    private float southBound = -15;
    void Update()
    {
        if (transform.position.z > northBound)
        {
            Destroy(gameObject);
        } 
        else if (transform.position.z < southBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
