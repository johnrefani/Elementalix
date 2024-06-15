using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Discuss1toIntro2 : MonoBehaviour
{
    private string SceneToGo = "ARVR Lesson2_Introduction";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }

}
