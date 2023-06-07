using UnityEngine;
using UnityEngine.Events;

public class EnterTrigger : MonoBehaviour
{
    //[SerializeField] GameObject _activatedObj;
    public UnityEvent _eventEnter;
    public UnityEvent _eventExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //_activatedObj.SetActive(true);
            _eventEnter.Invoke();
        } 

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _eventExit.Invoke();
        }
    }
}
