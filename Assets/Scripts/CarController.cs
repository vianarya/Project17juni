using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class CarController : MonoBehaviour
{   

    [SerializeField] private CarData carData;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Controller controls;
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = carData.CarSprite;
        controls = new Controller();

    }

    private void OnEnable()
    {
        controls.Enable();
        controls.CarControl.Movement.performed += movePlayer;
        controls.CarControl.Movement.canceled += movePlayer;

    }

    private void OnDisable()
    {
        controls.Disable();
        controls.CarControl.Movement.performed -= movePlayer;
        controls.CarControl.Movement.canceled -= movePlayer;
    }

    public void movePlayer(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MoveRotation(rb.rotation - moveInput.x * carData.TurnSpeed * Time.fixedDeltaTime);
        rb.MovePosition(rb.position + (Vector2)transform.up * moveInput.y * carData.MoveSpeed * Time.fixedDeltaTime);
    }
}
