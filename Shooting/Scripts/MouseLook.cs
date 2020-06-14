﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float y = 0f;

    void Start()
    {

    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        y -= mouseY;
        y = Mathf.Clamp(y, -90f, 90f);

        transform.localRotation = Quaternion.Euler(y, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
