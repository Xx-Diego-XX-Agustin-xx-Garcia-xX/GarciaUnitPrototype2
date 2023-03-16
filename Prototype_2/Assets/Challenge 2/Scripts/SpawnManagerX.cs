using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float startDelay = 1.0f;
    private float minSpawnInterval = 2.5f;
    private float maxSpawnInterval = 5f;
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }
    void SpawnRandomBall ()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
    Invoke("SpawnRandomBall", spawnInterval);
    }
}