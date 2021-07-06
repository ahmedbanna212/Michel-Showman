using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyJump : EnemyController
{
    public LayerMask Ground;
    private bool grounded;
    public float cheackerRadius;
    public Transform checker;
    public float cooldownCounter = 6;
    private float nextTime = 0;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        if (nextTime < Time.time)
        {
            jump();
            nextTime = Time.time + cooldownCounter;
        }

    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(checker.position, cheackerRadius, Ground);
        if (anim.gameObject.activeSelf)
        {
            anim.SetBool("grounded", grounded);
        }

    }




    void jump()
    {
        if (grounded)
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, hight);
        anim.SetTrigger("Attack");

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {

            FindObjectOfType<PlayerStatus>().TakeDamage(damage);
            Debug.Log("Text: Attack");

        }


    }
}
