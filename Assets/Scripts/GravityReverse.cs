using UnityEngine;

public class GravityReverse : MonoBehaviour
{
    [SerializeField] GameObject _player;
    private Rigidbody2D _rb;

    public static bool _top;

    private void Start()
    {
        _rb = _player.GetComponent<Rigidbody2D>();
    }
    public void GravityChanged()
    {
        if (_top)
        {
            _top = false;
        } else _top = true;
        _rb.gravityScale *= -1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GravityChanged();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GravityChanged();
        }
    }
}
