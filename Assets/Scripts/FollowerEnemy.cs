using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerEnemy : EnemyController
{
    public float LineOfSight;
    private Transform Player;
    public float speedtowardsplayer;
    Animator anim;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(Player.position, transform.position);
        if (distanceFromPlayer < LineOfSight)
        {
           if (transform.position.x > Player.transform.position.x)
            {
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
                isFacingRight = false;
            }
           if  (transform.position.x < Player.transform.position.x)
            {
                isFacingRight = true;
                transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
            transform.position = Vector2.MoveTowards(this.transform.position, Player.position, speedtowardsplayer * Time.deltaTime);
            anim.SetTrigger("Bite");
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LineOfSight);

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("BTA");
            FindObjectOfType<PlayerStatus>().TakeDamage(damage);
    Debug.Log("Text: Attack");
            
        }
    }
}
