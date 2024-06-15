using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayedSceneLoader : MonoBehaviour
{

    public string sceneToLoad;
    public float delayInSeconds = 2f;
    void Start()
    {
        Invoke("LoadSceneWithDelay", delayInSeconds);
    }

    void LoadSceneWithDelay()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
