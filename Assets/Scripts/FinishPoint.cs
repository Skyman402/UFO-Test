using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        SceneLoader.NextScene();
    }
}
