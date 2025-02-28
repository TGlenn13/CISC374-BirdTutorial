using UnityEngine;

public class Title : MonoBehaviour
{
    public GameObject titleScreen; // Assign in the Inspector
    private static bool gameStarted = false; // Static variable keeps state across scene reloads

    void Start()
    {
        if (!gameStarted) // Show title screen only if the game hasn't started
        {
            titleScreen.SetActive(true);
            Time.timeScale = 0; // Pause the game
        }
        else
        {
            titleScreen.SetActive(false);
            Time.timeScale = 1; // Resume the game
        }
    }

    public void StartGame()
    {
        titleScreen.SetActive(false);
        Time.timeScale = 1;
        gameStarted = true; // Prevent the title screen from appearing again
    }
}
