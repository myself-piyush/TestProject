using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    private float verticalInput, horizontalInput;
    public int speed;
    public GameObject GameWon;
    private bool isGameOver = false;
    void Update()
    {
        if (!isGameOver)
        {
            verticalInput = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");
            if (Input.GetKey(KeyCode.Space))
            {
                rb2d.velocity = new Vector2(0, 0);
            }
            else
            {
                rb2d.velocity = new Vector2(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time.deltaTime);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Door")
        {
            GameWon.SetActive(true);
            isGameOver = true;
        }
    }
}
