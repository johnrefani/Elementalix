using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    /*public int score; 

    void Start()
    {
        // Reset the score to 0 every time the game starts
        score = 0;

        // Save the score to PlayerPrefs
        PlayerPrefs.SetInt("Highscore_" + SceneManager.GetActiveScene().name, score);
        PlayerPrefs.Save();
    }*/

    public int score;

    void Start()
    {
        // Reset score to zero at the start
        score = 0;
    }

    public void CorrectAnswer()
    {
        // Increase score by 1 for correct answer
        score += 2;
    }

    public void WrongAnswer()
    {
        // No points deducted for wrong answer
    }

    public void SaveScore()
    {
        // Save the score to PlayerPrefs
        PlayerPrefs.SetInt("Highscore_" + SceneManager.GetActiveScene().name, score);

        Debug.Log("Score saved: " +  score);
    }

    public void ResetScore()
    {
        // Reset score to zero
        score = 0;
    }
}
