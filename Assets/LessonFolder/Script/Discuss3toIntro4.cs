using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Discuss3toIntro4 : MonoBehaviour

{
    private string SceneToGo = "ARVR Lesson4_Introduction";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }
}

