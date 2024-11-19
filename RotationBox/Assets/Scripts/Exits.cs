using UnityEngine;

public class Exits : MonoBehaviour
{
    [SerializeField] string color;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == color || collision.gameObject.tag == "RGB")
            GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == color || collision.gameObject.tag == "RGB")
            GetComponent<BoxCollider2D>().enabled = true;
    }
}