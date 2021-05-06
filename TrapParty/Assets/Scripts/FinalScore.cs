﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class FinalScore : MonoBehaviour
{
    private ScoreText scoreText;
    //private PlayerDeaths playerDeaths;
    private int p1Ds;
    private int p2Ds;

    private bool p1Wins = false;
    private bool p2Wins = false;
    private bool draw = false;

    private TextMeshProUGUI finalScores;
    
    // Start is called before the first frame update
    void Start()
    {
        finalScores = GameObject.Find("FinalScoreText").GetComponent<TextMeshProUGUI>();
        //playerDeaths = GameObject.Find("PlayerDeaths").GetComponent<PlayerDeaths>();
        scoreText = GameObject.Find("ScoreText").GetComponent<ScoreText>();
        p1Ds = PlayerPrefs.GetInt("PlayerOneDeaths");
        p2Ds = PlayerPrefs.GetInt("playerTwoDeaths");
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (scoreText.P1 > scoreText.P2)
        {
            Debug.Log("Checking if P1Score greater than P2Score");
            finalScores.text = $"Player 1 Wins";
        }
        if (scoreText.P1 < scoreText.P2)
        {
            Debug.Log("Checking if P2Score greater than P1Score");
            finalScores.text = $"Player 2 Wins";
        }

        if (scoreText.P1 == scoreText.P2){
            Debug.Log("Both Scores are equal");
            if (p1Ds > p2Ds)
            {
                Debug.Log("Player One has more deaths");
                string deaths = $"{p1Ds} - {p2Ds}";
                Debug.Log(deaths);
                finalScores.text = $"Player 2 Wins";
            }
            if (p1Ds < p2Ds)
            {
                Debug.Log("Player 2 has more deaths");
                string deaths = $"{p1Ds} - {p2Ds}";
                Debug.Log(deaths);
                finalScores.text = $"Player 1 Wins";
            }
            if (p1Ds == p2Ds)
            {
                Debug.Log("Both players have equal deaths");
                string deaths = $"{p1Ds} - {p2Ds}";
                Debug.Log(deaths);
                finalScores.text = $"No One Wins - Play Again";
            }
        }
    }
}
