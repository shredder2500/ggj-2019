using UnityEngine;
using UnityEngine.Events;

public class TransitionEventBehaviour : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onEnter;

    public void TriggerOnEnter() => _onEnter.Invoke();
}