using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3 : MonoBehaviour
{
    public KeyCode W;
    private bool openDoor;
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
                  FindObjectOfType<AudioManager>().Play("door");
                FindObjectOfType<LevelManger>().GoToPart4();
                anim.SetTrigger("openDoor");
            }
        }
    }
}
