using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    public float MovementSpeed = 10.0f;
    CharacterController controller;
    float Gravity = -9.81f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = transform.TransformDirection( new Vector3(Input.GetAxis("Horizontal"), Gravity, Input.GetAxis("Vertical")));
        float rotation = Input.GetAxis("Mouse X");

        controller.Move(movement * Time.deltaTime * MovementSpeed);
        controller.transform.Rotate(Vector3.up, rotation);
    }
}
