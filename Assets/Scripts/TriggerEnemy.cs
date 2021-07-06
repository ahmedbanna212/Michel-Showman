using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemy : EnemyController
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.CompareTag("Player")) 
        {
           FindObjectOfType<LevelManger>().RespawnPlayer();
           Destroy(gameObject);
}
   }
}
