using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    public Transform movement;
    public Text ScoreText, CurrentScoreText;
    public void ScoreCalc()
    {
        ScoreText.text = Mathf.Abs(movement.position.z).ToString("0");
        CurrentScoreText.text = ScoreText.text;
    }
}