using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float countdownDuration = 3f;
    public Text countdownText;

    public float countdown = 0f;
    public AimStats aimStats;
    public bool isCountingDown = false;

    public void Update()
    {
        if(isCountingDown)
        {
            countdown -= Time.deltaTime;

            countdownText.text = Mathf.CeilToInt(countdown).ToString();

            if(countdown <= 0f) 
            {
                isCountingDown = false;
                countdownText.gameObject.SetActive(false);

                aimStats.timerIsRunning = true;
            }
        }
    }

    public void StartCountdown()
    {
        countdownText.gameObject.SetActive(true);
        countdown = countdownDuration;
        isCountingDown = true;
    }
}
