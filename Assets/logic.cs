using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increment Score")]
    public void IncrementScore(int scoreToAdd = 1)
    {
        score = score + scoreToAdd;
        scoreText.text = score.ToString();
    }

    public void ResetScore()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
