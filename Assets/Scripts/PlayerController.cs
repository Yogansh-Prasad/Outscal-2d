using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed",Mathf.Abs (speed));

        Vector3 scale = transform.localScale;

        if (speed < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
        }

        else if (speed > 0)
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
