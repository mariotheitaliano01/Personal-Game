using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; // axis to rotate around (Y = spin left/right)
    public float rotationSpeed = 50f;         // degrees per second

    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
