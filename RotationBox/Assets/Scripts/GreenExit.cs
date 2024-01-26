using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenExit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Green" || collision.gameObject.tag == "RGB")
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Green" || collision.gameObject.tag == "RGB")
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
