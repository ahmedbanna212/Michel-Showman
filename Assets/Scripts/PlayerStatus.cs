using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerStatus : MonoBehaviour
{
    public Slider HealthVal;
    public Slider mana;
    public Text Score;
    public Text potion;
    public Text Lives;
    public Text manaP;
    public Text keyP;
    public Text coins;
    public int health = 6;
    public int Mana = 6;
    public int key = 0;
    public int Damge = 3;
    public int lives = 3;
    public int score = 0;
    private SpriteRenderer spriteRenderer;
    public int coinsCollected = 0;
    public int healthPotion = 0;
    public int ManaPotion = 0;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.lives == 0 && this.health <= 0)
        {
            FindObjectOfType<PauseMenu>().gameOver();
            Destroy(this.gameObject);
        }
        if (this.lives > 0 && this.health <= 0)
        {
            FindObjectOfType<LevelManger>().RespawnPlayer();
            health = 6;
            lives--;

        }

        HealthVal.value = health;
        mana.value = Mana;
        Score.text = "" + score;
        potion.text = "" + healthPotion;
        manaP.text = "" + ManaPotion;
        keyP.text = "" + key;
        coins.text = "" + coinsCollected;
        Lives.text = "" + lives;
    }
    public void TakeDamage(int damge)
    {
        this.health -= damge;
        anim.SetTrigger("Damged");
        if (this.lives > 0 && this.health <= 0)
        {
            FindObjectOfType<LevelManger>().RespawnPlayer();
            health = 6;
           
            lives--;

        }
        else if (this.lives == 0 && this.health <= 0)
        {
            FindObjectOfType<PauseMenu>().gameOver();
            Destroy(this.gameObject);
        }


    }
}
