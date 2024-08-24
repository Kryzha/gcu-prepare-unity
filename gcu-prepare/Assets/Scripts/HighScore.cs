using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text currentScoreText;
    public Text highScoreText;
    public int highScore;
    public int currentScore;

    public void RollDice()
    {
        currentScore = Random.Range(0,12);
        highScore = currentScore;
        if(currentScore > highScore)
        {
            highScore = currentScore;
            highScoreText.text = highScore.ToString("0");
        }
    }

    public void Reset()
    {
        currentScoreText.text = "0";
        highScoreText.text = "XX";
    }
}
