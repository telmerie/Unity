using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{



    public int jump;

    public static bool grounded;

    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        // instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.isPaused)
        {
            
            if (!grounded)
            {
                animator.SetFloat("y", rigidBody.velocity.y);

            }

            if (Input.GetKeyDown("up") && grounded)
            {
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jump);
                animator.SetTrigger("jumping");
                GameEvents.instance.jumpTrigger();

            }
            else if ((Input.GetKeyUp("left") && !Input.GetKey("right")) || (Input.GetKeyUp("right") && !Input.GetKey("left")))
            {
                animator.SetBool("isRunning", false);
            }
            else if (Input.GetKeyDown("right") || Input.GetKeyDown("left") || Input.GetKeyUp("left") || Input.GetKeyUp("right"))
            {
                spriteRenderer.flipX = !Input.GetKey("right");
                animator.SetBool("isRunning", true);
            }
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
