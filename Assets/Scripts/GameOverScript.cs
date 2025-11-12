using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] PlayerData data;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highScoreText;

    private void Start()
    {
        highScoreText.text = data.highScore.ToString();
        scoreText.text = data.score.ToString();
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene("Game");
    }
}
