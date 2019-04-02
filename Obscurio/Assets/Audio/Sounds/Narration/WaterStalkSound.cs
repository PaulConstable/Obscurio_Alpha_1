using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterStalkSound : MonoBehaviour {


    public AudioClip speech1;
    public AudioSource audio;

    public bool audioPlayed;

    BeanGuyTrigger myBeanGuyTrigger;

    public void Start()
    {
        audio.GetComponent<AudioSource>();
        myBeanGuyTrigger = FindObjectOfType<BeanGuyTrigger>();

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && audioPlayed == false && myBeanGuyTrigger.WaterUsed == true)
        {
            audio.PlayOneShot(speech1, 1f);
            audioPlayed = true;
        }


    }
}
