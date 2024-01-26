using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVolume : MonoBehaviour
{
    [SerializeField] float soundVolume = 1f;
    [SerializeField] Slider slide;

    private AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("SoundVolume"))
        {
            soundVolume = PlayerPrefs.GetFloat("SoundVolume");
            GetVolume();
        }
    }

    void Update()
    {
        audioSrc.volume = soundVolume;
        if (PlayerPrefs.HasKey("SoundVolume"))
        {
            soundVolume = PlayerPrefs.GetFloat("SoundVolume");
        }
    }
    public void SetVolume(float vol)
    {
        PlayerPrefs.SetFloat("SoundVolume", vol);
        soundVolume = PlayerPrefs.GetFloat("SoundVolume");
    }
    public void GetVolume()
    {
        PlayerPrefs.SetFloat("SoundVolume", soundVolume);
        slide.value = soundVolume;
    }
}
