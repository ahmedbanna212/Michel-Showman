using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    private Animator anim;
    public int HP = 6;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void Damage(int damage)
    {
        anim.SetTrigger("Dam");
        this.HP -= damage;
        if (this.HP <= 0)
        {
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
            FindObjectOfType<PlayerStatus>().score += 5;
            anim.SetTrigger("die");  
            Invoke("destroy", 0.4f);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Weapon")
        {
            this.Damage(FindObjectOfType<PlayerStatus>().Damge);

        }
    }
    void destroy()
    {
        Destroy(this.gameObject);
    }

}
