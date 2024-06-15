using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toARVR3Disc : MonoBehaviour
{
    private string SceneToGo = "ARVR Lesson3_Discussion";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
