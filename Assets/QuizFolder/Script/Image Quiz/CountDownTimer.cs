using TMPro;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{
    public float startTime = 60.0f; // Set the initial countdown time in seconds
    private float timeRemaining;

    public TMP_Text timerText; // Reference to the UI Text component for displaying the timer

    void Start()
    {
        timeRemaining = startTime;

        
    }

    void Update()
    {
        // Decrement the time remaining by the delta time
        timeRemaining -= Time.deltaTime;

        // Calculate minutes and seconds from the remaining time
        int minutes = Mathf.FloorToInt(timeRemaining / 60.0f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60.0f);

        // Update the timer text display
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        // Check if the time has reached zero
        if (timeRemaining <= 0.0f)
        {
            // Run Debug.Log when the timer reaches zero
            Debug.Log("Countdown timer has reached zero!");

            // Stop the timer by setting the time remaining to zero
            timeRemaining = 0.0f;
        }
    }

    public void ResetTimer()
    {
        // Reset the timer back to its initial start time
        timeRemaining = startTime;

        // Update the timer text display
        timerText.text = string.Format("{0:00}:{1:00}", startTime / 60, startTime % 60);
    }
}
