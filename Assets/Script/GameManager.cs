using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    private Player player;
    int score;
    [SerializeField] int hp;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] GameObject gameOverMenu;
    bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        player = GameObject.Find("Player").GetComponent<Player>();
        Time.timeScale = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
        checkPlayerLife();
    }

    private void checkPlayerLife()
    {
        if (!isAlive)
        {
            Time.timeScale = 0;
        }
    }

    void UpdateUI()
    {
        scoreText.SetText("Score: " + score);
        hpText.SetText("Hp: " + hp);
        

    }

    public void SetScore()
    {
        score += 10;
       
    }

    public void DecreaseHp()
    {
        hp -= 1;
        if (hp <= 0) 
        {
            isAlive = false;
            Destroy(player.gameObject);
            gameOverMenu.SetActive(true);
        }

    }

    public void IncreaseHp()
    {
        if (hp < 5)
        {
            hp += 1;
        }
        else
        {
            score += 1000;
        }
    }
}
