using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public static bool _isGround;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground") _isGround = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground") _isGround = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground") _isGround = false;
    }
}
