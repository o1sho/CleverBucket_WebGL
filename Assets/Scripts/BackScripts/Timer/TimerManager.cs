using UnityEngine;
using TMPro;
using System.Collections;

public class TimerManager : MonoBehaviour
{
    private int _minsec;
    private int _sec;
    private int _min;

    private int _currentTime;

    [SerializeField] private TextMeshProUGUI _textTimer;

    private bool _playerMove = false;

    private void Start()
    {
        _minsec = 0;
        _sec = 0;
        _min = 0;
        StartCoroutine(TimeFlow());
    }
    
    IEnumerator TimeFlow()
    {
        while (true)
        {
            if (_minsec == 59)
            {
                _sec++;
                _minsec = -1;
            }
            if (_sec == 60)
            {
                _min++;
                _sec = 0;
            }
            
            if (_playerMove)
            {
                _minsec++;
                _currentTime++;
            }
            _textTimer.text = _min.ToString("D2") + ":" + _sec.ToString("D2") + ":" + _minsec.ToString("D2");
            yield return new WaitForSeconds(.01f);
        }
    }

    public void SaveTime()
    {
        for (int i = 1; i <= 10; i++)
        {
            int lvl = i;
            int _indexScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
            if (lvl == _indexScene)
            {
                if (_currentTime < PlayerPrefs.GetInt("bestTimeLvl" + lvl) || !PlayerPrefs.HasKey("bestTimeLvl" + lvl))
                {
                    PlayerPrefs.SetInt("bestTimeLvl" + lvl, _currentTime);
                    PlayerPrefs.SetString("bestTimeLvlText" + lvl, _textTimer.text);
                }
            }
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Jump")) _playerMove = true;
    }
}
