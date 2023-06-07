using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] private string _nameAnimation;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();   
    }

    public void PlayAnim()
    {
        _animator.Play(_nameAnimation);
    }
}
