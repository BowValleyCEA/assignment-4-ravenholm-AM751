using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    public static bool GamePaused = false;

    [SerializeField] private GameObject PauseMenu;
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
            void Resume()
            {
                PauseMenu.SetActive(false);
                Time.timeScale = 1f;
                GamePaused = false;
            }

            void Pause()
            {
                PauseMenu.SetActive(true);
                Time.timeScale = 0f;
                GamePaused = true;
            }
        }
    
