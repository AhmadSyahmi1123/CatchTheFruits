using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitCollision : MonoBehaviour
{
    private static bool isGrounded = false;
    private Rigidbody2D rb;
    public float moveSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            scoreManager ScoreManager = FindObjectOfType<scoreManager>(); // Get a reference to the ScoreManager script
            ScoreManager.UpdateScore();

            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            GameManagerScript gameManager = FindObjectOfType<GameManagerScript>(); // Get a reference to the GameManagerScript
            gameManager.GameOver();
        }
    }

    private void FixedUpdate()
    {
        if (!isGrounded) // za warudo for the fruit
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
