using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player") {
            FindObjectOfType<PlayerStatus>().health -= FindObjectOfType<PlayerStatus>().health;
            FindObjectOfType<AudioManager>().Play("spike");
            FindObjectOfType<LevelManger>().RespawnPlayer();

        }
    }

}
