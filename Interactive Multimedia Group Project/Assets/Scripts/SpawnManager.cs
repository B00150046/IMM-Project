using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public int enemyHealth = 3;
    
    private float spawnRange = 12;
    void Start()
    {   
      // EnemyWave();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void EnemyWave(int enemiesWave){
        for(int i = 0; i < enemiesWave; i++){
        Instantiate(enemy, GenerateSpawn(), enemy.transform.rotation);
        }
        
    }
    private Vector3 GenerateSpawn(){
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return spawnPos;
    }
    void OnCollision(Collision collision){
        if(collision.gameObject.CompareTag("Soldier")){
            enemyHealth -= 1;
        }
        if(collision.gameObject.CompareTag("Soldier")){
            Destroy(collision.gameObject);
        }
    }
}
