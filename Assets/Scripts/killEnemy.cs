using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killEnemy : MonoBehaviour {

    public GameObject Enemy;
    

    void OnTriggerEnter2D(Collider2D cc)
    {
        if (cc.tag == "Player")
        {
            Destroy(Enemy);
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
