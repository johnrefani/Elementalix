using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PretestCommand : MonoBehaviour
{
    public string beginpretest = "FirstTimeQuiz";
    public GameObject Warning;

    void Start()
    {
        Warning.SetActive(false);
    }
    public void TapToBeginPretest()
    {
        Warning.SetActive(true);
    }

    public void TapToClose()
    {
        Warning.SetActive(false);
    }

    public void TransitionToPretest()
    {
        Warning.SetActive(false);
        SceneManager.LoadScene(beginpretest);

        // Set onboarding as completed
        //PlayerPrefs.SetInt("OnboardingStatus", 1);
        //PlayerPrefs.Save();
    }
}
