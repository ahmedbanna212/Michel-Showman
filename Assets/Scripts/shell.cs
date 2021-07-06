using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell : EnemyController
{
    public float LineOfSight;
    private Transform Player;
    public float speedtowardsplayer;
    public float ShootingRange;
    public GameObject bullet;
    public GameObject bulletParent;
    public float firerate = 1f;
    private float nextfiretime;
    Animator anim;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
    }



    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(Player.position, transform.position);
        if (distanceFromPlayer <= LineOfSight && distanceFromPlayer > ShootingRange)
        {
            //transform.position = Vector2.MoveTowards(this.transform.position, Player.position, speedtowardsplayer * Time.deltaTime);
        }
        else if (distanceFromPlayer <= ShootingRange && nextfiretime < Time.time && transform.position.x > Player.transform.position.x)
        {
            Debug.Log("shell");

            anim.SetTrigger("throw");
            Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
            nextfiretime = Time.time + firerate;
        }
     
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LineOfSight);
        Gizmos.DrawWireSphere(transform.position, ShootingRange);

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            anim.SetTrigger("attack");
        }
    }
        }
