using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public GameObject player;

    private Vector3 spawnPos;
    private float startDelay = 2f;
    private float repeatRate = 2f;

    void Start()
    {
        spawnPos = new Vector3(0, 0, 25f);
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
    }

    void SpawnObstacles()
    {
        int randomNum = Random.Range(0, obstaclePrefabs.Length);
        if (player != null)
        {
            Instantiate(obstaclePrefabs[randomNum], spawnPos, obstaclePrefabs[randomNum].transform.rotation);
        }
    }
}
