using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolume : MonoBehaviour
{
    [SerializeField] float musicVolume = 1f;

    private AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
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
}

