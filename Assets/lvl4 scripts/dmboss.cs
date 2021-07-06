using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class dmboss : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    private string[] dialogueSentences;
    private int index = 0;
    public float typingspeed;
    public GameObject ContinueButton;
    public GameObject DBOX;
    public Rigidbody2D playerRB;
    public Rigidbody2D enemy;
    void Start()
    {
      
        ContinueButton.SetActive(false);
        enemy.constraints =
     RigidbodyConstraints2D.FreezePositionX |
     RigidbodyConstraints2D.FreezePositionY;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator Type()
    {
        DBOX.SetActive(true);
        playerRB.constraints =
         RigidbodyConstraints2D.FreezePositionX |
         RigidbodyConstraints2D.FreezePositionY;


        foreach (char letter in dialogueSentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingspeed);
            if (textDisplay.text == dialogueSentences[index]) { ContinueButton.SetActive(true); }
        }




    }
    public void SetSentence(string[] sentences)
    {
        this.dialogueSentences = sentences;
    }
    public void NextSentence()
    {
        ContinueButton.SetActive(false);
        if (index < dialogueSentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            ContinueButton.SetActive(false);
            DBOX.SetActive(false);
            this.dialogueSentences = null;
            index = 0;
            enemy.constraints = RigidbodyConstraints2D.None;
            enemy.constraints = RigidbodyConstraints2D.FreezeRotation;
            playerRB.constraints = RigidbodyConstraints2D.None;
            playerRB.constraints = RigidbodyConstraints2D.FreezeRotation;
            


        }
    }


}




