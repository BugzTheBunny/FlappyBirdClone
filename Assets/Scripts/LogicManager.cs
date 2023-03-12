using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    [SerializeField] Text score;

    [SerializeField] GameObject gameOverScreen;
    public bool isGameOver;

    [ContextMenu("Add score")]
    public void addScore(int scoreToAdd){
        playerScore += scoreToAdd;
        score.text = string.Format("Score: {0}",playerScore);
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(false);
        isGameOver = false;
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
        isGameOver = true;
    }
}
