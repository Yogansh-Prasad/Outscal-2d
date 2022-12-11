using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed;
    public float jump;
    public bool Grounded = true;    
    private Rigidbody2D rb2d;
    public ScoreController scoreController;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        MoveCharacter(horizontal);
        JumpPlayer(vertical);
        PlayerMovementAnimation(horizontal,vertical);

    }

    public void PickUpKey()
    {
        Debug.Log("Key Picked by player");
        scoreController.IncreaseScore(10);

    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.transform.tag == "Platform")
        {
            Grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "Platform")
        {
            Grounded = false;
        }
    }
    public void JumpPlayer(float vertical) 
    {
        if(vertical > 0 && Grounded)
        {
            
            rb2d.AddForce(new Vector2(0, jump), ForceMode2D.Force);
        }
    }


    private void MoveCharacter(float horizontal) 
    {
        Vector3 position = transform.position;
        position.x = position.x + horizontal * speed * Time.deltaTime;
        transform.position = position;

        
       
    }

    private void PlayerMovementAnimation(float horizontal, float vertical)
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        Vector3 scale = transform.localScale;

        if (horizontal < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
        }

        else if (horizontal > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }

        transform.localScale = scale;

        if (Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("Crouch", true);
        }

        else
        {
            animator.SetBool("Crouch", false);
        }

        if (vertical > 0 && Grounded)
        {
            animator.SetBool("Jump", true);

        }
        else
        {
            animator.SetBool("Jump", false);
        }
    }

}
