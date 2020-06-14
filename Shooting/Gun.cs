using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float range = 100f;
    public Transform muzzle;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(muzzle.transform.position, muzzle.transform.forward, out hit, range))
        {
            Debug.Log(hit.collider.name);
        }
    }
}