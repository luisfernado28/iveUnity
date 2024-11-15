using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText; // Use Unity's default Text component
    public float totalTimeInSeconds = 300; // 5 minutes in seconds
    private float currentTime;

    void Start()
    {
        currentTime = totalTimeInSeconds; // Initialize the timer
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime; // Decrease the time
            UpdateTimerDisplay();
        }
        else
        {
            currentTime = 0; // Ensure it doesn't go negative
            UpdateTimerDisplay();
            OnTimerEnd();
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60); // Calculate minutes
        int seconds = Mathf.FloorToInt(currentTime % 60); // Calculate seconds

        timerText.text = "Time Remaining: "+string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void OnTimerEnd()
    {
        // Code to execute when the timer ends
        Debug.Log("Timer has ended!");
    }
}
