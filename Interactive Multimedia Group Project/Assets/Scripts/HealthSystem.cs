using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
   

    public int maxhealth = 5;
    public int health;
    public GameObject jem;

    public ParticleSystem explode;
    public AudioClip gameOver;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        jem = GameObject.Find("Jewel");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
public void OnCollision(Collision collision){
     if(collision.gameObject.CompareTag("Enemy")){
           TakeDamage();
        }
        if(health <= 0){
            Destroy(gameObject);
           
        }
}
public void TakeDamage(){
    health -= 1;
}
}
