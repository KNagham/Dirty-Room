using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> grass;
    [SerializeField] float time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GrassSpawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GrassSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(grass[Random.Range(0, 3)], new Vector3(Random.Range(-30f, 30f), 0, 50), Quaternion.identity);
        }
    }
}
