using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    public float moveDistance = 3f;
    public float speed = 2f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed, moveDistance);
        transform.position = startPos + new Vector3(0, offset, 0);
    }
}
