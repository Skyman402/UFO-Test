using UnityEngine;


public class PointScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameData.AddPoint();
            Destroy(gameObject);
        }
    }
}
