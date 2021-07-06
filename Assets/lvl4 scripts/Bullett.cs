using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullett : MonoBehaviour
{
    private Animator anim;
    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
       
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<PlayerStatus>().TakeDamage(damage);
            Object.Destroy(this.gameObject);
        }
        if (other.tag == "Wall")
        {
            Object.Destroy(this.gameObject);
        }
        if (other.tag == "weapon")
        {
            
            Object.Destroy(this.gameObject);

        }

    }
}
