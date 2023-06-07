using UnityEngine;
using UnityEngine.UI;

public class AnimatedUI : MonoBehaviour
{
    public Sprite[] sprites;

    private Image image;
    private int _frame;

    [SerializeField] private float _timeBetweenFrames;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void OnEnable()
    {
        Invoke(nameof(Animate), 0f);

    }
    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Animate()
    {
        _frame++;
        if (_frame >= sprites.Length)
        {
            _frame = 0;
        }
        if (_frame >= 0 && _frame < sprites.Length) image.sprite = sprites[_frame];

        Invoke(nameof(Animate), _timeBetweenFrames);
    }
}
