using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Dialouge : MonoBehaviour
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
        if (other.tag == "player")
        {
            string[] dialogue = {
             "The treause location should be at the next island",
             "But instead Michel can see a castel there",
             };
            asd.SetSentence(dialogue);
            asd.StartCoroutine(asd.Type());
        }


    }
}

