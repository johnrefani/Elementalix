using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Loading : MonoBehaviour
{
    public string OnboardingPage = "PretestPage";
    public string StartMenuPage = "StartingPage";
    public VideoPlayer videoplayer;

    void Start()
    {
        videoplayer.loopPointReached += OnVideoEnd;
        videoplayer.Play();
    }

    void OnVideoEnd (VideoPlayer vp)
    {
        int onboardingStatus = PlayerPrefs.GetInt("OnboardingStatus", 0);

        if (onboardingStatus == 0)
        {

            SceneManager.LoadScene(OnboardingPage);
        }
        else if (onboardingStatus == 1)
        {

            SceneManager.LoadScene(StartMenuPage);
        }
    }

}

