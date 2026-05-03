using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{   
    
    public static Obstacles instance; 
    
    [Header("Inscribed")]
    public GameObject[] obstaclePrefab;

    [Header("Spawn Position Settings")]
    public float fixedX = 20f;    
    public float minY = -4.5f;       
    public float maxY = -2.6f;         
    public float fixedZ = 0f;
    
    [Header("Speed")]
    public float obstacleSpeed = 10f;
    public float maxSpeed = 30f;
    public float multSpeed = 0.1f;      
    
    [Header("Timer Settings")]
    public float spawnRate = 1.5f;
    private float nextSpawnTime;
    int score = 0;

    void Awake() 
    {
        // Link this specific object to the bridge
        if (instance == null) instance = this;
    }
    
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + spawnRate;
        }
        Calculate();
    }

    void SpawnObject()
    {
        int ndx = Random.Range(0, obstaclePrefab.Length);
        
        // float randomY = Random.Range(minY, maxY);
        if(ndx == 2)
        {
            minY = 0f;
        } else
        {
            minY = -4.5f;
        }
        
        Vector3 spawnPos = new Vector3(fixedX, minY, fixedZ);
        Instantiate(obstaclePrefab[ndx], spawnPos, Quaternion.identity);
    }

    void Calculate()
    {
        if((score != ScoreCounter.Instance.score) && (obstacleSpeed <= maxSpeed) )
        {
            obstacleSpeed += ScoreCounter.Instance.score * 0.05f;
            score = ScoreCounter.Instance.score;
        }
    }

}
