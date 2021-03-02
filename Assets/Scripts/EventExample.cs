using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExample : MonoBehaviour
{
    public event Action<GameObject> OnTriggeredEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Character>())
        {
            OnTriggeredEvent?.Invoke(gameObject);
        }
    }
}
