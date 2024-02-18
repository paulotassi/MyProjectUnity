using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;
    void Start()
    {
        score = 0;
        scoreText.text = "Bounces: " + score;
    }
    public void UpdateScore()
    {
        score ++;
        scoreText.text = "Bounces: " + (score / 2);
    }
}
