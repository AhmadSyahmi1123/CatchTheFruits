using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public Animator animator;
    public Rigidbody2D rb;
    private float moveSpeed;

    // Update is called once per frame
    void Update()    
    {
        moveSpeed = Input.GetAxis("Horizontal"); //input AD or left-arrow/right-arrow 
        rb.velocity = new Vector2(speed * moveSpeed, rb.velocity.y); //player movement

        //flipping player sprite based on the direction of movement
        animator.SetFloat("speed", Mathf.Abs(moveSpeed));
        Vector3 characterScale = transform.localScale;
        if (moveSpeed < 0)//if player move to left
        {
            characterScale.x = -2;//flip sprite facing left
        }
        if (moveSpeed > 0)//if player move to right
        {
            characterScale.x = 2;//flip sprite facing right
        }
        transform.localScale = characterScale;//flip the sprite
    }
}
