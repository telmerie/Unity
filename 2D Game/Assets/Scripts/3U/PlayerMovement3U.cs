using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3U : MonoBehaviour
{

    public int jump;

    public bool grounded;

    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!grounded)
        {
            animator.SetFloat("y", rigidBody.velocity.y);

        }

        if (Input.GetKeyDown("up") && grounded)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jump);
            animator.SetFloat("y", 0);
            animator.SetTrigger("jumping");

        }
        else if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            animator.SetBool("isRunning", false);
        }
        else if (Input.GetKeyDown("right") || Input.GetKeyDown("left") || Input.GetKeyUp("left") || Input.GetKeyUp("right"))
        {
            spriteRenderer.flipX = Input.GetKey("left");
            animator.SetBool("isRunning", true);
        }


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            animator.SetFloat("y", 1);
            grounded = true;

        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }




}
