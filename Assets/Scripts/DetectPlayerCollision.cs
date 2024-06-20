using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerCollision : MonoBehaviour
{

    private int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        health--;

        if(health == 0) {
            Time.timeScale = 0;
            Debug.Log("Game Over!");
        } else {
            Destroy(other.gameObject);
            Debug.Log("Health: " + health);
        }

    }
}
