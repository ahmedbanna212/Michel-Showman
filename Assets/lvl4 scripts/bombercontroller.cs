using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombercontroller : MonoBehaviour
{
    public Transform throwfrom;
    public GameObject bomb;
    public float firerate = 1f;
    private float nextfiretime;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
  
    
        // Update is called once per frame
       public void Update()
    {
        if (nextfiretime < Time.time)
        {
            
            Instantiate(bomb, throwfrom.position, throwfrom.rotation);
            nextfiretime = Time.time + firerate;
         
        }


    }
    }

