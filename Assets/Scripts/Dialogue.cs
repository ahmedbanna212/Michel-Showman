using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
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
             "hey",
             "omk",
             "o5tk",
             "by"
             };
            asd.SetSentence(dialogue);
            asd.StartCoroutine(asd.Type());
        }
            

    }
}

