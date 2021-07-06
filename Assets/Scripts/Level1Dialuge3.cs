using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Dialuge3 : MonoBehaviour
{
    public dialogueManager asd;
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

        if (other.tag == "Player")
        {
            string[] dialogue = {
             "That was tough",
             "You can replenish health and mana by using potions",
             "click 1 to replenish health and 2 to replenish mana",
             };
            asd.SetSentence(dialogue);
            asd.StartCoroutine(asd.Type());
        }

        Object.Destroy(this.gameObject);
    }
}

