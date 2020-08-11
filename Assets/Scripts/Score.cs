using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    int highScore;
    public Text panelScoreText, panelHighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString();
        panelScoreText.text = score.ToString();
        panelHighScoreText.text = highScore.ToString();

        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highscore", highScore);
        }
    }
}
