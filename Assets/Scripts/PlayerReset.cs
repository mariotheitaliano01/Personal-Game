using UnityEngine;
using UnityEngine.SceneManagement; // needed for scene reload

public class ResetOnFall : MonoBehaviour
{
    public float fallThreshold = -10f; // Y position at which scene resets

    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            ReloadScene();
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
