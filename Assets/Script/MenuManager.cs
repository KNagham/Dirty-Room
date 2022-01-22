using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CheckPause();
        }
    }

    private void CheckPause()
    {
        if(isPaused ==false)
        {
            isPaused = true;
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        else if (isPaused == true)
        {
            isPaused = false;
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Resume()
    {
        isPaused = true;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
