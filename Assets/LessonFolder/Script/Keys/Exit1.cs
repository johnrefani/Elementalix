using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit1 : MonoBehaviour
{
    private string startingpage = "LessonScene"; 
    private string start = "StartingPage"; 
    private string lockedscene = "LessonSceneLocked"; 
    public void ExitToMain()
    {
        SceneManager.LoadScene(startingpage);
    }

    public void ExitToLockedscene()
    {
        SceneManager.LoadScene(lockedscene);
    }

    public void ExitToStart()
    {
        SceneManager.LoadScene(start);
    }
}
