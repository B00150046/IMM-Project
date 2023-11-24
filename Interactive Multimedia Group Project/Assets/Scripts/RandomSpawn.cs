using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] enemies;
    public float spawnTimer;
    void Start()
    {
        StartCoroutine(spawnTarget());
    }
    IEnumerator spawnTarget(){
        while(true){
            yield return new WaitForSeconds(1);
            int index = Random.Range(0, enemies.Length);
            Instantiate(enemies[index], new Vector3(Random.Range(-25,25), 0, Random.Range(-25,25)), enemies[index].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTimer > 0){
            spawnTimer -= Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.D) && spawnTimer == 0){
            spawnTarget();
        }
        
    }
}
