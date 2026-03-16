using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Update()
    {
        UpdateScoreText();
    }

    public void AddScore()
    {
        
        Score.Instance.score++;
        Debug.Log("incrementing score, score=" + Score.Instance.score);
    }

    public void DecrementScore()
    {
        Score.Instance.score--;
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + Score.Instance.score.ToString();
    }
}
