using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyJumpAndAttack : EnemyController
{
    public LayerMask Ground;
    private bool grounded;
    public float cheackerRadius;
    public Transform checker;
    public float cooldownCounter = 6;
    private float nextTime = 0;
    private Animator anim;
    public Animation anime;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anime = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {

       
        if (nextTime < Time.time)
        {
            anim.SetTrigger("Attack");
            jump();
            anim.SetTrigger("Attack");
            nextTime = Time.time + cooldownCounter;
        }


    }
    void FixedUpdate()
    {
        if (this.isFacingRight == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }

        grounded = Physics2D.OverlapCircle(checker.position, cheackerRadius, Ground);
        anim.SetBool("grounded", grounded); 


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
            anim.SetTrigger("attack");
            FindObjectOfType<PlayerStatus>().TakeDamage(damage);
            Invoke("Flip", 0.05f);
        }
    }

    void jump()
    {
        if (grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, hight);
            grounded = false;
            Flip();
        }
    }
}
  


