using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutboundDestroyer : MonoBehaviour
{
    private float verticalBound = 25;
    private float horizontalBound = -25;
    void Update()
    {
        if (transform.position.z > verticalBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        } 
        else if (transform.position.z < -verticalBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        else if (transform.position.x < horizontalBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        else if (transform.position.x < -horizontalBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
