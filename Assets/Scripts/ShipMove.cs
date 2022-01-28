using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    public Rigidbody shipmove;
    public float force = 1;


    void Start()
    {
        shipmove = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            shipmove.AddForce(force * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            shipmove.AddForce(force * Vector3.back);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            shipmove.AddForce(force * Vector3.left);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            shipmove.AddForce(force * Vector3.right);
        }
    }
}
