using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Discuss4toExit : MonoBehaviour
{
    private string SceneToGo = "EndCredits";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }
}
