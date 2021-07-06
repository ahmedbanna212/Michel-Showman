using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            Invoke("disable", 0.02f);
        }
    }
    void disable() { gameObject.GetComponent<BoxCollider2D>().enabled = false; }
}
