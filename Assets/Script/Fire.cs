using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform spawner;

    public float force = 20f;

    float firetime;
    public float firerate;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > firetime)
        {
            firetime = Time.time + firerate;
            FireBullet();
        }
    }

    void FireBullet()
    {
        GameObject obj = ObjectPooler.current.GetPooledObject();
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        obj.transform.position = transform.position;
        obj.transform.rotation = transform.rotation;
        rb.velocity = force * spawner.forward;
        obj.SetActive(true);
    }
}
