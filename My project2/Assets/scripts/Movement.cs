using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.Assertions.Must;


public class MovementScript : MonoBehaviour
{
    float horizontalInput;
    public float movespeed = 5f;

    Rigidbody2D rb;
    public float jumpPower = 4f;
    bool isJumping => rb.velocity.y > 0.1f;
    bool isFalling => rb.velocity.y < -0.1f;
    public bool answering = false;
    public int maxJumps = 2;
    int remainingJumps;
    bool isGrounded = true;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        remainingJumps = maxJumps;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxisRaw("Horizontal");
        


        if (Input.GetButtonDown("Jump") && remainingJumps > 0 && !answering)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            animator.SetTrigger("jump");
            remainingJumps--;
            isGrounded = false;
        }

      


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            remainingJumps = maxJumps;

        }


    }



    private void FixedUpdate()
    {
        if(!answering)
        {
            rb.velocity = new Vector2(horizontalInput * movespeed, rb.velocity.y);
            animator.SetFloat("Speed", Math.Abs(horizontalInput));
            Flipsprite();

        }
    }

    void Flipsprite()
    {
        print(horizontalInput);
        if (horizontalInput < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (horizontalInput > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

    }

    
    
}





 