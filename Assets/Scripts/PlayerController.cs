using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float range = 11.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > range)
        {
            transform.position = new Vector3(range, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -range)
        {
            transform.position = new Vector3(-range, transform.position.y, transform.position.z);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}