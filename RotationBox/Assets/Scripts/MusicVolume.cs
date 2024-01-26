using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    [SerializeField] float musicVolume = 1f;
    [SerializeField] Slider slide;
    
    private AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            musicVolume = PlayerPrefs.GetFloat("MusicVolume");
            GetVolume();
        }
    }
    void Update()
    {
        audioSrc.volume = musicVolume;
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            musicVolume = PlayerPrefs.GetFloat("MusicVolume");
        }
    }
    public void SetVolume(float vol)
    {
        PlayerPrefs.SetFloat("MusicVolume", vol);
        musicVolume = PlayerPrefs.GetFloat("MusicVolume");
    }
    public void GetVolume()
    {
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
        slide.value = musicVolume;
    }
}

