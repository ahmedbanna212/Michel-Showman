using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialoguee : MonoBehaviour
{
    public ddialogueManager asd;
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
             "micheal : where are the people of this castle and who are you. ",
             "king of the pigs : I am the new king and this castle is under my command ",
             "king of the pigs : pigs!!! catch him. ",
             
             };
            asd.SetSentence(dialogue);
            asd.StartCoroutine(asd.Type());
        }
            

    }
}

