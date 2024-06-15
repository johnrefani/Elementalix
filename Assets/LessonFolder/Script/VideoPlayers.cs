using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayers : MonoBehaviour
{
    public GameObject videos;
    public GameObject video2;

    public void Triggers()
    {
        if (videos.activeInHierarchy)
        {
            video2.SetActive(false);
        }
        else
        {
            videos.SetActive(true);
        }
    }
}
