using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public string OnboardingPage = "PretestPage";
    public string StartMenuPage = "StartingPage";
    public float delay = 4.5f;

    void Start()
    {
        int onboardingStatus = PlayerPrefs.GetInt("OnboardingStatus", 0);

        if (onboardingStatus == 0)
        {
            // Play onboarding
            Debug.Log("Playing Pretest");

            // Add a 5-second delay before logging
            Invoke("Pretest", delay);
        }
        else if (onboardingStatus == 1)
        {
            // Play intro
            Debug.Log("Playing Intro");

            // Add a 5-second delay before logging
            Invoke("MainMenu", delay);
        }
    }

    void Pretest()
    {
        Debug.Log("Logged Intro after 5 seconds");
        // Add any additional code you want to execute after the delay

        SceneManager.LoadScene(OnboardingPage);
    }

    void MainMenu()
    {
        Debug.Log("Logged Intro after 5 seconds");
        // Add any additional code you want to execute after the delay

        SceneManager.LoadScene(StartMenuPage);
    }
}

