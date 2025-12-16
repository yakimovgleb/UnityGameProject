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
}
