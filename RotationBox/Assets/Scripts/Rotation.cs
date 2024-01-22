using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public int Money;

    [SerializeField] AudioClip rote;

    private Transform trans;
    public Box box;
    public Box box1;
    public Box box2;
    public Box box3;
    private int Grad = 0;

    void Awake()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            Money = PlayerPrefs.GetInt("Money");
        }
        PlayerPrefs.SetInt("Money", Money);
    }
    public void PlaySound()
    {
        GetComponent<AudioSource>().PlayOneShot(rote);
    }
    public void Right()
    {
        if (box.isStopped && box1.isStopped && box2.isStopped && box3.isStopped)
        {
            Grad -= 90;
            transform.rotation = Quaternion.Euler(0, 0, Grad);
            PlaySound();
        }
    }
    public void Left()
    {
        if (box.isStopped && box1.isStopped && box2.isStopped && box3.isStopped)
        {
            Grad += 90;
            transform.rotation = Quaternion.Euler(0, 0, Grad);
            PlaySound();
        }
    }
}

