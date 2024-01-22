using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void Start()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
