using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toIntro : MonoBehaviour
{
    private string SceneToGo = "ARVR_intro BETA";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
