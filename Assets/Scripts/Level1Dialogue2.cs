using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Dialogue2 : MonoBehaviour
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
             "you will have to defeat this enemy",
             "use Left mouse button to do a melee attack",
             "use Right mouse button to do a throw attack",
             "but be careful throw attack costs mana",
             };
            asd.SetSentence(dialogue);
            asd.StartCoroutine(asd.Type());
        }

        Object.Destroy(this.gameObject);
    }
}

