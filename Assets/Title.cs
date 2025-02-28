using UnityEngine;

public class Title : MonoBehaviour
{
    public GameObject titleScreen; // Assign in the Inspector

    void Start()
    {
        if (!PlayerPrefs.HasKey("GameStarted")) // Check if the game is starting for the first time
        {
            titleScreen.SetActive(true);
            Time.timeScale = 0; // Pause the game
        }
        else
        {
            titleScreen.SetActive(false);
            Time.timeScale = 1; // Resume game if restarting
        }
    }

    public void StartGame(){
        titleScreen.SetActive(false);
        Time.timeScale = 1;
        PlayerPrefs.SetInt("GameStarted", 1); // Mark the game as started
        PlayerPrefs.Save();
    }

    public void ResetGame(){
        PlayerPrefs.DeleteKey("GameStarted"); // Reset the title screen flag
    }
}
