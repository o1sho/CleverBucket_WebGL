using System.Text;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float speed;
    private float _direction;
    private Rigidbody2D _rb;

    private Animator _anim;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        _direction = Input.GetAxis("Horizontal");
        _anim.SetBool("isRun", _direction != 0);

        _anim.SetBool("topGravity", GravityReverse._top);

        if (_direction < 0 && GravityReverse._top == false) transform.rotation = Quaternion.Euler(0,-180,0);
        if (_direction > 0 && GravityReverse._top == false) transform.rotation = Quaternion.Euler(0, 0, 0);
        if (_direction < 0 && GravityReverse._top == true) transform.rotation = Quaternion.Euler(0, 0, -180);
        if (_direction > 0 && GravityReverse._top == true) transform.rotation = Quaternion.Euler(0, 180, -180);
    }
    public void Move()
    {
        _rb.linearVelocity = new Vector2(_direction * speed, _rb.linearVelocity.y);
    }

}
