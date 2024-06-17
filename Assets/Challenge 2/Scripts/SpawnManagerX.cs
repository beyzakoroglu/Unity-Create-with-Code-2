﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private int randomIndex;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    //private float spawnInterval = 01.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);   // InvokeRepeating: Belirli bir süre sonra bir metodun çalışmasını 
                                                 // başlatır ve sonrasında belirli aralıklarla tekrar tekrar çalışmasını
                                                 // sağlar

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        randomIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[0].transform.rotation);

        // Generate random spawn interval between 3 and 5 seconds
        float randomSpawnInterval = Random.Range(3.0f, 5.0f);

        // Call SpawnRandomBall again after randomSpawnInterval seconds
        Invoke("SpawnRandomBall", randomSpawnInterval);   // Belirli bir süre sonra bir metodun sadece bir kez çalışmasını sağlar.
                                                          
    }

}
