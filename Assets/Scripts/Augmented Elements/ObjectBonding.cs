using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBonding : MonoBehaviour
{
    [SerializeField] private List<GameObject> elements;
    [SerializeField] private float distance;
    [SerializeField] private GameObject bondObject;

    //[SerializeField] private IncreaseAtomicCount increaseAtomicCount1, increaseAtomicCount2;
    [SerializeField] private IncreaseAtomicCount[] increaseAtomicCounts;



    private bool bonded = false; // Flag to track whether elements are bonded

    void Start()
    {
        bondObject.SetActive(false);
    }

    void Update()
    {
        // Check if enough elements are active for bonding
        if (elements.Count >= 2 && !bonded)
        {
            // Check if all elements are active
            bool allElementsActive = true;
            foreach (GameObject element in elements)
            {
                if (!element.activeSelf) // Check element's active state directly
                {
                    allElementsActive = false;
                    break;
                }
            }

            if (allElementsActive)
            {
                // Calculate the center of the bond
                Vector3 center = Vector3.zero;
                foreach (GameObject element in elements)
                {
                    center += element.transform.position;
                }
                center /= elements.Count;

                // Check if elements are close enough for bonding
                bool closeEnough = true;
                foreach (GameObject element in elements)
                {
                    if (Vector3.Distance(element.transform.position, center) >= distance)
                    {
                        closeEnough = false;
                        break;
                    }
                }

                if (closeEnough)
                {
                    // Bond the elements
                    foreach (GameObject element in elements)
                    {
                        element.SetActive(false);
                    }

                    bondObject.transform.position = center;
                    bondObject.SetActive(true);

                    bonded = true; // Set the bonded flag to true

                    //increaseAtomicCount1.DisableAllButton();
                    //increaseAtomicCount2.DisableAllButton();

                    foreach (IncreaseAtomicCount increaseAtomicCount in increaseAtomicCounts)
                    {
                        increaseAtomicCount.DisableAllButton();
                    }
                }
            }
        }
        else if (bonded)
        {
            // Check if elements are too far apart and unbind them.
            bool tooFarApart = false;
            foreach (GameObject element in elements)
            {
                if (Vector3.Distance(element.transform.position, bondObject.transform.position) >= distance)
                {
                    tooFarApart = true;
                    break;
                }
            }

            if (tooFarApart)
            {
                // Unbind the elements
                bonded = false; // Reset the bonded flag
                bondObject.SetActive(false);
                foreach (GameObject element in elements)
                {
                    element.SetActive(true);
                }

                //increaseAtomicCount1.ResetAllElement();
                //increaseAtomicCount2.ResetAllElement();

                foreach (IncreaseAtomicCount increaseAtomicCount in increaseAtomicCounts)
                {
                    increaseAtomicCount.ResetAllElement();
                }
            }
        }
    }
}


