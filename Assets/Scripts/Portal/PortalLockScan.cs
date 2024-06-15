using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PortalLockScan : MonoBehaviour
{
    public GameObject PortalPanel;
    public TMP_Text PortalText;

    private int currentLevel;
    public GameObject interactableWarning;
    public GameObject lesson;
    private string warning = "This lesson is currently locked. Finish the previous topics first to continue";
    public int levelRequired;
    //public string info;

    void Start()
    {
        currentLevel = PlayerPrefs.GetInt("AccessLevel",0);
    }
    public void LevelUnlock(string info)
    {
        int highestLevel = PlayerPrefs.GetInt("HighestLevel", 0);

        if (currentLevel < highestLevel)
        {
            currentLevel = highestLevel;
        }

        if (currentLevel >= levelRequired)
        {
            PortalPanel.SetActive(true);
            PortalText.text = info;
            lesson.SetActive(true);
            interactableWarning.SetActive(false);

            if (currentLevel > highestLevel)
            {
                PlayerPrefs.SetInt("HighestLevel", currentLevel);
                PlayerPrefs.Save();
            }
        }
        else
        {
            PortalPanel.SetActive(true);
            PortalText.text = warning;
            lesson.SetActive(false);
            interactableWarning.SetActive(true);
        }
    }

    public void HidePortalPanel()
    {

        PortalPanel.SetActive(false);
    }

}