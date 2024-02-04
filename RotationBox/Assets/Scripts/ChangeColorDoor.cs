using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorDoor : MonoBehaviour
{
    [SerializeField] private Rotation rot;
    public GameObject Door;
    public int ColorIs = 1; //1-червоний, 2-зелений, 3-синій

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
                ColorIs = 3;
                break;
            case Color _ when Door.GetComponent<Renderer>().material.color == ColorBlue:
                Door.GetComponent<Renderer>().material.color = ColorRed;
                ColorIs = 1;
                break;
            case Color _ when Door.GetComponent<Renderer>().material.color == ColorRed:
                Door.GetComponent<Renderer>().material.color = ColorGreen;
                ColorIs = 2;
                break;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        switch(ColorIs)
        {
            case 1:
                if (collision.gameObject.tag == "Red" || collision.gameObject.tag == "RGB")
                {
                    GetComponent<BoxCollider2D>().enabled = false;
                }
                break;
            case 2:
                if (collision.gameObject.tag == "Green" || collision.gameObject.tag == "RGB")
                {
                    GetComponent<BoxCollider2D>().enabled = false;
                }
                break;
            case 3:
                if (collision.gameObject.tag == "Blue" || collision.gameObject.tag == "RGB")
                {
                    GetComponent<BoxCollider2D>().enabled = false;
                }
                break;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (ColorIs)
        {
            case 1:
                if (collision.gameObject.tag == "Red" || collision.gameObject.tag == "RGB")
                {
                    GetComponent<BoxCollider2D>().enabled = true;
                }
                break;
            case 2:
                if (collision.gameObject.tag == "Green" || collision.gameObject.tag == "RGB")
                {
                    GetComponent<BoxCollider2D>().enabled = true;
                }
                break;
            case 3:
                if (collision.gameObject.tag == "Blue" || collision.gameObject.tag == "RGB")
                {
                    GetComponent<BoxCollider2D>().enabled = true;
                }
                break;
        }
    }
}
