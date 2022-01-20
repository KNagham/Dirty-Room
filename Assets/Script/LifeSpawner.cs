using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpawner : MonoBehaviour
{
    [SerializeField] GameObject life;
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
            Instantiate(life, new Vector3(Random.Range(-2.9f, 2.9f), 10, 0), Quaternion.identity);
        }
    }
}
