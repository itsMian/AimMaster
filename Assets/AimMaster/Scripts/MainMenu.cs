using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject exitPanel;

    public void Tasks()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitPanel()
    {
        exitPanel.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Cancel()
    {
        exitPanel.SetActive(false);
    }
}
