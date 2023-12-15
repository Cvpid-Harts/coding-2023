using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{

    public float speed = 10.0f;
    public float horizontalInput;
    public float verticalInput;
    public float xRange = 10.0f;
    public float zRange = 10.0f;
    public GameObject projectilePrefab; 

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);



        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        { 
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);


        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        { 
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
    
        }

        if(Input.GetKeyDown(KeyCode.Space))

        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}