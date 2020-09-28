using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10;
    public float maxSpeed = 10;
    public float jumpForce = 10;

    bool jump = false;
    public bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //jump code
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        float direction = Input.GetAxis("Horizontal"); // [-1, 1] left/right 
        rb.AddForce(Vector2.right * direction * speed);

        if (rb.velocity.x > maxSpeed)
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
        if (rb.velocity.x < -maxSpeed)
            rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);

        //jump code
        if (jump)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jump = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("KillTrigger"))
            Destroy(gameObject);
    }

}
