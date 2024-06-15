using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class toPreTest2 : MonoBehaviour
{
    private string SceneToGo = "Riddle";


    public void ToNextScene()
    {
        SceneManager.LoadScene(SceneToGo);
    }


}
