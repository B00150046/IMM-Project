using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public int speed = 20;

    public int sprintSpeed = 40;

    public ParticleSystem dash;
    public AudioClip speedUp;
    public AudioClip coin;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

       coin = GetComponent<AudioClip>();

        speedUp = GetComponent<AudioClip>();
    }

    void Update()
    {   
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput * speed * Time.deltaTime, 0, verticalInput * speed * Time.deltaTime);
       transform.position = transform.position + movement;

       if(Input.GetKeyDown(KeyCode.Space)){
           // speedUp.isReadyToPlay();
              rb.AddForce(transform.forward * sprintSpeed, ForceMode.Impulse);
              transform.Translate(transform.position * sprintSpeed * Time.deltaTime);
       }

       // if ()
        //{
           // coin.Play();
        //    Destroy(this.gameObject);
       // }
    }

}