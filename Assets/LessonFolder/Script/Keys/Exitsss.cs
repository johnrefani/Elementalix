using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exitss : MonoBehaviour
{
    private string startingpage = "LessonScene"; 
    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(startingpage);
    }
}
