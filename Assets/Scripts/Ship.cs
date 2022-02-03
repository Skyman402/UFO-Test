using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public Rigidbody shipmove;
    public float force = 1;
    public SceneLoader sceneLoader;
    void Start()
    {
        shipmove = GetComponent<Rigidbody>();
        sceneLoader = FindObjectOfType<SceneLoader>();
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
            sceneLoader.RestartScene();
        }
        if (collision.gameObject.tag == "Friend")
        { 
            sceneLoader.NextScene();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            sceneLoader.RestartScene();
        }
    }
}
