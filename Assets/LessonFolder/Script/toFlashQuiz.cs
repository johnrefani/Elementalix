using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toFlashQuiz : MonoBehaviour
{
    private string SceneToGo = "FlashQuiz";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }

}
