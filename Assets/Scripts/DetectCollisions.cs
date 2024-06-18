using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
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
        if(gameObject.tag == "Player" || other.tag == "Player")
        {
            Debug.Log("Game Over!");
            Time.timeScale = 0;
        } else {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}
