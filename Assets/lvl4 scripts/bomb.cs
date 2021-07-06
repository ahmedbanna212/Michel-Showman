using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    private Transform Player;
    public float ShootingRange;
    public float speed;
    public int damage;
    private bombercontroller bomber;
    private Animator anim;
    bool explode = false;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(explodee());
        StartCoroutine(destroy());
        anim = GetComponent<Animator>();
        bomber = FindObjectOfType<bombercontroller>();
        if (bomber.transform.localScale.x > 0)
        {
            speed = -speed;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(Player.position, transform.position);
        anim.SetFloat("sp", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        if (distanceFromPlayer <= ShootingRange && explode)
        {
            FindObjectOfType<PlayerStatus>().TakeDamage(damage);
            explode = false;
        }

    }

    
    
    public IEnumerator explodee()
    {
        yield return new WaitForSeconds(2);
        FindObjectOfType<AudioManager>().Play("explode");
        explode = true;
        anim.SetTrigger("dest");

    }
    public IEnumerator destroy()
    {
        yield return new WaitForSeconds(3);
        Object.Destroy(this.gameObject);

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        Gizmos.DrawWireSphere(transform.position, ShootingRange);

    }
}
