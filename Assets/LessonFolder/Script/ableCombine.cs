using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ableCombine : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;

    public void notion()
    {
        if (gameObject2.activeInHierarchy || gameObject3.activeInHierarchy || gameObject4.activeInHierarchy) { 

            gameObject.SetActive(false);
        
        }
        else
        {
            gameObject.SetActive(true);
        }
    }

}
