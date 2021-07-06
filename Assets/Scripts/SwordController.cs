using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwordController : MonoBehaviour
{

    public float speed;
    public int damage;
    private playerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playerController>();
        if (player.transform.localScale.x < 0)
        {
            speed = -speed;
        }


    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed,GetComponent<Rigidbody2D>().velocity.y);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
          
           other.GetComponent<enemyhealth>().Damage(damage);
            Object.Destroy(this.gameObject);
        }
        if (other.tag == "wall")
        {
            Object.Destroy(this.gameObject);
        }

    }
}
