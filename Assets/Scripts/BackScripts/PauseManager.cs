using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject _pausePan;
    [SerializeField] bool activePan = false;
    private void Start()
    {
        _pausePan.SetActive(false);
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Cancel")) OpenAndClosePanel();
    }
    public void OpenAndClosePanel()
    {
        if (activePan == false)
        {
            _pausePan.SetActive(true);
            Time.timeScale = 0;
            activePan = true;
        }
        else
        {
            _pausePan.SetActive(false);
            Time.timeScale = 1;
            activePan = false;
        }
    }
}
