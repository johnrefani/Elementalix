using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toQuizTest2 : MonoBehaviour
{
    private string SceneToGo = "QuizTest2";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
