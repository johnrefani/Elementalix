using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nexttScene : MonoBehaviour
{
    private string SceneToGo = "LessonScene";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }
}

