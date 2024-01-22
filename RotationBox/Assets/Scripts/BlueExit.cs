using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueExit : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blue")
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blue")
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
