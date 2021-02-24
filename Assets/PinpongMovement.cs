using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinpongMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float currentPosition = 0.0f;

    public Vector3 beginPosition;
    public Vector3 endPosition;


    void Update()
    {
        currentPosition += Time.deltaTime * speed;
        transform.localPosition = Vector3.Lerp(beginPosition, endPosition, Mathf.PingPong(currentPosition, 1.0f));
    }
}
