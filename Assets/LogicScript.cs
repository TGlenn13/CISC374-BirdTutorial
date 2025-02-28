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
    public AudioSource pointSound;

    void Start()
    {
        //Checks if BG music is null because null music caused game to crash
        if (backgroundMusic != null)
        {
            backgroundMusic.loop = true;
            backgroundMusic.Play();
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        pointSound.Play();
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Restarts the game to a fresh game
         //Checks if BG music is null because null music caused game to crash
        if (backgroundMusic != null)
        {
            backgroundMusic.Stop();
        }
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
        Object.FindAnyObjectByType<HighScore>().CheckForHighScore(playerScore); //Highscore updated
         //Checks if BG music is null because null music caused game to crash
        if (backgroundMusic != null)
        {
            backgroundMusic.Play();
        }
    }

}
