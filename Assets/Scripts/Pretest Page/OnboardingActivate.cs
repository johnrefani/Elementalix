using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnboardingActivate : MonoBehaviour
{
    
    public void ActivateOnboarding()
    {
        PlayerPrefs.SetInt("OnboardingStatus", 1);
        PlayerPrefs.Save();
    }
}
