using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    public string Lesson1 = "Lesson 1";
    public string Lesson2 = "Lesson 2";
    public string Lesson3 = "Lesson 3";
    public string Lesson4 = "Lesson 4";
    public string Final = "Final";
    public void OpenFinal()
    {
        SceneManager.LoadScene(Final);
    }

    public void OpenLesson1()
    {
        SceneManager.LoadScene(Lesson1);
    }

    public void OpenLesson2()
    {
        SceneManager.LoadScene(Lesson2);
    }

    public void OpenLesson3()
    {
        SceneManager.LoadScene(Lesson3);
    }

    public void OpenLesson4()
    {
        SceneManager.LoadScene(Lesson4);
    }
}

