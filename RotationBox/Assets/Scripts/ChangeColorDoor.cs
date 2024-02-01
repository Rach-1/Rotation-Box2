using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorDoor : MonoBehaviour
{
    [SerializeField] private Rotation rot;
    public GameObject Door;
    private Color ColorGreen = new Color(156f / 255f, 218f / 255f, 119f / 255f, 1f);
    private Color ColorBlue = new Color(143f / 255f, 106f / 255f, 212f / 255f, 1f);
    private Color ColorRed = new Color(211f / 255f, 76f / 255f, 147f / 255f, 1f);
    void Start()
    {
        Door.GetComponent<Renderer>().material.color = ColorRed; //початковий колір
    }
    public void ColorSwitch() //змінює кольори пропуску
    {
        switch (Door.GetComponent<Renderer>().material.color) 
        {
            case Color _ when Door.GetComponent<Renderer>().material.color == ColorGreen:
                Door.GetComponent<Renderer>().material.color = ColorBlue;
                break;
            case Color _ when Door.GetComponent<Renderer>().material.color == ColorBlue:
                Door.GetComponent<Renderer>().material.color = ColorRed;
                break;
            case Color _ when Door.GetComponent<Renderer>().material.color == ColorRed:
                Door.GetComponent<Renderer>().material.color = ColorGreen;
                break;
        }
    }
}
