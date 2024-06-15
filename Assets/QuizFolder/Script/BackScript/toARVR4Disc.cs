using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toARVR4Disc : MonoBehaviour
{
    private string SceneToGo = "ARVR Lesson4_Discussion";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
