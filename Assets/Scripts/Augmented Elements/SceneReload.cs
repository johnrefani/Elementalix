using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReload : MonoBehaviour
{
    // Add this function to a button click event or any other trigger to reload the scene
    public void ReloadScene()
    {
        // Get the index of the current scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the current scene again by its index
        SceneManager.LoadScene(currentSceneIndex);
    }
}
