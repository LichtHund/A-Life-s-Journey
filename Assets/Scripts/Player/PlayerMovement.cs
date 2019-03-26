using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;

    private float runSpeed = 20f;

    private float horizontalMove = 0f;
    private bool jump = false;

    void Update() {

        if (Input.GetButton("PS4_R1")) {
            runSpeed = 25f;
        } else {
            runSpeed = 10f;
        }

        horizontalMove = Input.GetAxisRaw("PS4_Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("PS4_X")) {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

    }

    public void OnLanding() {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

}
