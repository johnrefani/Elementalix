using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class toQuiz1 : MonoBehaviour
{
    private string SceneToGo = "Quiz1";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }

}
