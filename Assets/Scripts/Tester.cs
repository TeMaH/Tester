using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.Events;
using UnityEngine;

public class Tester : MonoBehaviour
{
    public EventExample bathtub;

    public UnityEvent Callback;

    private void Start()
    {
        bathtub.OnTriggeredEvent += (GameObject go) =>
        {
            MySingleton.Instance.PrintWarningLog(go.name);
            Callback.Invoke();
        };

    }
}
