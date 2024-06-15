using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    private string startingpage = "StartingPage"; 
    public void ExitToMain()
    {
        SceneManager.LoadScene(startingpage);
    }
}
