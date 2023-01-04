using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverCanavas;

    public Text pointsText;

    [SerializeField]
    private TextMeshProUGUI scoreText;
    public void StopGame(int score)
    {
        gameOverCanavas.SetActive(true);
        scoreText.text = score.ToString();
        pointsText.text = score.ToString() + " POINTS";
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameMenu(string sceneMenu)
    {
        SceneManager.LoadScene(sceneMenu);
    }


}
