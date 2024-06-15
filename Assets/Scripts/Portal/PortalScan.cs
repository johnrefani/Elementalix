using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PortalScan : MonoBehaviour
{
    public GameObject PortalPanel;
    public TMP_Text PortalText;
    void Start()
    {
        PortalPanel.SetActive(false);
        PortalText.text = "";
    }

    public void ShowPortalPanel(string info)
    {
        PortalPanel.SetActive(true);
        PortalText.text = info; 
    }

    public void HidePortalPanel()
    {

        PortalPanel.SetActive(false);
    }

}
