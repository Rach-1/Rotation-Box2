using UnityEngine;

public class Exits : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Green" || collision.gameObject.tag == "GreenExit")
            GetComponent<BoxCollider2D>().enabled = false;
        else if(collision.gameObject.tag == "Gray" || collision.gameObject.tag == "GrayExit")
            GetComponent<BoxCollider2D>().enabled = false;
        else if(collision.gameObject.tag == "Blue" || collision.gameObject.tag == "BlueExit")
            GetComponent<BoxCollider2D>().enabled = false;
        else if(collision.gameObject.tag == "Red" || collision.gameObject.tag == "RedExit")
            GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Green" || collision.gameObject.tag == "GreenExit")
            GetComponent<BoxCollider2D>().enabled = true;
        else if(collision.gameObject.tag == "Gray" || collision.gameObject.tag == "GrayExit")
            GetComponent<BoxCollider2D>().enabled = true;
        else if(collision.gameObject.tag == "Blue" || collision.gameObject.tag == "BlueExit")
            GetComponent<BoxCollider2D>().enabled = true;
        else if(collision.gameObject.tag == "Red" || collision.gameObject.tag == "RedExit")
            GetComponent<BoxCollider2D>().enabled = true;
    }
}