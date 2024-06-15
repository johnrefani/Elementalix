using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSetter : MonoBehaviour
{
    public int gainAccessKeyLevel;

    public void SetAccessLevel()
    {
        
        PlayerPrefs.SetInt("AccessLevel", gainAccessKeyLevel);
        //PlayerPrefs.Save();

        int highestLevel = PlayerPrefs.GetInt("HighestLevel", 0);
        if (gainAccessKeyLevel > highestLevel)
        {
            PlayerPrefs.SetInt("HighestLevel", gainAccessKeyLevel);
            PlayerPrefs.Save();
        }
        //
    }

}
