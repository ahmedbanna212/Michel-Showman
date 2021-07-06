using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthpotion : MonoBehaviour
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
        if (other.name == "Player")
        {
            FindObjectOfType<PlayerStatus>().healthPotion += 1;
            Object.Destroy(this.gameObject,0.5f);
        }
    }
}
