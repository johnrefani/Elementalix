using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValenceController : MonoBehaviour
{
    public GameObject Parts;

    public void onoff()
    {
        if(Parts.activeInHierarchy == false)
        {
            Parts.SetActive(true);
        }
        else
        {
            Parts.SetActive(false);
        }
    }
}
