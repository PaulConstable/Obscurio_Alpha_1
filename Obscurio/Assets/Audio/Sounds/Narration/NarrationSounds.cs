using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrationSounds : MonoBehaviour {

    public AudioClip speech1;
    public AudioSource audio;

    public bool audioPlayed;

    public void Start()
    {
        audio.GetComponent<AudioSource>();
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && audioPlayed == false)
        {
            audio.PlayOneShot(speech1, 1f);
            audioPlayed = true;
        }
            
        
    }



}
