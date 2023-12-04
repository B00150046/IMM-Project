using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    private AudioLoop backgroundMusic;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name = "MainGame"){
            backgroundMusic = GetComponent<AudioLoop>();
            audioSource = GetComponent<AudioSource>();
            backgroundMusic.Play();
        }
        else
        {
            backgroundMusic.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.GetComponentByTag("Jewel")){
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }   
    }
}
