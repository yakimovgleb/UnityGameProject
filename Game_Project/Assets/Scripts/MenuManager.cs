using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI recordText;

    void Start()
    {
        int record = PlayerPrefs.GetInt("Record", 0);
        recordText.text = "Record: " + record;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameLoop"); // Replace with your game scene name
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit(); // Works in build
    }
}
