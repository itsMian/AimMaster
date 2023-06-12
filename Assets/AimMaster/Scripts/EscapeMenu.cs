using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EscapeMenu : MonoBehaviour
{
    public AimStats aimStats;
    public Countdown countdown;
    public GameObject pausedMenu;
    public GameObject exitPanel;

    public bool gameIsPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            gameIsPaused = !gameIsPaused;
        }
        Paused();
    }
    void Paused()
    {
        if(gameIsPaused)
        {
            pausedMenu.SetActive(true);
            aimStats.timerIsRunning = false;
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            PlayerController.mouseSensitivity = 0f;
        }
        else
        {
            pausedMenu.SetActive(false);
            countdown.isCountingDown = true;
            countdown.Update();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            PlayerController.mouseSensitivity = PlayerController.mouseSensStored;
        }
    }
    public void Resume()
    {
        gameIsPaused = false;
    }
    public void Options()
    {
    
    }
    public void Exit()
    {
        exitPanel.SetActive(true);
    }
    public void Yes()
    {
        SceneManager.LoadScene(1);
    }
    public void No()
    {
        exitPanel.SetActive(false);
    }
}
