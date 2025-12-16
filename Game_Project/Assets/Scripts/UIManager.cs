using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;

    private float elapsedTime = 0f;

    void Update()
    {
        // Update time
        elapsedTime += Time.deltaTime;
        timeText.text = "Time: " + elapsedTime.ToString("F1") + "s";

        // Update score
        scoreText.text = "Score: " + ScoreManager.score;
    }
}
