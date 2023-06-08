using UnityEngine;

public class GameFinish : MonoBehaviour
{
    [SerializeField] private int _indexScene;
    private TimerManager _timerManager;

    private void Awake()
    {
        _indexScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
    }
    private void Start()
    {
        _timerManager = FindObjectOfType<TimerManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (PlayerPrefs.GetInt("currentEndLvl") < _indexScene)
            {
                PlayerPrefs.SetInt("currentEndLvl", _indexScene);
            }
            _timerManager.SaveTime();
            UnityEngine.SceneManagement.SceneManager.LoadScene(_indexScene + 1);
        }
    }

}
