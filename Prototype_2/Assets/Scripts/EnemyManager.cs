using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int enemyIndex;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(enemyPrefabs[enemyIndex], new Vector3(0, 0, 20), enemyPrefabs[enemyIndex].transform.rotation);
        }
    }
}
