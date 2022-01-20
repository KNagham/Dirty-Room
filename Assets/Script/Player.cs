using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int speed;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
       /* oder
         gameManager = FindObjectOfType<GameManager>();
       */
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }
    void Move()
    {
        float hor = Input.GetAxis("Horizontal");
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.8f, 2.8f), -3, 0);
        transform.position += new Vector3(hor * Time.deltaTime * speed, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameManager.DecreaseHp();
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("ScoreZone"))
        {
            gameManager.SetScore();
        }
        if (other.gameObject.CompareTag("Life"))
        {
            gameManager.IncreaseHp();
            Destroy(other.gameObject);
        }
    }
}
