using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inactive : MonoBehaviour
{
    public GameObject clickables;

    public void disables()
    {
        clickables.SetActive(false);
    }


}
