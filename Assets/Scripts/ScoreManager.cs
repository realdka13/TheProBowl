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

    private int lastScore = -1;

    //player 1 status
    private bool spareScoredLastRollOne = false;
    private bool strikeScoredLastRollOne = false;
    private bool strikeScored2RollsAgoOne = false;
    private int rollType = -1;

    public void UpdateScore(int player, int roll, int score)
    {
        if (player == 1)
        {
            //Check for any extra points
            if (spareScoredLastRollOne)
            {
                player1TotalScore += score;
                spareScoredLastRollOne = false;
                scoreBoard.GetComponent<ScoreBoards>().UpdatePreviousFrame(player, player1TotalScore, 1);
            }
            if (strikeScored2RollsAgoOne)
            {
                strikeScored2RollsAgoOne = false;
                player1TotalScore += score;
                scoreBoard.GetComponent<ScoreBoards>().UpdatePreviousFrame(player, player1TotalScore - lastScore, 2);
            }
            if (strikeScoredLastRollOne)
            {
                strikeScored2RollsAgoOne = true;
                strikeScoredLastRollOne = false;
                player1TotalScore += score;
            }


            //If Strike
            if (roll % 2 == 1 && score == 10)
            {
                print("Strike Scored");
                player1TotalScore += 10;

                //Plus next two rolls
                strikeScoredLastRollOne = true;

                //Set Score Type
                rollType = 2;//Strike
            }
            //If Spare
            else if ((roll % 2 == 0) && score + lastScore == 10)
            {
                print("Spare Scored");
                lastScore = 0;
                player1TotalScore += score;

                //plus next roll
                spareScoredLastRollOne = true;

                //Set score Type
                rollType = 1;//Spare
            }

            //If Normal
            else
            {
                print("Score as normal");
                lastScore = score;
                player1TotalScore += score;
                rollType = 0;
            }
            print("Final total = " + player1TotalScore);
            scoreBoard.GetComponent<ScoreBoards>().FillScoreBoard(player,roll,score, player1TotalScore,rollType);
            rollType = -1;
        }
    }
}
