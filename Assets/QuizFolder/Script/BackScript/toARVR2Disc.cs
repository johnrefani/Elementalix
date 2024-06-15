using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toARVR2Disc : MonoBehaviour
{
    private string SceneToGo = "ARVR Lesson2_Discussion";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
