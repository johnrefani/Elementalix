using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro4toDiscuss4 : MonoBehaviour
{
    private string SceneToGo = "ARVR Lesson4_Discussion";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }
}
