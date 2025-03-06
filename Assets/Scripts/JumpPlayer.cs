using UnityEngine;

public class JumpPlayer : MonoBehaviour
{
    [SerializeField] private float _jumpSpeed;
    private bool doubleJumpComplete;

    private Rigidbody2D _rb;
    private Animator _anim;

    private void Start()
    {
        _rb= GetComponent<Rigidbody2D>();
        _anim= GetComponent<Animator>();
    }

    private void Update()
    {
        _anim.SetFloat("velY", _rb.linearVelocity.y);
        _anim.SetBool("isGround", GroundCheck._isGround);
    }

    public void Jump()
    {
        if (Input.GetButton("Jump") && GroundCheck._isGround)
        {
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, 0);
            if (GravityReverse._top == false) _rb.AddForce(new Vector2 (0, _jumpSpeed), ForceMode2D.Impulse);
            if (GravityReverse._top == true) _rb.AddForce(new Vector2(0, _jumpSpeed * -1), ForceMode2D.Impulse);
        }
    }

    public void DoubleJump()
    {
        if (Input.GetButton("Jump") && GroundCheck._isGround)
        {

            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, 0);
            if (GravityReverse._top == false) _rb.AddForce(new Vector2(0, _jumpSpeed), ForceMode2D.Impulse);
            if (GravityReverse._top == true) _rb.AddForce(new Vector2(0, _jumpSpeed * -1), ForceMode2D.Impulse);
            doubleJumpComplete = false;
        } else if (Input.GetButtonDown("Jump") && !GroundCheck._isGround && !doubleJumpComplete)
        {
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, 0);
            if (GravityReverse._top == false) _rb.AddForce(new Vector2(0, _jumpSpeed), ForceMode2D.Impulse);
            if (GravityReverse._top == true) _rb.AddForce(new Vector2(0, _jumpSpeed * -1), ForceMode2D.Impulse);
            doubleJumpComplete = true;
        }
    }
}
