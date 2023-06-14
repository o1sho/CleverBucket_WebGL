using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlyingParts : MonoBehaviour
{
    [SerializeField] private int _directionX;
    [SerializeField] private int _directionY;
    [SerializeField] private float _flyingSpeed;
    [SerializeField] private float _flyingTime;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb= GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        _rb.AddForce(new Vector2(_directionX, _directionY) * _flyingSpeed, ForceMode2D.Impulse);
        StartCoroutine(DestroyObj());
    }
    private void Start()
    {
        gameObject.SetActive(false);
    }
    private IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(_flyingTime);
        Destroy(gameObject);
    }
}
