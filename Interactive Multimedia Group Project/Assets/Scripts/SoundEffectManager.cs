using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{
    private AudioSource audioSource;
    private AudioSource run;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        run = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   
        // Play sound effect when player is moving
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        if(Input.GetKey(KeyCode.Space)){
            run.Play();
        }
        else
        {
            audioSource.Stop();
        }
        
    }
}
