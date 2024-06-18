using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private float rangeH = 18.0f;
    private float rangeVmin = 0.4f;
    private float rangeVmax = 15.0f;

    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > rangeH)
        {
            transform.position = new Vector3(rangeH, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -rangeH)
        {
            transform.position = new Vector3(-rangeH, transform.position.y, transform.position.z);
        }

        if(transform.position.z > rangeVmax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rangeVmax);
        }

        if(transform.position.z < rangeVmin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rangeVmin);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    
    }
}
