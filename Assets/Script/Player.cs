using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int speed;

    // Start is called before the first frame update
    void Start()
    {
        
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
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("ScoreZone"))
        {
            Debug.Log("Score +1");
        }
    }
}
