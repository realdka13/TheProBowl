using System.Collections;
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
        if (player == 1)
        {
            if (score == 10 && roll % 2 != 0) //If Strike
            {
                scoreB1[roll].text = "X";
                player1Frame++;
            }

            else if (score == 0)    //If Zero
            {
                scoreB1[roll - 1].text = "-";
                lastScore = score;
            }

            else
            {
                if (roll % 2 == 1)
                {
                    lastScore = score;
                }
                scoreB1[roll - 1].text = score.ToString(); //All Else(just fill in the number)
            }
            if (roll % 2 == 0)
            {
                if ((score + lastScore) == 10)//check for spare
                {
                    scoreB1[roll - 1].text = "/";
                }
                else
                {
                    sb1FrameTotals[player1Frame - 1].text = playersTotalScore.ToString(); // Update frame after every other roll
                }
                player1Frame++;
            }
        }
        if (player == 2)
        {
            if (score == 10 && roll % 2 != 0)
            {
                scoreB2[roll].text = "X";
                player2Frame++;
            }

            else if (score == 0)
            {
                scoreB2[roll - 1].text = "-";
                lastScore = score;
            }

            else
            {
                if (roll % 2 == 1)
                {
                    lastScore = score;
                }
                scoreB2[roll - 1].text = score.ToString();
            }
            if (roll % 2 == 0)
            {
                if ((score + lastScore) == 10)//check for spare
                {
                    scoreB2[roll - 1].text = "/";
                }
                else
                {
                    sb2FrameTotals[player2Frame - 1].text = playersTotalScore.ToString(); // Update frame after every other roll
                }
                player2Frame++;
            }
        }
        if (player == 3)
        {
            if (score == 10 && roll % 2 != 0)
            {
                scoreB3[roll].text = "X";
                player3Frame++;
            }

            else if (score == 0)
            {
                scoreB3[roll - 1].text = "-";
                lastScore = score;
            }

            else
            {
                if (roll % 2 == 1)
                {
                    lastScore = score;
                }
                scoreB3[roll - 1].text = score.ToString();
            }
            if (roll % 2 == 0)
            {
                if ((score + lastScore) == 10)//check for spare
                {
                    scoreB3[roll - 1].text = "/";
                }
                else
                {
                    sb3FrameTotals[player3Frame - 1].text = playersTotalScore.ToString(); // Update frame after every other roll
                }
                player3Frame++;
            }
        }
        if (player == 4)
        {
            if (score == 10 && roll % 2 != 0)
            {
                scoreB4[roll].text = "X";
                player4Frame++;
            }

            else if (score == 0)
            {
                scoreB4[roll - 1].text = "-";
                lastScore = score;
            }

            else
            {
                if (roll % 2 == 1)
                {
                    lastScore = score;
                }
                scoreB4[roll - 1].text = score.ToString();
            }
            if (roll % 2 == 0)
            {
                if ((score + lastScore) == 10)//check for spare
                {
                    scoreB4[roll - 1].text = "/";
                }
                else
                {
                    sb4FrameTotals[player4Frame - 1].text = playersTotalScore.ToString(); // Update frame after every other roll
                }
                player4Frame++;
            }
        }
        if (player == 5)
        {
            if (score == 10 && roll % 2 != 0)
            {
                scoreB5[roll].text = "X";
                player5Frame++;
            }

            else if (score == 0)
            {
                scoreB5[roll - 1].text = "-";
                lastScore = score;
            }

            else
            {
                if (roll % 2 == 1)
                {
                    lastScore = score;
                }
                scoreB5[roll - 1].text = score.ToString();
            }
            if (roll % 2 == 0)
            {
                if ((score + lastScore) == 10)//check for spare
                {
                    scoreB5[roll - 1].text = "/";
                }
                else
                {
                    sb5FrameTotals[player5Frame - 1].text = playersTotalScore.ToString(); // Update frame after every other roll
                }
                player5Frame++;
            }
        }
        if (player == 6)
        {
            if (score == 10 && roll % 2 != 0)
            {
                scoreB6[roll].text = "X";
                player6Frame++;
            }

            else if (score == 0)
            {
                scoreB6[roll - 1].text = "-";
                lastScore = score;
            }

            else
            {
                if (roll % 2 == 1)
                {
                    lastScore = score;
                }
                scoreB6[roll - 1].text = score.ToString();
            }
            if (roll % 2 == 0)
            {
                if ((score + lastScore) == 10)//check for spare
                {
                    scoreB6[roll - 1].text = "/";
                }
                else
                {
                    sb6FrameTotals[player6Frame - 1].text = playersTotalScore.ToString(); // Update frame after every other roll
                }
                player6Frame++;
            }
        }
    }
    public void UpdatePreviousFrame(int player, int totalScore, int lastRoll)
    {
        if (player == 1)
        {
            sb1FrameTotals[player1Frame - 2].text = (totalScore - lastRoll).ToString();
        }
        if (player == 2)
        {
            sb2FrameTotals[player2Frame - 2].text = (totalScore - lastRoll).ToString();
        }
        if (player == 3)
        {
            sb3FrameTotals[player3Frame - 2].text = (totalScore - lastRoll).ToString();
        }
        if (player == 4)
        {
            sb4FrameTotals[player4Frame - 2].text = (totalScore - lastRoll).ToString();
        }
        if (player == 5)
        {
            sb5FrameTotals[player5Frame - 2].text = (totalScore - lastRoll).ToString();
        }
        if (player == 6)
        {
            sb6FrameTotals[player6Frame - 2].text = (totalScore - lastRoll).ToString();
        }
    }
}
