using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public AudioClip startMenu;
    private AudioSource audio;

    private void Start()
    {
    // Start is called before the first frame update
    
        audio = gameObject.GetComponent<AudioSource>();
        //audio.clip = true;
        //audio.loop = true;
        //audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
