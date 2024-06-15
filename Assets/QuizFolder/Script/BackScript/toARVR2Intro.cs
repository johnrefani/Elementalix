using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toARVR2Intro : MonoBehaviour
{
    private string SceneToGo = "ARVR Lesson2_Introduction";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}

