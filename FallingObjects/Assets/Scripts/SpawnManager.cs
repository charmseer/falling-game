using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fruitPrefabs;
    private float spawnRangeX = 7.5f;
    private float spawnPosZ = 8.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
 
        
    }
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int fruitIndex = Random.Range(0, fruitPrefabs.Length);
        Instantiate(fruitPrefabs[fruitIndex], spawnPos, fruitPrefabs[fruitIndex].transform.rotation);
    }
}
