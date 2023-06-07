using UnityEngine;

public class ExitManager : MonoBehaviour
{
    [SerializeField] GameObject _exitPan;
    [SerializeField] bool activePan = false;
    private void Start()
    {
        _exitPan.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Cancel")) OpenAndClosePanel();
    }
    public void OpenAndClosePanel()
    {
        if (activePan == false)
        {
            _exitPan.SetActive(true);
            Time.timeScale = 0;
            activePan = true;
        }
        else
        {
            _exitPan.SetActive(false);
            Time.timeScale = 1;
            activePan = false;
        }
    }
    public void ExitGame()
    {
        {
            Application.Quit();
            Debug.Log("Пока");
        }
    }
}
