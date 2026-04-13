using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{   
public GameObject obstaclePrefab;

    [Header("Spawn Position Settings")]
    public float fixedX = 20f;    
    public float minY = -4.5f;       
    public float maxY = -2.6f;         
    public float fixedZ = 0f;      
    
    [Header("Timer Settings")]
    public float spawnRate = 1.5f;
    private float nextSpawnTime;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    void SpawnObject()
    {

        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPos = new Vector3(fixedX, randomY, fixedZ);


        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }

}
