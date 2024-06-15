using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro1toDiscuss1 : MonoBehaviour
{

    private string SceneToGo = "ARVR Lesson1_Discussion";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }
}
