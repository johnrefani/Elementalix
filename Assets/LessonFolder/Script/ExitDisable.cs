using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDisable : MonoBehaviour
{
    public GameObject exitObj;
   public void Exits()

    {
        if (exitObj.activeInHierarchy == true)
        {
            exitObj.SetActive(false);
        }
        else
        {
            exitObj.SetActive(true);   
        }
    }
}
