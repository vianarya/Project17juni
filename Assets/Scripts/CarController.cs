using UnityEngine;
using UnityEngine, InputSytem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer2D))]
public class CarController : MonoBehaviour
{   

    [SerializeField] private CarData carData;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Controller controls;
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
