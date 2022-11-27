using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed;
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        MoveCharacter(horizontal);
        PlayerMovementAnimation(horizontal);

    }

    private void MoveCharacter(float horizontal) 
    {
        Vector3 position = transform.position;
        position.x = position.x + horizontal * speed * Time.deltaTime;
        transform.position = position;
    }

    private void PlayerMovementAnimation(float horizontal)
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

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("Jump", true);

        }
        else
        {
            animator.SetBool("Jump", false);
        }
    }

}
