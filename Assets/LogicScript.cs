using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource backgroundMusic;

    void Start()
    {
        if (backgroundMusic != null)
        {
            backgroundMusic.loop = true;
            backgroundMusic.Play();
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (backgroundMusic != null)
        {
            backgroundMusic.Stop();
        }
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
        Object.FindAnyObjectByType<HighScore>().CheckForHighScore(playerScore);
        if (backgroundMusic != null)
        {
            backgroundMusic.Play();
        }
    }

}
