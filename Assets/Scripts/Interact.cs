using UnityEngine;
using UnityEngine.Events;

public class Interact : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onClick;

    private Movement Movement => FindObjectOfType<Movement>();
    private bool CanClick => Movement.CanClick;

    private void OnMouseDown(){
        if (!CanClick) return;
        _onClick.Invoke();
    }
}
