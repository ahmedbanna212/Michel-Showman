using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class kingwalk : MonoBehaviour
{
    private Animator anim;
    public float maxSpeed = 3f;
    void FixedUpdate()
    {
        
     
        GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

    }
   
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();




    }
    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }

}