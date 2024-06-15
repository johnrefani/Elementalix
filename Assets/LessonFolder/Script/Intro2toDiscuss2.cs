using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Intro2toDiscuss2 : MonoBehaviour
{
    private string SceneToGo = "ARVR Lesson2_Discussion";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }
}
