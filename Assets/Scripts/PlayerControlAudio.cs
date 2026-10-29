using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControlAudio : MonoBehaviour
{
    private float movementY;
    private float movementX;
    private Rigidbody rb;
    public float speed = 0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMove(InputValue value)
    {
        Vector2 movementVector = value.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0f, movementY);
        rb.AddForce(movement * speed);
    }
}
