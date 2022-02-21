using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Barrier : MonoBehaviour
{
    private AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(DelayRestart());
    }

    private IEnumerator DelayRestart()
    {
        sound.PlayOneShot(sound.clip);
        yield return new WaitForSeconds(1);
        SceneLoader.RestartScene();
    }
}
