using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class EnableOrDisabled : MonoBehaviour
{
   
    public GameObject clickme;
    public GameObject skip;
    public GameObject videoPlayer;
    public void Trigger()
    {
        if (clickme.activeInHierarchy == true)
        {
            clickme.SetActive(false);
            skip.SetActive(true);
            videoPlayer.SetActive(true);
        }
        else
        {
            clickme.SetActive(true);
            skip.SetActive(false);
            videoPlayer.SetActive(false);
        }
    
}

}
