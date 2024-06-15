using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Discuss2toIntro3 : MonoBehaviour
{
    private string SceneToGo = "ARVR Lesson3_Introduction";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }
}
