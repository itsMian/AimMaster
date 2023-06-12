using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimStats : MonoBehaviour
{
    public Statistics statistics;
    public Countdown countdown;
    public Text timeText;
    public Text accuracyText;
    public Text scoreText;
    public Text clickToStartText;

    public float timeLeft = 90;
    public bool timerIsRunning = false;
    public float accuracy;
    int score = 0;
    bool isClicked = false;

    public void Start()
    {
        RestartSession();
    }
    void Update()
    {
        ClickToStart();
        DisplayTime(timeLeft);
        DisplayAccuracy(accuracy);
        DisplayScore(score);
        if(timerIsRunning)
        {
            if(timeLeft > 0) 
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                timeLeft = 0;
                timerIsRunning = false;
                statistics.gameObject.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
    public void DisplayTime(float timeLeft)
    {
        float minutes = Mathf.FloorToInt(timeLeft / 60);
        float seconds = Mathf.FloorToInt(timeLeft % 60);
        timeText.text = string.Format("{00:00}:{01:00}", minutes, seconds);
    }
    public void DisplayAccuracy(float acc)
    {
        int sum = TargetDetect.hitPoint + TargetDetect.missPoint;
        acc = TargetDetect.hitPoint * 100 / sum;
        accuracyText.text = acc + "%"; 
    }
    public void DisplayScore(int score)
    {
        score = TargetDetect.hitPoint * 375;
        scoreText.text = score + " pts";
    }
    public void RestartSession()
    {
        timeLeft = 90;
        TargetDetect.hitPoint = 0;
        TargetDetect.missPoint = 0;
        accuracy = 0;
        accuracyText.text = accuracy + "%";
        score = 0;
        scoreText.text = score.ToString();
        isClicked = false;
        clickToStartText.gameObject.SetActive(true);
    }
    public void ClickToStart()
    {
        if (Input.GetMouseButtonDown(0) && isClicked == false)
        {
            clickToStartText.gameObject.SetActive(false);
            countdown.StartCountdown();
            isClicked = true;
        }
    }
}
