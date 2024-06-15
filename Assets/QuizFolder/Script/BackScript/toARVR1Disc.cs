using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toARVR1Disc : MonoBehaviour
{
    private string SceneToGo = "ARVR Lesson1_Discussion";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
