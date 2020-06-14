using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 100f;
    public CharacterController controller;
    void Update()
    {
        float hor = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float ver = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 move = transform.right * hor + transform.forward * ver;

        controller.Move(move * speed * Time.deltaTime);
    }
}
