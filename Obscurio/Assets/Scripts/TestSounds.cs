using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSounds : MonoBehaviour {

    [SerializeField] AudioSource NarrativeSound;
    [SerializeField] AudioSource SoundEffectsSound;
    [SerializeField] AudioSource MusicSound;

    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void playNarrative()
    {
        NarrativeSound.Play(0);
    }

    public void playSoundEffects()
    {
        SoundEffectsSound.Play(0);
    }

    public void playMusic()
    {
        MusicSound.Play(0);
    }
}
