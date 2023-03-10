using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float enemyRangeX = 20;
    private float enemyPosZ = 20;
    public float creationDelay;
    public float creationInterval;
    private float enemyRangeZ = 20;
    private float enemyPosX = 20;
    public GameObject[] enemyPrefabs;
    void Start()
    {
        InvokeRepeating("CreateRandomEnemyNorth", creationDelay, creationInterval);
    }
    void CreateRandomEnemyNorth()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 enemyPos = new Vector3(Random.Range(-enemyRangeX, enemyRangeX), 0, enemyPosZ);
        Instantiate(enemyPrefabs[enemyIndex], enemyPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
    void CreateRandomEnemySouth()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 enemyPos = new Vector3(Random.Range(-enemyRangeX, enemyRangeX), 0, -enemyPosZ);
        Vector3 rotation = new Vector3(0, 180, 0);
        Instantiate(enemyPrefabs[enemyIndex], enemyPos, Quaternion.Euler(rotation));
    }
    void CreateRandomEnemyWest()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 enemyPos = new Vector3(-enemyPosX, 0, Random.Range(-enemyRangeZ, enemyRangeZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(enemyPrefabs[enemyIndex], enemyPos, Quaternion.Euler(rotation));
    }
    void CreateRandomEnemyEast()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 enemyPos = new Vector3(-enemyPosX, 0, Random.Range(-enemyRangeZ, enemyRangeZ));
        Vector3 rotation = new Vector3(0, 270, 0);
        Instantiate(enemyPrefabs[enemyIndex], enemyPos, Quaternion.Euler(rotation));
    }
}
