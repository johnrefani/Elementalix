using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rstbutton : MonoBehaviour
{
  
    public void Rstr()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
