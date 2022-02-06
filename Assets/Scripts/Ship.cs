using System.Collections;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private float force = 1;
    
    private Rigidbody shipmove;
    private AudioSource sound;

    private void Start()
    {
        shipmove = GetComponent<Rigidbody>();
        sound = GetComponent<AudioSource>();
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            StartCoroutine(DelayRestart());
        }
        if (collision.gameObject.tag == "Friend")
        {
            SceneLoader.NextScene();
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            SceneLoader.RestartScene();
        }
    }

    private IEnumerator DelayRestart()
    {
        sound.PlayOneShot(sound.clip);
        yield return new WaitForSeconds(1);
        SceneLoader.RestartScene();
    }
}
