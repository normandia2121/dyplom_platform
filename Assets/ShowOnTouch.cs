using UnityEngine;

public class ShowOnTouch : MonoBehaviour
{
    public Sprite sprite1; // the first sprite to display
    public Sprite sprite2; // the second sprite to display

    void Start()
    {
        // set the initial sprite to sprite 2
        GetComponent<SpriteRenderer>().sprite = sprite2;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // switch to sprite 1 when the player touches this object
            GetComponent<SpriteRenderer>().sprite = sprite1;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // switch back to sprite 2 when the player moves away from this object
            GetComponent<SpriteRenderer>().sprite = sprite2;
        }
    }
}

