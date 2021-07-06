using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject Dialoug;
    public GameObject panelShop;
    public GameObject panelGameOver;
    int score;
    public Text scoree;

    // Update is called once per frame
    public void gameOver()
    {
        pauseMenuUI.SetActive(false);
        Dialoug.SetActive(false);
        panelShop.SetActive(false);
        panelGameOver.SetActive(true);


    }
    void Update()
    {
        if (FindObjectOfType<PlayerStatus>() != null) {
            score = FindObjectOfType<PlayerStatus>().score;
        
        }
        scoree.text = "" + FindObjectOfType<PlayerStatus>().score;
        if (Input.GetKeyDown(KeyCode.Escape))
        {


            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()

    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Shop()
    {
        
        
        Debug.Log("Shop...");
    }
    public void LoadMenu()
    {
       
        Debug.Log("Main Menu...");
    }
    public void buyhealthPotion()
    {
        if (FindObjectOfType<PlayerStatus>().coinsCollected > 50)
        {
            FindObjectOfType<PlayerStatus>().healthPotion += 1;
            FindObjectOfType<PlayerStatus>().coinsCollected -= 50;
        }
        else {
            Debug.Log("Not enough money");
        }
    }
    public void buyManaPotion()
    {
        if (FindObjectOfType<PlayerStatus>().coinsCollected > 40)
        {
            FindObjectOfType<PlayerStatus>().ManaPotion += 1;
            FindObjectOfType<PlayerStatus>().coinsCollected -= 40;
        }
        else
        {
            Debug.Log("Not enough money");
        }
    }
    public void gameOverRestart() {
        SceneManager.LoadScene(1);
    }
    public void gameOverquit()
    {
        SceneManager.LoadScene(0);
    }
    
}