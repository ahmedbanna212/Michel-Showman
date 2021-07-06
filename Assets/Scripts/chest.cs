using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    public KeyCode W;
    public GameObject potion;
    public Transform insidefrom;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (Input.GetKey(W))
            {
                if (FindObjectOfType<PlayerStatus>().key > 0) {
                    FindObjectOfType<AudioManager>().Play("chest");
                    Instantiate(potion, insidefrom.position, insidefrom.rotation);
                    FindObjectOfType<PlayerStatus>().key -= 1;
                    anim.SetTrigger("open");
                }
                
            }
        }
    }
}
