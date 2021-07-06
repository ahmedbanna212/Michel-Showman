using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Dialogue : MonoBehaviour
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
             "you have reatched the island finally ",
             "you have to find your way to the treasure location",
             "Watch out the monsters and traps on your way",
             "you can fight or avoid them  ",
             "your object is to find the treasure in the end of the island",
             };
            asd.SetSentence(dialogue);
            asd.StartCoroutine(asd.Type());
        }

        Object.Destroy(this.gameObject);
    }
}

