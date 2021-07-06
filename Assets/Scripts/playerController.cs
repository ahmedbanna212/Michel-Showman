using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;
    public float hight;
    bool facingR;
    public KeyCode spacebar;
    public KeyCode one;
    public KeyCode two;
    public KeyCode L;
    public KeyCode R;
    public Transform checker;
    public float cheackerRadius;
    public Transform throwfrom;
    public GameObject Sword;
    public LayerMask Ground;
    private bool grounded;
    private Animator anim;
     private  bool MyFunctionCalled = false;



    // Start is called before the first frame update
    void Start()
    {
        facingR = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(spacebar) && grounded)
        {
            FindObjectOfType<AudioManager>().Play("jump");
            
            jump();

        }
        if (Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
            if (facingR)
            {
                turn();
                facingR = false;

            }
        }
        if (Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
            if (!facingR)
            {
                turn();
                facingR = true;

            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            FindObjectOfType<AudioManager>().Play("attack");
            
            attack();


        }
        if (Input.GetMouseButtonDown(1))
        {
            if (FindObjectOfType<PlayerStatus>().Mana > 0)
            {
                FindObjectOfType<PlayerStatus>().Mana -= 1;
                Instantiate(Sword, throwfrom.position, throwfrom.rotation);
                anim.SetTrigger("throw");
            }

        }
        if (Input.GetKey(one))
        {
            if (MyFunctionCalled == false)
            {
                MyFunctionCalled = true;
                if (FindObjectOfType<PlayerStatus>().healthPotion > 0)
                {
                    FindObjectOfType<AudioManager>().Play("potion");
                    
                    FindObjectOfType<PlayerStatus>().healthPotion -= 1;
                    FindObjectOfType<PlayerStatus>().health += 3;
                    if (FindObjectOfType<PlayerStatus>().health > 6)
                    {
                        FindObjectOfType<PlayerStatus>().health = 6;
                        FindObjectOfType<PlayerStatus>().lives += 1;
                    }
                }
                Invoke("potion", 0.5f);
            }
        }
        if (Input.GetKey(two))
        {
            if (MyFunctionCalled == false)
            {
                MyFunctionCalled = true;
                if (FindObjectOfType<PlayerStatus>().ManaPotion > 0)
                {
                    FindObjectOfType<AudioManager>().Play("potion");
                    FindObjectOfType<PlayerStatus>().ManaPotion = FindObjectOfType<PlayerStatus>().ManaPotion - 1;
                    FindObjectOfType<PlayerStatus>().Mana += 3;
                    if (FindObjectOfType<PlayerStatus>().Mana > 6)
                    {
                        FindObjectOfType<PlayerStatus>().Mana = 6;
                    }
                }
                Invoke("potion", 0.5f);
            }
        }

        anim.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(checker.position, cheackerRadius, Ground);
        anim.SetBool("grounded", grounded);

    }
    void attack()
    {
        anim.SetTrigger("attack");
    }


    void turn()
    {
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);

    }
    void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, hight);
    }
    void potion() {
        MyFunctionCalled = false;
    }

}