﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    //private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb2D;

    private bool canDoubleJump;
    public static bool isJumping = false;
   
    public FloatVariable MovementSpeed;
    public FloatVariable JumpForce;

    // ground
    private bool isGrounded;
    public Transform GroundCheckPoint;
    public LayerMask whatIsGround;

    private void Awake()
    {
       // animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()                                                              
    {

    }
    private void FixedUpdate()
    {
        // animator.SetFloat("moveSpeed", Mathf.Abs(rb2D.velocity.x));
    }

    // Update is called once per frame
    void Update()   
    {
        rb2D.velocity = new Vector2(MovementSpeed.Value * Input.GetAxis("Horizontal"), rb2D.velocity.y);
        spriteRenderer.flipX = rb2D.velocity.x < 0;

        isGrounded = Physics2D.OverlapCircle(GroundCheckPoint.position, .2f, whatIsGround);
        if (isGrounded)
         {
            canDoubleJump = true;
        }

        if (Input.GetButtonDown("Jump"))
        {                                               
            
            if (isGrounded)
             {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpForce.Value), ForceMode2D.Impulse);
                isJumping = true;
                isGrounded = false;
            }
            else
            {
                if (canDoubleJump)
                {
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpForce.Value), ForceMode2D.Impulse);
                    canDoubleJump = false;
                                                
                    //  SoundManager.instance.PlaySFX(0);
                }
                else
                {
                    isJumping = false;
                    isGrounded = true;
                }
            }
        }

       // animator.SetBool("isGrounded", isGrounded);
    }
}
