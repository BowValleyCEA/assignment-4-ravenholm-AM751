using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenuScript : MonoBehaviour
{
    public static bool GamePaused = false;

    public GameObject PauseMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
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
                PauseMenu.SetActive(false);
                Time.timeScale = 1f;
                GamePaused = false;
            }

            public void Pause()
            {
                PauseMenu.SetActive(true);
                Time.timeScale = 0f;
                GamePaused = true;
            }
            
            public void Menu()
            {
              Time.timeScale = 1f;
              SceneManager.LoadScene(0);
            }

            public void QuitGame()
            {
              Application.Quit();
            }
}
    
