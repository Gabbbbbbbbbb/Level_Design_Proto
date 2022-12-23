using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float MoveSpeed = 30f;
    public Rigidbody rb;

    public LayerMask groundLayer;

    Vector3 movement;

    public Transform groundCheck;
    public float jumpForce = 10;
    public float gravity = -20;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.deltaTime);
    }

    public void Jump()
    {
        bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.3f, groundLayer);
        direction.y += gravity * Time.deltaTime;

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            direction.y = jumpForce;
        }
    }
}
