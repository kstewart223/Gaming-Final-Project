using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{   
    [Header("Inscribed")]
    public GameObject obstaclePrefab;

    [Header("Spawn Position Settings")]
    public float fixedX = 20f;    
    public float minY = 3.6f;       
    public float maxY = 7.5f;         
    public float fixedZ = 21f;
    public static float cloudSpeed = 3f;      
    
    [Header("Timer Settings")]
    public float spawnRate = 5.5f;
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
        //int ndx = Random.Range(0, obstaclePrefab.Length);
        
        float randomY = Random.Range(minY, maxY);
        // if(ndx == 2)
        // {
        //     minY = -1.79f;
        // } else
        // {
        //     minY = -4.5f;
        // }
        
        Vector3 spawnPos = new Vector3(fixedX, randomY, fixedZ);
        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }

}
