using UnityEngine;

public class PlayerSoundsManager : MonoBehaviour
{
    private AudioSource audioSourse;

    public AudioClip _stepSound;
    public AudioClip _jumpSound;

    private void Awake()
    {
        audioSourse = GetComponent<AudioSource>();
    }
    public void StepSoundPlay()
    {
        audioSourse.PlayOneShot(_stepSound);
    }

    public void JumpSoundPlay()
    {
        audioSourse.PlayOneShot(_jumpSound);
    }
}
