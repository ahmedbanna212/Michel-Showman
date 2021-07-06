using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkAttack : EnemyController
{
   
    public float cooldownCounter = 3;
    private float nextTime = 0;
    private Animator anim;
    public Animation anime;

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
            attack();
            nextTime = Time.time + cooldownCounter;
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("attack"))
        {
            if (this.isFacingRight == true)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
            }
            else
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(-maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
            }
        }
            else 
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);

    }
    void FixedUpdate()
    {

        

       
    }
    void attack()
    {
        walk();
        anim.SetTrigger("attack");
        
            Flip();
        
    }
    void walk()
    {
        
    }
        void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Wall")
        {
            
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, this.GetComponent<Rigidbody2D>().velocity.y);

        }
        else if (collider.tag == "Player")
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("attack"))
            {
                FindObjectOfType<PlayerStatus>().TakeDamage(damage);
                Debug.Log("Text: Attack");
            }
            Flip();
        }
    }
    
    
}

