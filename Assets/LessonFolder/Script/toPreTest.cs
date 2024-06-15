using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toPreTest : MonoBehaviour
{
    private string SceneToGo = "Pre-Test";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }
}

