using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    void Start()
    {
        score = 0;
    }

    public static void AddScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }

    public static void SaveHighScore()
    {
        int highScore = PlayerPrefs.GetInt("Record", 0);
        if (score > highScore)
        {
            PlayerPrefs.SetInt("Record", score);
            PlayerPrefs.Save();
        }
    }
}
