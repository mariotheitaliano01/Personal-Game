using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winText; // Assign in inspector
    //on trigger enter, show win text
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winText.SetActive(true);
        }
    }
}
