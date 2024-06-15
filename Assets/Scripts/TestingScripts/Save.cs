using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public class Save : MonoBehaviour
{
    public Image[] images;

    public void SaveImages()
    {
        StartCoroutine(SaveImagesFromArray());
    }

    private IEnumerator SaveImagesFromArray()
    {
        foreach (Image image in images)
        {
            // Create a new Texture2D from the Image's sprite.
            Sprite sprite = image.sprite;
            Texture2D texture = sprite.texture;

            // Get the name of the Image object and use it as the filename.
            string imageName = image.name + ".png";

            // Save the image using NativeGallery with the custom filename.
            NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(texture, "Pics", imageName);

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
    }
}
