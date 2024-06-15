using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMixing : MonoBehaviour
{
    private string SceneToGo = "Quiz4";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
