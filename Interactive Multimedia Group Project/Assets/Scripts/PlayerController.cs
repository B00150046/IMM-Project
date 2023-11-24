using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public int speed = 20;

    public int sprintSpeed = 40;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {   
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput * speed * Time.deltaTime, 0, verticalInput * speed * Time.deltaTime);
       transform.position = transform.position + movement;

       if(Input.GetKeyDown(KeyCode.Space)){
              rb.AddForce(transform.forward * sprintSpeed, ForceMode.Impulse);
              transform.Translate(transform.position * sprintSpeed * Time.deltaTime);
       }    
    }

}