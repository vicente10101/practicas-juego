using UnityEngine;
using UnityEngine.InputSystem;


public class Movimiento : MonoBehaviour
{
    private float Vel = 5f;
    private Rigidbody2D rb;
    private Vector2 Inputmovimiento;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = Inputmovimiento * Vel;
    }

    public void Move(InputAction.CallbackContext context)
    {
        Inputmovimiento = context.ReadValue<Vector2>();
    }
}
