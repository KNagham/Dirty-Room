using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpawner : MonoBehaviour
{
    [SerializeField] List <GameObject> life;
    [SerializeField] float time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LifeSpawn");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator LifeSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(life[Random.Range(0,3)], new Vector3(Random.Range(-2.9f, 2.9f), 1, 20), Quaternion.identity);
        }
    }
}
