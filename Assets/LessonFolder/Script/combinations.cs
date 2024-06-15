using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combinations : MonoBehaviour
{
    public GameObject oxygen;
    public GameObject hydrogen;
    public GameObject carbon;
    public GameObject sodium;
    public GameObject chlorine;

    public GameObject water;
    public GameObject carbondioxide;
    public GameObject salt;

    public GameObject watertxt;
    public GameObject carbondioxidetxt;
    public GameObject salttxt;


    public GameObject Elements;
    public GameObject Element3d;
    public GameObject ResetBttn;


    public void combine()
    {
        if (oxygen.activeInHierarchy && hydrogen.activeInHierarchy) {
            water.SetActive(true);
            watertxt.SetActive(true);
            ResetBttn.SetActive(true);

            Elements.SetActive(false);
            Element3d.SetActive(false);

        }
        else if (carbon.activeInHierarchy && oxygen.activeInHierarchy)
        {
            carbondioxide.SetActive(true);
            carbondioxidetxt.SetActive(true);
            ResetBttn.SetActive(true);

            Elements.SetActive(false);
            Element3d.SetActive(false);
        }
        else if(sodium.activeInHierarchy && chlorine.activeInHierarchy)
        {
            salt.SetActive(true);
            salttxt.SetActive(true);
            ResetBttn.SetActive(true);

            Elements.SetActive(false);
            Element3d.SetActive(false);
        }


    }




}
