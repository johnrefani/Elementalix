using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenKeys : MonoBehaviour
{

    public GameObject inactive;
    public GameObject inactive1;

    public void Disab()
    {
        inactive.SetActive(false);
        inactive1.SetActive(false);
}

}
