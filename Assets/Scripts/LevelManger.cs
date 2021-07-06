using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManger : MonoBehaviour
{
    public GameObject CurrentCheckpoint;
    public GameObject Level1part2;
    public GameObject Level1part3;
    public GameObject Level1part4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnPlayer() {
        FindObjectOfType<playerController>().transform.position = CurrentCheckpoint.transform.position;
      
    }
    public void GoToPart2() {
        FindObjectOfType<playerController>().transform.position = Level1part2.transform.position;
        GameObject.Find("Main Camera").transform.position = new Vector3(4.44f, 0.4168669f,-10);
    }
    public void GoToPart3()
    {
        FindObjectOfType<playerController>().transform.position = Level1part3.transform.position;
        GameObject.Find("Main Camera").transform.position = new Vector3(15.021f, 0.634f, -10f);
    }
    public void GoToPart4()
    {
        FindObjectOfType<playerController>().transform.position = Level1part4.transform.position;
        GameObject.Find("Main Camera").transform.position = new Vector3(26.35f, 0.65f, -10f);
    }
}
