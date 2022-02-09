using System.Collections;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private float force = 1;
    private Rigidbody shipmove;

    private void Start()
    {
        shipmove = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            shipmove.AddRelativeForce(force * Vector3.up);
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
}
