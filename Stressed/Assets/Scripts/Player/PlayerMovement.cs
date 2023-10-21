using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls playerControls;
    public float dir, speed, jumpPower;
    public Rigidbody2D rb2d;

    public Animator animator;

    [SerializeField]bool isGrounded;
    public Transform groundCheck;
    [SerializeField] float radius;
    [SerializeField] LayerMask groundLayer;

    private void Awake() {

        playerControls = new PlayerControls();
        playerControls.Enable();

        playerControls.Land.Move.performed += ctf =>
        {
            dir = ctf.ReadValue<float>();
        };

        playerControls.Land.Jump.performed += ctx => Jump();
    }
    private void Update() {
        animator.SetBool("run", dir!=0);
        animator.SetBool("grounded", isGrounded);
        rb2d.velocity = new Vector2(dir * speed * Time.fixedDeltaTime, rb2d.velocity.y);
        if(dir > 0)
        {
            transform.localScale = Vector3.one;
        }
        else if(dir < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, radius, groundLayer);
    }

    void Jump()
    {
        if(isGrounded){
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);
        }
    }
}
