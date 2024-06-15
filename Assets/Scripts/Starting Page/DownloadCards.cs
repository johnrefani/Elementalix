using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;
using TMPro;

public class DownloadCards : MonoBehaviour
{
    public Image[] images;
    public GameObject notificationPanel;
    public Button downloadButton;
    public GameObject proceedButton;
    public TMP_Text SavedNotificationHead;
    public TMP_Text SavedNotificationText;

    void Start()
    {
        CloseNotificationPanel();
    }
    public void SaveImages()
    {
        proceedButton.SetActive(false);
        StartCoroutine(SaveImagesFromArray());
        notificationPanel.SetActive(true);
        downloadButton.enabled = false;
        


    }


    private IEnumerator SaveImagesFromArray()
    {
        SavedNotificationHead.text = "Cards are being saved to gallery!";
        SavedNotificationText.text = "Don't worry! Your download will still finish. \r\nThis is just a humble request.";

        foreach (Image image in images)
        {
            // Create a new Texture2D from the Image's sprite.
            Sprite sprite = image.sprite;
            Texture2D texture = sprite.texture;

            // Get the name of the Image object and use it as the filename.
            string imageName = image.name + ".png";

            // Save the image using NativeGallery with the custom filename.
            NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(texture, "Elementalix", imageName);

            // Handle the result.
            if (permission == NativeGallery.Permission.Granted)
            {
                Debug.Log($"Image '{imageName}' saved to gallery.");
            }
            else if (permission == NativeGallery.Permission.ShouldAsk)
            {
                Debug.Log($"Permission to save image '{imageName}' to gallery was requested.");
            }
            else
            {
                Debug.Log($"Permission denied to save image '{imageName}' to gallery.");
            }

            // Wait for the end of the frame before processing the next image.
            yield return new WaitForEndOfFrame();
        }

        // All images are saved, update the notification text.
        SavedNotificationHead.text = "All images are saved to the gallery.";
        SavedNotificationText.text = "You are all set, you can view all of the cards in the Elementalix gallery folder.";
        proceedButton.SetActive(true);

        // Wait for a moment (you can adjust the time as needed).
        //yield return new WaitForSeconds(3f);

        // Close the notification panel after a brief delay.
        //CloseNotificationPanel();
    }

    public void CloseNotificationPanel()
    {
        notificationPanel.SetActive(false);
        downloadButton.enabled = true;
    }
}
