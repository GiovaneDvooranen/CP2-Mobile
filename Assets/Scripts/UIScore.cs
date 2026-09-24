using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Score: " + ScoreManager.Instance.GetScore();
    }
}