using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockLevel : MonoBehaviour
{
    private int lastCompletedLvl = 1;
    public int ThisLevel = 0;
    public GameObject Lock;
    void Start()
    {
        if (PlayerPrefs.HasKey("LastCompletedLvl"))
        {
            lastCompletedLvl = PlayerPrefs.GetInt("LastCompletedLvl");
        }
        lastCompletedLvl = PlayerPrefs.GetInt("LastCompletedLvl");
    }

    void Update()
    {
        if(ThisLevel <= lastCompletedLvl)
        {
            Lock.SetActive(false);
        }
    }
}
