using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This class loads the next scene when the current score reaches the correct amount.
/// </summary>
public class SceneController : MonoBehaviour
{
    [SerializeField] private int scoreToMoveOn;
    private int nextScene;
    private void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Score.Instance.score == scoreToMoveOn)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
