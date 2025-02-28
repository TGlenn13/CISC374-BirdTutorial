using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Text highScoreText;

    private const string HighScoreKey = "HighScore";

    void Start()
    {
        LoadHighScore();
    }

    public void CheckForHighScore(int score)
    {
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0); // Get stored high score, default 0
        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, score); // Save new high score
            PlayerPrefs.Save();
            UpdateHighScoreUI(score);
        }
    }

    private void LoadHighScore()
    {
        int savedHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);
        UpdateHighScoreUI(savedHighScore);
    }

    private void UpdateHighScoreUI(int score)
    {
        if (highScoreText != null)
            highScoreText.text = "High Score: " + score.ToString();
    }
}
