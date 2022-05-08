using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    private float verticalInput, horizontalInput;
    public int speed = 5;
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);
        
    }
}
