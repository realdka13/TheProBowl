using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoards : MonoBehaviour
{
    public Text[] scoreB1 = new Text[21];
    public Text[] sb1FrameTotals = new Text[10];

    public Text[] scoreB2 = new Text[21];
    public Text[] sb2FrameTotals = new Text[10];

    public Text[] scoreB3 = new Text[21];
    public Text[] sb3FrameTotals = new Text[10];

    public Text[] scoreB4 = new Text[21];
    public Text[] sb4FrameTotals = new Text[10];

    public Text[] scoreB5 = new Text[21];
    public Text[] sb5FrameTotals = new Text[10];

    public Text[] scoreB6 = new Text[21];
    public Text[] sb6FrameTotals = new Text[10];

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

    public void FillScoreBoard(int player, int roll, int score)
    {
        if (player == 1)
        {
            if (score == 10 && roll % 2 != 0)
            {
                scoreB1[roll].text = "X";
            }

            else if (score == 0)
            {
                scoreB1[roll - 1].text = "-";
            }

            else
            {
                scoreB1[roll - 1].text = score.ToString();
            }
        }
        if (player == 2)
        {
            if (score == 10 && roll % 2 != 0)
            {
                scoreB2[roll].text = "X";
            }

            else if (score == 0)
            {
                scoreB2[roll - 1].text = "-";
            }

            else
            {
                scoreB2[roll - 1].text = score.ToString();
            }
        }
        if (player == 3)
        {
            if (score == 10 && roll % 2 != 0)
            {
                scoreB3[roll].text = "X";
            }

            else if (score == 0)
            {
                scoreB3[roll - 1].text = "-";
            }

            else
            {
                scoreB3[roll - 1].text = score.ToString();
            }
        }
        if (player == 4)
        {
            if (score == 10 && roll % 2 != 0)
            {
                scoreB4[roll].text = "X";
            }

            else if (score == 0)
            {
                scoreB4[roll - 1].text = "-";
            }

            else
            {
                scoreB4[roll - 1].text = score.ToString();
            }
        }
        if (player == 5)
        {
            if (score == 10 && roll % 2 != 0)
            {
                scoreB5[roll].text = "X";
            }

            else if (score == 0)
            {
                scoreB5[roll - 1].text = "-";
            }

            else
            {
                scoreB5[roll - 1].text = score.ToString();
            }
        }
        if (player == 6)
        {
            if (score == 10 && roll % 2 != 0)
            {
                scoreB6[roll].text = "X";
            }

            else if (score == 0)
            {
                scoreB6[roll - 1].text = "-";
            }

            else
            {
                scoreB6[roll - 1].text = score.ToString();
            }
        }
    }
}
