using TMPro;
using UnityEngine;

public class TimeSetter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] _textFinishTimer;

    private void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            int lvl = i;
            _textFinishTimer[i-1].text = PlayerPrefs.GetString("bestTimeLvlText" + lvl).ToString();
        }
    }
}
