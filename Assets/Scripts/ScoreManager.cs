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

    public void UpdateScore(int player, int roll, int score)
    {
        if (player == 1)
        {
            playerOneScore[roll - 1] = score;
            player1TotalScore += score;
            scoreBoard.GetComponent<ScoreBoards>().FillScoreBoard(player, roll, score, player1TotalScore);
        }
        else if (player == 2)
        {
            playerTwoScore[roll - 1] = score;
            player2TotalScore += score;
            scoreBoard.GetComponent<ScoreBoards>().FillScoreBoard(player, roll, score, player2TotalScore);
        }
        else if (player == 3)
        {
            playerThreeScore[roll - 1] = score;
            player3TotalScore += score;
            scoreBoard.GetComponent<ScoreBoards>().FillScoreBoard(player, roll, score, player3TotalScore);
        }
        else if (player == 4)
        {
            playerFourScore[roll - 1] = score;
            player4TotalScore += score;
            scoreBoard.GetComponent<ScoreBoards>().FillScoreBoard(player, roll, score, player4TotalScore);
        }
        else if (player == 5)
        {
            playerFiveScore[roll - 1] = score;
            player5TotalScore += score;
            scoreBoard.GetComponent<ScoreBoards>().FillScoreBoard(player, roll, score, player5TotalScore);
        }
        else if (player == 6)
        {
            playerSixScore[roll - 1] = score;
            player6TotalScore += score;
            scoreBoard.GetComponent<ScoreBoards>().FillScoreBoard(player, roll, score, player6TotalScore);
        }
    }
}
