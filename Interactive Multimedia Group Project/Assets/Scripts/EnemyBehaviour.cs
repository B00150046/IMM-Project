using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyrb;
    private GameObject Jem;
    // Start is called before the first frame update
    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        Jem = GameObject.Find("Jewel");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lockOn = (Jem.transform.position - transform.position).normalized;
        enemyrb.AddForce(lockOn * speed);
        if(transform.position.y < -10){
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
    public void DamageJewel(){
        Jem.GetComponent<HealthSystem>();
    }
}
