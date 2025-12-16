using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Start()
    {
        // Ensure panel is hidden at start
        gameOverPanel.SetActive(false);
        Time.timeScale = 1; // normal speed
    }

    public void GameOver()
    {
        // Show Game Over UI
        gameOverPanel.SetActive(true);
        Time.timeScale = 0; // pause game
        ScoreManager.SaveHighScore();
    }

    public void RestartGame()
    {
        Time.timeScale = 1; // resume game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
