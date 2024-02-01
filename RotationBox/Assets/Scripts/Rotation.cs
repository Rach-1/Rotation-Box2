using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public int Money;
    public bool IsRot;

    [SerializeField] AudioClip rote;

    private Transform trans;
    public Box box;
    public Box box1;
    public Box box2;
    public Box box3;
    public Box box4;
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
        IsRot = false;
    }
    public void Right()
    {
        if (box.isStopped && box1.isStopped && box2.isStopped && box3.isStopped && box4.isStopped)
        {
            IsRot = true;
            Grad -= 90;
            transform.rotation = Quaternion.Euler(0, 0, Grad);
            PlaySound();
        }
    }
    public void Left()
    {
        if (box.isStopped && box1.isStopped && box2.isStopped && box3.isStopped && box4.isStopped)
        {
            IsRot = true;
            Grad += 90;
            transform.rotation = Quaternion.Euler(0, 0, Grad);
            PlaySound();
        }
    }
}

