using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public Rigidbody shipmove;
    public float force = 1;

    void Start()
    {
        shipmove = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            shipmove.AddRelativeForce(force*Vector3.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            shipmove.AddRelativeForce(force * Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            shipmove.AddRelativeForce(force * Vector3.right);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneLoader.LoadScene();
        }
        if (collision.gameObject.tag == "Friend")
        { }
    }
}
