using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CollisionDetector : MonoBehaviour
{
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Doe"))
        {
            gameManager.AddScore(1);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Fox"))
        {
            gameManager.AddScore(2);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Horse"))
        {
            gameManager.AddScore(3);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Moose"))
        {
            gameManager.AddScore(4);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Stag"))
        {
            gameManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
