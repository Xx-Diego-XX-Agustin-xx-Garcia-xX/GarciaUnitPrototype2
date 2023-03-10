using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionDetector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
