﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelBreakk : MonoBehaviour
{
    [SerializeField]
    int health = 1;
    [SerializeField]
    UnityEngine.Object destructableRef;

    // Start is called before the first frame update
    void Start() { }
    // Update is called once per frame
    void Update() { }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Weapon" )

        {
          
                health--;
                if (health <= 0)
                {
                    ExplodeThisGameObject();
                }
            
        }
    }

    private void ExplodeThisGameObject()
    {
        

        GameObject destructable = (GameObject)Instantiate(destructableRef);

        FindObjectOfType<AudioManager>().Play("barrel");
        //map the newly loaded destructable object to the x and y position of the previously destroyed barrel
        destructable.transform.position = transform.position;
        Destroy(gameObject);
        Object.Destroy(destructable, 1f);

    }
}