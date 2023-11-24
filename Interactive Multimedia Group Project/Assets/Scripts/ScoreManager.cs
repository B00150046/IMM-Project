using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;
    public TextMeshProUGUI scoreKeeper;
    
    void Start()
    {
       UpdateScore(0);
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnTarget(){
        while(true){
            yield return new WaitForSeconds(1);
            UpdateScore(1);
        }
    }
    public void UpdateScore(int add){
        //score += scoreToAdd;
        scoreKeeper.text = "Score: " + score; 
    }
    
}
