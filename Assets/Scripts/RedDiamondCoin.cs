using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDiamondCoin : MonoBehaviour
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
            FindObjectOfType<AudioManager>().Play("coin");
            FindObjectOfType<PlayerStatus>().coinsCollected += 10;
            Object.Destroy(this.gameObject);
        }
    }
}
