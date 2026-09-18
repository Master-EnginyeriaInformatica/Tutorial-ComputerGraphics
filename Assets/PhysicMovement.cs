using UnityEngine;

public class PhysicMovement : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(0.0f, 0.0f);

        if (Input.GetKey(KeyCode.W))
            rb.linearVelocity = rb.linearVelocity + new Vector2(0.0f, 5.0f);
        if (Input.GetKey(KeyCode.S))
            rb.linearVelocity = rb.linearVelocity + new Vector2(0.0f, -5.0f);
        if (Input.GetKey(KeyCode.A))
            rb.linearVelocity = rb.linearVelocity + new Vector2(-5.0f, 0.0f);
        if (Input.GetKey(KeyCode.D))
            rb.linearVelocity = rb.linearVelocity + new Vector2(5.0f, 0.0f);
    }
}
