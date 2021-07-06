using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BOSS_STATS : MonoBehaviour
{
    
    public Slider HealthVal;
    private Animator anim;
    public int HP = 30;
    public AudioClip hit;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthVal.value = HP;
    }
    public void Damage(int damage)
    {

        anim.SetTrigger("Dam");
        this.HP -= damage;
        if (this.HP <= 0)
        {
            Destroy(HealthVal.gameObject);
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "weapon")
        {
            Damage(3);
        }

    }
}
