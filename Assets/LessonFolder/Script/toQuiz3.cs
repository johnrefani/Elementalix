using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toQuiz3 : MonoBehaviour
{
    private string SceneToGo = "Quiz3";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
