using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toQuizTest1 : MonoBehaviour
{
    private string SceneToGo = "QuizTest1";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
