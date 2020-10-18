using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool hasGameEnded = false;
    public GameObject gameEndUI;
    public Text CurrentScoreText;
    public PlayerMovement movement;
    public void GameEnd()
    {
//        CurrentScoreText.text = scoreText.text;
        gameEndUI.SetActive(true);
        Invoke(nameof(Restart), 3f);
    }
    public void EndGame()
    {
        if (!hasGameEnded)
        {   
            hasGameEnded = true;
            movement.enabled = false;
            Debug.Log("GAME OVER!!!!!!!\n YOU SUCK");
//            FindObjectOfType<ScoreCalculator>().enabled = false;
            GameEnd();
        }
    }
    void Update()
    {
        if (Input.GetKey("r"))
            Restart();
    }
    void Restart()
    {
//        FindObjectOfType<ScoreCalculator>().enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
