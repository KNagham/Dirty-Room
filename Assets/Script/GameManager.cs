using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private Player player;
    int score;
    [SerializeField] int hp;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI hpText;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
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
            Destroy(player.gameObject);
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
