using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject bowlManager;
    public GameObject scoreBoard;

    private int[] playerOneScore = new int[21];
    private int[] playerTwoScore = new int[21];
    private int[] playerThreeScore = new int[21];
    private int[] playerFourScore = new int[21];
    private int[] playerFiveScore = new int[21];
    private int[] playerSixScore = new int[21];

    private int player1TotalScore = 0;
    private int player2TotalScore = 0;
    private int player3TotalScore = 0;
    private int player4TotalScore = 0;
    private int player5TotalScore = 0;
    private int player6TotalScore = 0;

    private int lastScore;

    private bool spareScoredLastRoll = false;
    private bool strikeScoredLastRoll = false;
    private bool strikeScored2RollsAgo = false;

    public void UpdateScore(int player, int roll, int score)
    {
        if (player == 1)
        {
            //Check for any extra points
            if (spareScoredLastRoll)
            {
                player1TotalScore += score;
                spareScoredLastRoll = false;
            }
            if (strikeScoredLastRoll)
            {
                strikeScored2RollsAgo = true;
                strikeScoredLastRoll = false;
                player1TotalScore += score;
                print("strike roll 1 new total = " + player1TotalScore);
            }
            if (strikeScored2RollsAgo)
            {
                strikeScoredLastRoll = false;
                player1TotalScore += score;
                print("strike roll 2 new total = " + player1TotalScore);
            }


            //If Strike
            if (roll % 2 == 0 && score == 10)
            {
                print("Strike Scored");
                player1TotalScore += 10;

                //Plus next two rolls
                strikeScoredLastRoll = true;
            }

            //If Spare
            else if ((roll % 2 == 1) && score + lastScore == 10)
            {
                print("Spare Scored");
                lastScore = 0;
                player1TotalScore += score;

                //plus next roll
                spareScoredLastRoll = true;
            }

            //If Normal
            else
            {
                print("Score as normal");
                lastScore = score;
                player1TotalScore += score;
                print("Score as normal new total = " + player1TotalScore);
            }
        }
    }
}
