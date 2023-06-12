using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskManager : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void Gridshot()
    {
        SceneManager.LoadScene("Gridshot");
    }
}
