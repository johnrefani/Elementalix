using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LessonEvent : MonoBehaviour
{
    private string StartPage = "StartingPage";

    public void ExitToMain()
    {
        SceneManager.LoadScene(StartPage);
    }
}
