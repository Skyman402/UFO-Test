using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private SerializeField GameObject;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - transform.position;
    }

    private void LateUpdate()
    {
        transform.position = transform.position + offset;
    }
}
