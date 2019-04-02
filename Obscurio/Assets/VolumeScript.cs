using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class VolumeScript : MonoBehaviour {

    public AudioMixer NarratorMixer;
    public AudioMixer MusicMixer;
    public AudioMixer SoundMixer;

    public void SetNarratorLevel(float sliderValue)
    {
        NarratorMixer.SetFloat("NarratorVol", Mathf.Log10 (sliderValue) * 20);
    }

    public void SetMusicLevel(float sliderValue)
    {
        MusicMixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }

    public void SetSoundLevel(float sliderValue)
    {
        SoundMixer.SetFloat("SoundEffectsVol", Mathf.Log10(sliderValue) * 20);
    }
}
