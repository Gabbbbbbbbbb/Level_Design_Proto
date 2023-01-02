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
    public float jump;
    public float gravity = -20;
    private bool onGround = true;

    private const int MAX_JUMP = 2;
    private int currentJump = 0;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && (onGround || MAX_JUMP > currentJump))
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            onGround = false;
            currentJump++;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        onGround = true;
        currentJump = 0;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.deltaTime);
    }

    /*public void Jump()
    {
        bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.3f, groundLayer);
        direction.y += gravity * Time.deltaTime;

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            direction.y = jumpForce;
        }
    }*/
}
