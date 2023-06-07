using UnityEngine;
using UnityEngine.UI;

public class LevelsManager : MonoBehaviour
{
    [SerializeField] private Button[] _buttons;
    [SerializeField] private int _lvlComplete;

    [SerializeField] private GameOver _reloadSceneObj;

    private void Start()
    {
        _lvlComplete = PlayerPrefs.GetInt("currentEndLvl");
        for (int i = 1; i < _buttons.Length; i++)
        {
            if (_lvlComplete < i) _buttons[i].interactable = false;
        }
    }

    public void ResetLevels()
    {
        PlayerPrefs.DeleteKey("currentEndLvl");
        for (int i = 1; i <= 10; i++)
        {
            int lvl = i;
            PlayerPrefs.DeleteKey("bestTimeLvl" + lvl);
            PlayerPrefs.DeleteKey("bestTimeLvlText" + lvl);
        }
        _reloadSceneObj.ReloadScene();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) ResetLevels();
    }
}
