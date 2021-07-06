using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossdl : MonoBehaviour
{
    public dmboss asd;
    // Start is called before the first frame update
    void Start()
    {
        string[] dialogue = {
             "micheal: Finally, we met again",
             "king of the pigs: ready to die little one ",
             "micheal: cut it out and lets end this",
             
             };
        asd.SetSentence(dialogue);
        asd.StartCoroutine(asd.Type());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
