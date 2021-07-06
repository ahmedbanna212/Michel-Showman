using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy1 : EnemyController
{
  
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }

    void FixedUpdate()
    {
        if (this.isFacingRight == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
        else 
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(- maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "wall")
        {
            Flip();
        }
        if (collision.tag == "Enemy") 
        {

            Flip();
        }
        if (collision.tag == "Player") 
        {
            FindObjectOfType<AudioManager>().Play("BTA");
            anim.SetTrigger("Bite");
            FindObjectOfType<PlayerStatus>().TakeDamage(damage);
            Invoke("Flip",0.05f);
        }
    }
  
}
