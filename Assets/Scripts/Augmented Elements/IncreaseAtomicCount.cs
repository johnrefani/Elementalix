using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class IncreaseAtomicCount : MonoBehaviour
{

    public GameObject atomicCountZero, atomicCountOne, atomicCountTwo;

    public GameObject atomicButtonZero, atomicButtonOne, atomicButtonTwo;

    void Start()
    {
        ResetAllElement();
    }

    public void ActiveCountZero()
    {
        atomicCountZero.SetActive(true);
        atomicCountOne.SetActive(false);
        atomicCountTwo.SetActive(false);

        atomicButtonZero.SetActive(false);
        atomicButtonOne.SetActive(true);
        atomicButtonTwo.SetActive(true);
    }

    public void ActiveCountOne()
    {
        atomicCountZero.SetActive(false);
        atomicCountOne.SetActive(true);
        atomicCountTwo.SetActive(false);

        atomicButtonZero.SetActive(true);
        atomicButtonOne.SetActive(false);
        atomicButtonTwo.SetActive(true);
    }

    public void ActiveCountTwo()
    {
        atomicCountZero.SetActive(false);
        atomicCountOne.SetActive(false);
        atomicCountTwo.SetActive(true);

        atomicButtonZero.SetActive(true);
        atomicButtonOne.SetActive(true);
        atomicButtonTwo.SetActive(false);
    }

    public void DisableAllButton()
    {

        atomicButtonZero.SetActive(false);
        atomicButtonOne.SetActive(false);
        atomicButtonTwo.SetActive(false);
    }

    public void ResetAllElement()
    {

        atomicCountZero.SetActive(true);
        atomicCountOne.SetActive(false);
        atomicCountTwo.SetActive(false);

        atomicButtonZero.SetActive(false);
        atomicButtonOne.SetActive(true);
        atomicButtonTwo.SetActive(true);
    }


}