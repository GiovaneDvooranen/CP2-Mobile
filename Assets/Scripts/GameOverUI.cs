using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public GameObject panel;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;

    public void ShowGameOver(
        int score,
        float survivalTime)
    {
        panel.SetActive(true);

        scoreText.text = "Score Final: " + score;

        timeText.text = "Sobreviveu por: " + Mathf.FloorToInt(survivalTime) + " segundos";

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}