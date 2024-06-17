using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnCooldown = 3f; // Spawn işlemi için gerekli minimum bekleme süresi
    private float lastSpawnTime; // Son köpek yaratma zamanını takip eder


    void Start()
    {
        lastSpawnTime = -spawnCooldown; // Oyunun başında köpek yaratılabilmesi için başlangıç zamanı
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= lastSpawnTime + spawnCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastSpawnTime = Time.time; // Son spawn zamanını güncelle
        }
    }
}
