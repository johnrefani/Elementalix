using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LessonHelpPanel : MonoBehaviour
{
    public GameObject Lesson_helpPanel;
    public Image[] Lesson_imageSet;
    public Image Lesson_image;
    public TMP_Text Lesson_helpText, Lesson_helpHeader;
    public Button Lesson_previousButton;
    private int Lesson_currentIndex = 0;

    void Start()
    {
        Lesson_helpPanel.SetActive(false);
        Lesson_UpdateHelpText(0); // Show the initial help message when the scene starts.
        Lesson_previousButton.interactable = false; // Disable the previous button initially.
    }

    public void Lesson_OpenHelp()
    {
        Lesson_helpPanel.SetActive(true);
        Lesson_currentIndex = 0; // Reset the current index to 0 when opening the help panel.
        Lesson_UpdateHelpText(Lesson_currentIndex); // Update the help text to show the content at index 0.
        Lesson_previousButton.interactable = false; // Disable the previous button when starting at index 0.
    }

    public void Lesson_CloseHelp()
    {
        Lesson_helpPanel.SetActive(false);
    }

    public void Lesson_NextHelp()
    {
        if (Lesson_currentIndex < Lesson_imageSet.Length - 1)
        {
            Lesson_currentIndex++;
            Lesson_UpdateHelpText(Lesson_currentIndex);
            Lesson_previousButton.interactable = true; // Enable the previous button when not in the first index.
        }
        else
        {
            // If it's the last index, close the help panel.
            Lesson_CloseHelp();
        }
    }

    public void Lesson_PreviousHelp()
    {
        if (Lesson_currentIndex > 0)
        {
            Lesson_currentIndex--;
            Lesson_UpdateHelpText(Lesson_currentIndex);
            if (Lesson_currentIndex == 0)
            {
                Lesson_previousButton.interactable = false; // Disable the previous button when in the first index.
            }
        }
    }

    // Function to update the help text and image based on the current index.
    private void Lesson_UpdateHelpText(int index)
    {
        if (index >= 0 && index < Lesson_imageSet.Length)
        {
            Lesson_helpHeader.text = Lesson_GetHelpHeaderText(index);
            Lesson_helpText.text = Lesson_GetHelpText(index);
            Lesson_image.sprite = Lesson_imageSet[index].sprite;
        }
    }

    // Define your help header text here based on the index.
    private string Lesson_GetHelpHeaderText(int index)
    {
        switch (index)
        {
            case 0:
                return "Scan Cards to Begin Lesson";
            case 1:
                return "Reload for Troubleshooting";
            case 2:
                return "Access Tutorials with Help";
                
            default:
                return "";
        }
    }

    // Define your help text here based on the index.
    private string Lesson_GetHelpText(int index)
    {
        switch (index)
        {
            case 0:
                return "Point your device's camera at AR cards to reveal a button and press it. Each lesson discusses a topic and have an activity.";
            case 1:
                return "If an object isn't loading correctly or if you encounter a bug, tap the reload icon to refresh the AR experience.";
            case 2:
                return "If you need assistance or want to revisit the tutorial, tap the help button to access the tutorial from the beginning.";
            default:
                return "";
        }
    }
}
