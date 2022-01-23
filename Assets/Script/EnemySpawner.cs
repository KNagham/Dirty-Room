using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List <GameObject> enemy;
    [SerializeField] float time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnEnemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(enemy[Random.Range(0,4)], new Vector3(Random.Range(-2.9f, 2.9f), 1, 20), Quaternion.identity);
        }
    }
}
