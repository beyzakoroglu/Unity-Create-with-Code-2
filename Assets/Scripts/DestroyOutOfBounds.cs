using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBound = 30.0f;
    public float lowerBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 50) 
        {
            Destroy(gameObject);
        } else if(transform.position.z < -10) {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }


    }
}
