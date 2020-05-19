using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 100f;
    public Rigidbody rb;
    void Update()
    {
        float hor = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float ver = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 move = new Vector3(hor, 0f, ver);

        rb.AddForce(move);
    }
}
