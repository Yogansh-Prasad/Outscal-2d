using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    [SerializeField] float speed=1f;
    [SerializeField]BoxCollider2D boxCollider;
    Rigidbody2D myrigidbody;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        myrigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (IsFacingRight())
        {
            myrigidbody.velocity = new Vector2(speed, 0f);
        }
        else 
        {
            myrigidbody.velocity = new Vector2(-speed, 0f);
        }
    }

    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myrigidbody.velocity.x)), transform.localScale.y);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
             Health health= collision.gameObject.GetComponent<Health>();
             health.TakeDamage(1);
            
            
        }

    }
}
