using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoindPickUp : MonoBehaviour {

    public int coinGold = 5;

    void Start () {
		
	}
	

	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //FindObjectOfType<playerStats>().collectCoin(coinGold);
            Destroy(this.gameObject);
        }
    }

}
