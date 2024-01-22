using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVolume : MonoBehaviour
{
    [SerializeField] float soundVolume = 1f;

    private AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
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
}
