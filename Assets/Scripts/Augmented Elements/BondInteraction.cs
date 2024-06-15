using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BondInteraction : MonoBehaviour
{
    [SerializeField] private GameObject element1, element2;
    [SerializeField] private AppManager appManager;
    [SerializeField] private float distance;
    [SerializeField] private GameObject bondObject;

    private bool bonded = false; // Flag to track whether elements are bonded

    void Start()
    {
        bondObject.SetActive(false);
    }
    void Update()
    {
        string elementName1 = element1.name;
        string elementName2 = element2.name;

        if (!bonded)
        {
            if (appManager.isElementActive(elementName1) && appManager.isElementActive(elementName2))
            {
                if (Vector3.Distance(element1.transform.position, element2.transform.position) < distance)
                {
                    bondObject.transform.position = (element1.transform.position + element2.transform.position) / 2;

                    element1.SetActive(false);
                    element2.SetActive(false);
                    bondObject.SetActive(true);

                    bonded = true; // Set the bonded flag to true
                }
            }
        }
        else
        {
            // If elements are already bonded, check if they are too far apart and unbind them.
            if (Vector3.Distance(element1.transform.position, element2.transform.position) >= distance)
            {
                bonded = false; // Reset the bonded flag
                bondObject.SetActive(false);
                element1.SetActive(true);
                element2.SetActive(true);
            }
        }
    }
}
