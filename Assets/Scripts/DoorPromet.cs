using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPromet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag=="Player")
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}
