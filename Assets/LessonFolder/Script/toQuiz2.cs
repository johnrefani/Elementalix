using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toQuiz2 : MonoBehaviour
{
    private string SceneToGo = "Quiz2";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
