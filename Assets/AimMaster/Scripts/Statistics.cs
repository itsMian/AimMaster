using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public Text targetHitted;
    public Text targetMissed;
    public Text accuracy;
    public Text score;

    public AimStats aimStats;

    // Update is called once per frame
    void Update()
    {
        targetHitted.text = "Target Hitted: " + TargetDetect.hitPoint.ToString();
        targetMissed.text = "Target Missed: " + TargetDetect.missPoint.ToString();
        accuracy.text = "Accuracy: " + aimStats.accuracyText.text;
        score.text = aimStats.scoreText.text;
    }

    public void PlayAgain()
    {
        this.gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        aimStats.Start();
    }

    public void BackToTasks()
    {
        SceneManager.LoadScene(1);
    }    
}
