using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabsUp;
    public int animalIndex_Up;
    private float spawnRangeX_Up = 18; 
    private float spawnPosZ_Up = 21; 

    public GameObject[] animalPrefabsLeft;
    public int animalIndex_Left;
    private float spawnPosX_Left = -30;   
    private float spawnRangeZ_min = 2; 
    private float spawnRangeZ_max = 15;

    public GameObject[] animalPrefabsRight;
    public int animalIndex_Right;
    private float spawnPosX_Right = 30;   

    private float startDelay = 1f; 
    private float spawnInternal = 5f; 

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalUp", startDelay, spawnInternal);    //start at 2 seconds, invoke every 1.5 seconds
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInternal);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInternal);
    }

    // Update is called once per frame
    void Update()
    {  

    }

    public void SpawnRandomAnimalUp()
    {
        Vector3 spawnPosUp = new Vector3(Random.Range(-spawnRangeX_Up, spawnRangeX_Up), 0, spawnPosZ_Up);
        animalIndex_Up = Random.Range(0, animalPrefabsUp.Length);
        Instantiate(animalPrefabsUp[animalIndex_Up], spawnPosUp, animalPrefabsUp[animalIndex_Up].transform.rotation);
    }

    public void SpawnRandomAnimalLeft()
    {
        Vector3 spawnPosLeft = new Vector3(spawnPosX_Left, 0, Random.Range(spawnRangeZ_min, spawnRangeZ_max));
        animalIndex_Left = Random.Range(0, animalPrefabsLeft.Length);
        Instantiate(animalPrefabsLeft[animalIndex_Left], spawnPosLeft, animalPrefabsLeft[animalIndex_Left].transform.rotation);
    }

    public void SpawnRandomAnimalRight()
    {
        Vector3 spawnPosRight = new Vector3(spawnPosX_Right, 0, Random.Range(spawnRangeZ_min, spawnRangeZ_max));
        animalIndex_Right = Random.Range(0, animalPrefabsRight.Length);
        Instantiate(animalPrefabsRight[animalIndex_Right], spawnPosRight, animalPrefabsRight[animalIndex_Right].transform.rotation);

    }

}
