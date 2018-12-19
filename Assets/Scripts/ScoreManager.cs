using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject bowlManager;

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
            playerOneScore[roll] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
        if (player == 2)
        {
            playerTwoScore[roll] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
        if (player == 3)
        {
            playerThreeScore[roll] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
        if (player == 4)
        {
            playerFourScore[roll] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
        if (player == 5)
        {
            playerFiveScore[roll] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
        if (player == 6)
        {
            playerSixScore[roll] = score;
            print("Player " + player + " Roll " + roll + " with a score of " + score);
        }
    }
}
