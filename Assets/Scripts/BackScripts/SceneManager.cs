using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private int _sceneID;

    public void LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneID);
        Time.timeScale = 1.0f;
    }
}
