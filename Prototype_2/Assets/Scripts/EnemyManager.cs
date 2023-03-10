using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float enemyRange = 20;
    private float enemyPosZ = 20;
    public float creationDelay;
    public float creationInterval;
    public float createHorizontalZ;
    public float createHorizontalX;
    public GameObject[] enemyPrefabs;
    void Start()
    {
        InvokeRepeating("CreateRandomEnemy", creationDelay, creationInterval);
    }
    void CreateRandomEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 enemyPos = new Vector3(Random.Range(-enemyRange, enemyRange), 0, enemyPosZ);
        Instantiate(enemyPrefabs[enemyIndex], enemyPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
    void CreateRandomEnemyLeft()
    {

    }
    void CreateRandomEnemyRight()
    {

    }
}
