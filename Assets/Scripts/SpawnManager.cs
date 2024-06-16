using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    public int animalIndex;

    private float spawnRangeX = 18; 
    private float spawnPosZ = 21; 
    private float startDelay = 2f; 
    private float spawnInternal = 1.5f; 

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInternal);    //start at 2 seconds, invoke every 1.5 seconds
    }

    // Update is called once per frame
    void Update()
    {  

    }

    public void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
