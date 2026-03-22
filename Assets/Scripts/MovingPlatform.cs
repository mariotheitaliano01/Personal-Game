using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveDistance = 5f;   // how far to move
    public float speed = 2f;          // how fast to move
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // PingPong moves between 0 and moveDistance
        float offset = Mathf.PingPong(Time.time * speed, moveDistance);
        transform.position = startPos + new Vector3(offset, 0, 0);
    }
}
