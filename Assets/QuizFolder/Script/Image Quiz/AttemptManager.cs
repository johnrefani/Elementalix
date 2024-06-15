using UnityEngine;
using UnityEngine.SceneManagement;

public class AttemptManager : MonoBehaviour
{
    public int attemptCount; // Track the number of attempts
    

    void Start()
    {
        
        // Load the attempt count from PlayerPrefs when the script starts
        attemptCount = PlayerPrefs.GetInt("Attempts_" + SceneManager.GetActiveScene().name, 0);

        // Increment the attempt count every time the user starts the program
        attemptCount++;

        PlayerPrefs.SetInt("Attempts_" + SceneManager.GetActiveScene().name, attemptCount);
        PlayerPrefs.Save();
    }

    public void Retry()
    {

        attemptCount++;

        // Save the attempt count to PlayerPrefs
        PlayerPrefs.SetInt("Attempts_" + SceneManager.GetActiveScene().name, attemptCount);
        PlayerPrefs.Save();
    }
}
