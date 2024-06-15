using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toARVR1Intro : MonoBehaviour
{
    private string SceneToGo = "ARVR Lesson1_Introduction";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
