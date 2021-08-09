using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 4f;
    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Velocidade", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            if (animator.GetFloat("Pulo") < 1)
            {
                animator.SetFloat("Pulo", 1);
                jump = true;
            }
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        animator.SetFloat("Velocidade", 0f);
        jump = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetFloat("Pulo", 0f);
    }
}
