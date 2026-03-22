using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float pushSpeed = 5f; // how fast it pushes
    public Vector3 direction = Vector3.forward; // push direction

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Move the player along the belt
            collision.gameObject.transform.Translate(direction * pushSpeed * Time.deltaTime, Space.World);
        }
    }
}
