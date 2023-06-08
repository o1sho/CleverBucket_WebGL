using UnityEngine;

public class Player : MonoBehaviour
{
    private MovePlayer _movePlayer;
    private JumpPlayer _jumpPlayer;

    private int _indexScene;

    private void Awake()
    {
        _indexScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
    }

    private void Start()
    {
        _movePlayer = GetComponent<MovePlayer>();
        _jumpPlayer = GetComponent<JumpPlayer>();   
    }
    private void Update()
    {
        if (_indexScene <= 3)
        _jumpPlayer.Jump();

        if (_indexScene > 3)
        _jumpPlayer.DoubleJump();
    }
    private void FixedUpdate()
    {
        _movePlayer.Move();
    }
}
