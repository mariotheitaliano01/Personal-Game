using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float fallDelay = 1f;
    public float destroyDelay = 3f;
    public GameObject underPlatform;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Invoke("DropPlatform", fallDelay);
        }
    }

    void DropPlatform()
    {
        rb.isKinematic = false;
        Destroy(gameObject, destroyDelay);
        underPlatform.SetActive(false);
    }
}
