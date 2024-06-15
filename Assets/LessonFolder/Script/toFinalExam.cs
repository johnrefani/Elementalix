using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toFinalExam : MonoBehaviour
{
    private string SceneToGo = "FinalExam";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
