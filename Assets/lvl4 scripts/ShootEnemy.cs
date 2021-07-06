using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public AudioClip hit;
    
    private Transform Player;
    public float ShootingRange;
    public GameObject bullet;
    public GameObject bulletParent;
    public float firerate=1f;
    private float nextfiretime;
    private Animator anim;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
    }

    public void Update()
    {
        float distanceFromPlayer = Vector2.Distance(Player.position, transform.position);
      if(distanceFromPlayer <= ShootingRange && nextfiretime<Time.time)
            {
            //audiomanager.instance.PlaySingle(hit);
            anim.SetTrigger("destroy");
            Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
                nextfiretime = Time.time + firerate;
            }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
       
        Gizmos.DrawWireSphere(transform.position, ShootingRange);

    }
}
