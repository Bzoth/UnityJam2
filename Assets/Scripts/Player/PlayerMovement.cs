using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementi : MonoBehaviour
{

    public float horizontal;
    public float vertical;
    private Rigidbody2D rb;
    public float speed = 5;
    public Vector3 worldPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
        worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotationz = Mathf.Atan2(worldPos.y, worldPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationz);

    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
        vertical = context.ReadValue<Vector2>().y;
    }
    public void Slower(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            speed -= 2;
        }
        else if(context.canceled)
        {
            speed += 2;
        }
    }
}
