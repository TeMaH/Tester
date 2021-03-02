using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    private bool isCollided;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isCollided)
        {
            Invoke("Release", 2.0f);
        }
        isCollided = true;
    }

    void Release()
    {
        gameObject.SetActive(false);
    }
}
