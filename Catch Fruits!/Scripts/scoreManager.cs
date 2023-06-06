using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    private void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void UpdateScore()
    {
        score++;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}