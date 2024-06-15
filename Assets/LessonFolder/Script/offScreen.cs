using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offScreen : MonoBehaviour
{
    public GameObject screens;


    public void deminished()
    {
        screens.SetActive(false);
    }
}
