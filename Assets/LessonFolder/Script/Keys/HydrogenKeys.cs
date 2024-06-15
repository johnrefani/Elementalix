using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrogenKeys : MonoBehaviour
{



    public GameObject disables;
    public GameObject disables1;
    public GameObject disables2;

    public void Disab()
    {
        disables.SetActive(false);
        disables1.SetActive(false);
        disables2.SetActive(false);

    }

}
