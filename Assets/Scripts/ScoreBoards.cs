﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoards : MonoBehaviour
{
    public Text[] scoreB1 = new Text[21];
    public Text[] sb1FrameTotals = new Text[10];
    private int player1Frame = 1;

    public Text[] scoreB2 = new Text[21];
    public Text[] sb2FrameTotals = new Text[10];
    private int player2Frame = 1;

    public Text[] scoreB3 = new Text[21];
    public Text[] sb3FrameTotals = new Text[10];
    private int player3Frame = 1;

    public Text[] scoreB4 = new Text[21];
    public Text[] sb4FrameTotals = new Text[10];
    private int player4Frame = 1;

    public Text[] scoreB5 = new Text[21];
    public Text[] sb5FrameTotals = new Text[10];
    private int player5Frame = 1;

    public Text[] scoreB6 = new Text[21];
    public Text[] sb6FrameTotals = new Text[10];
    private int player6Frame = 1;

    private int lastScore;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Text scoreText in scoreB1)
        {
            scoreText.text = " ";
        }
        foreach (Text scoreText in scoreB2)
        {
            scoreText.text = " ";
        }
        foreach (Text scoreText in scoreB3)
        {
            scoreText.text = " ";
        }
        foreach (Text scoreText in scoreB4)
        {
            scoreText.text = " ";
        }
        foreach (Text scoreText in scoreB5)
        {
            scoreText.text = " ";
        }
        foreach (Text scoreText in scoreB6)
        {
            scoreText.text = " ";
        }
        foreach (Text scoreText in sb1FrameTotals)
        {
            scoreText.text = " ";
        }
        foreach (Text scoreText in sb2FrameTotals)
        {
            scoreText.text = " ";
        }
        foreach (Text scoreText in sb3FrameTotals)
        {
            scoreText.text = " ";
        }
        foreach (Text scoreText in sb4FrameTotals)
        {
            scoreText.text = " ";
        }
        foreach (Text scoreText in sb5FrameTotals)
        {
            scoreText.text = " ";
        }
        foreach (Text scoreText in sb6FrameTotals)
        {
            scoreText.text = " ";
        }
    }

    public void FillScoreBoard(int player, int roll, int score, int playersTotalScore)
    {
    }
}