using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro3toDiscuss3 : MonoBehaviour
{
    private string SceneToGo = "ARVR Lesson3_Discussion";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }
}
