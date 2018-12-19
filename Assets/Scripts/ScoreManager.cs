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

    public void UpdateScore(int player, int roll, int score)
    {
        if (player == 1)
        {
            playerOneScore[roll - 1] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
        else if (player == 2)
        {
            playerTwoScore[roll - 1] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
        else if (player == 3)
        {
            playerThreeScore[roll - 1] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
        else if (player == 4)
        {
            playerFourScore[roll - 1] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
        else if (player == 5)
        {
            playerFiveScore[roll - 1] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
        else if (player == 6)
        {
            playerSixScore[roll - 1] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
        scoreBoard.GetComponent<ScoreBoards>().FillScoreBoard(player, roll, score);
    }
}
