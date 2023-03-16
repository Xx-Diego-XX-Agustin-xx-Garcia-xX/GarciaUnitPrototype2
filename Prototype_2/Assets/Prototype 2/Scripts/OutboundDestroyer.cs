using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutboundDestroyer : MonoBehaviour
{
    private float verticalBound = 25;
    private float horizontalBound = -25;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        if (transform.position.z > verticalBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        } 
        else if (transform.position.z < -verticalBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < horizontalBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > -horizontalBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
