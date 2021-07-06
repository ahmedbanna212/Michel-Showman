using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Dialogue4 : MonoBehaviour
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
             "To interact with objects like chests and doors press W",
             };
            asd.SetSentence(dialogue);
            asd.StartCoroutine(asd.Type());
        }

        Object.Destroy(this.gameObject);
    }
}

