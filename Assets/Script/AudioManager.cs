using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] List <AudioClip> Clips;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayYummi()
    {
        audioSource.clip = Clips[Random.Range(0, 2)];
        audioSource.Play();
    }
    public void PlayEnemy()
    {
        audioSource.clip = Clips[2];
        audioSource.Play();
    }
}
