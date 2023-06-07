using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private int _indexScene;

    private void Awake()
    {
        _indexScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex; 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(_indexScene);
        }
    }

    public void ReloadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_indexScene);
    }
}
