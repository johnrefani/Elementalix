using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NucleusController : MonoBehaviour
{
    public GameObject Protons;
    public GameObject Neutron;

    public void ProNeu()
    {
        if (Protons.activeInHierarchy == false && Neutron.activeInHierarchy == false)
        {
            Protons.SetActive(true);
            Neutron.SetActive(true);
        }
        else
        {
            Protons.SetActive(false);
            Neutron.SetActive(false);
        }
    }
}
