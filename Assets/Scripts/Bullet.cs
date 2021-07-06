using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        //Destroy(this.gameObject, 2);
    }

    void OnTriggerEnter2D(Collider2D gg)
    {
        //AudioManager.instance.randomizesfx(hit1, hit2);
        if (gg.CompareTag("Player"))
        {
            //anim.SetTrigger("Bite");
            FindObjectOfType<PlayerStatus>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
        Object.Destroy(this.gameObject,3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
