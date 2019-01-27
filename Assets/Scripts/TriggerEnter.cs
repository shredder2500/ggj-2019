using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onEnter;

    private void OnTriggerEnter(Collider coll) 
    {
        _onEnter.Invoke();
    }
}
