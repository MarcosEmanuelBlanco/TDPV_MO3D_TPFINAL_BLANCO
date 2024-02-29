using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScreenController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private float score = 1000;
    private void Start()
    {
        scoreText.text = "Puntos: " + score;
    }
    private void Update()
    {
        UpdateScore();
        UpdateScoreText();
    }
    public void EnableRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMenu()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex - 2);
    }

    private void UpdateScore()
    {
        score -= Time.deltaTime;
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Puntos: " + score;
    }
}
