using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HelpPanel : MonoBehaviour
{
    public GameObject helpPanel;
    public Image[] imageSet;
    public Image image;
    public TMP_Text helpText, helpHeader;
    public Button previousButton;
    private int currentIndex = 0;

    void Start()
    {
        helpPanel.SetActive(false);
        UpdateHelpText(0); // Show the initial help message when the scene starts.
        previousButton.interactable = false; // Disable the previous button initially.
    }

    public void OpenHelp()
    {
        helpPanel.SetActive(true);
        currentIndex = 0; // Reset the current index to 0 when opening the help panel.
        UpdateHelpText(currentIndex); // Update the help text to show the content at index 0.
        previousButton.interactable = false; // Disable the previous button when starting at index 0.
    }

    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }

    public void NextHelp()
    {
        if (currentIndex < imageSet.Length - 1)
        {
            currentIndex++;
            UpdateHelpText(currentIndex);
            previousButton.interactable = true; // Enable the previous button when not in the first index.
        }
        else
        {
            // If it's the last index, close the help panel.
            CloseHelp();
        }
    }

    public void PreviousHelp()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            UpdateHelpText(currentIndex);
            if (currentIndex == 0)
            {
                previousButton.interactable = false; // Disable the previous button when in the first index.
            }
        }
    }

    // Function to update the help text and image based on the current index.
    private void UpdateHelpText(int index)
    {
        if (index >= 0 && index < imageSet.Length)
        {
            helpHeader.text = GetHelpHeaderText(index);
            helpText.text = GetHelpText(index);
            image.sprite = imageSet[index].sprite;
        }
    }

    // Define your help header text here based on the index.
    private string GetHelpHeaderText(int index)
    {
        switch (index)
        {
            case 0:
                return "Scan Cards to Reveal 3D Objects";
            case 1:
                return "Combine Cards for Reactions";
            case 2:
                return "Tap 3D Objects for Descriptions";
            case 3:
                return "Reload for Troubleshooting";
            case 4:
                return "Access Tutorials with Help";
                
            default:
                return "";
        }
    }

    // Define your help text here based on the index.
    private string GetHelpText(int index)
    {
        switch (index)
        {
            case 0:
                return "Point your device's camera at AR cards to reveal 3D objects. Each card represents an element or molecule.";
            case 1:
                return "Place two cards next to each other to trigger chemical reactions. Experiment with different combinations!";
            case 2:
                return "Tap on 3D objects to view detailed descriptions. Learn about their properties, uses, and more.";
            case 3:
                return "If an object isn't loading correctly or if you encounter a bug, tap the reload icon to refresh the AR experience.";
            case 4:
                return "If you need assistance or want to revisit the tutorial, tap the help button to access the tutorial from the beginning.";
            default:
                return "";
        }
    }
}
