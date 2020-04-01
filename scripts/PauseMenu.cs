using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    // Start is called before the first frame update
    public static bool GameisPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameisPaused = false;

        if (GameisPaused == false && player.isGameOver == true)
        {
            Time.timeScale = 0f;

            if (Restart.hasRestarted == true)
            {
                Restart.hasRestarted = false; 
                player.isGameOver = false;
                Time.timeScale = 1f;

            }
            else if (Restart.hasRestarted == false)
            {
                Restart.hasRestarted = false;
                player.isGameOver = true;
                Time.timeScale = 0f;
            }
        }
        else if (GameisPaused == false && player.isGameOver == false)
        {
            Time.timeScale = 1f;

        }
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;

    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
