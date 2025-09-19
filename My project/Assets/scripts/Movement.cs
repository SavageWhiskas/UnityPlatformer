using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float jumpForce = 2f;
    [SerializeField] private float walkForce = 1f;

    private bool grounded = true;
    private Rigidbody2D rb;
    private Vector3 startLocation;
    private void Start()
    {
        Vector2 startLocation = gameObject.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey("w") && grounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            grounded = false;
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(-Vector3.left * walkForce, ForceMode2D.Force);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector3.left * walkForce, ForceMode2D.Force);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            grounded = true;
        }
    }
}
