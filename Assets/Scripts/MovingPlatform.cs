using UnityEngine;

public class MovingPlatform : MonoBehaviour
{   
    [SerializeField] private float distance = 5f;

    [SerializeField] private float speed = 3f;
    private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.PingPong(Time.time* speed, distance);
        transform.position = startPosition + Vector3.right * x;
    }
}
