using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlManager : MonoBehaviour
{
    public GameObject cleanupManager;
    public GameObject pinSensor;
    public GameObject bowlingBall;
    public GameObject UI;
    public GameObject scoreManager;

    private int playerCount;
    private int currentPlayer = 1;
    private int maxRolls = 21;
    private int currentRoll = 1;

    private int leftStanding = 10;
    private int lastScore;

    private bool ballThrown;

    private void ResetBall()
    {
        //Destory Bowling Ball
        if (GameObject.FindGameObjectWithTag("BowlingBall"))
        {
            Destroy(bowlingBall);
        }

        //Respawn Bowling Ball
        bowlingBall = Instantiate(bowlingBall, new Vector3(0, .25f, -.1f), Quaternion.identity);
    }

    //If ball is found, tell PinCounter that its been found
    public void BallFound()
    {
        pinSensor.GetComponent<PinCounter>().BallFound();
        ballThrown = false;
        UI.GetComponent<UIManager>().ResetMaxVel();
    }

    //Roll is complete
    public void RollComplete(int standingPins)
    {
        //Score Calculations
        int score = 0;  //What is score?
        if (currentRoll % 2 == 1)
        {
            score = 10 - standingPins;
            leftStanding = standingPins;
            lastScore = score;
        }
        else if (currentRoll % 2 == 0)
        {
            score = leftStanding - standingPins;
        }

        //Check for a strike
        if (currentRoll % 2 == 1 && score == 10)
        {
            print("STRIKE!");
            currentRoll++;
            ResetBall();
        }

        //Player Change every other roll
        if ((currentPlayer < playerCount) && (currentRoll % 2) == 0)
        {
            currentPlayer++;
            currentRoll -= 1;
            ResetPins();
            UI.GetComponent<UIManager>().UpdatePlayerTurn(currentPlayer);
            leftStanding = 10;
            lastScore = 0;
        }
        else if (currentPlayer == playerCount && (currentRoll % 2) == 0)
        {
            currentPlayer = 1;
            ResetPins();
            UI.GetComponent<UIManager>().UpdatePlayerTurn(currentPlayer);
            currentRoll++;
        }
        //Tidy
        else
        {
            TidyPins();
            currentRoll++;
        }
        ResetBall();
        scoreManager.GetComponent<ScoreManager>().UpdateScore(currentPlayer,currentRoll, score);
    }

    public void ResetPins()
    {
        cleanupManager.GetComponent<Animator>().SetTrigger("resetTrigger");
    }

    public void TidyPins()
    {
        cleanupManager.GetComponent<Animator>().SetTrigger("tidyTrigger");
    }

    public void StartGame()
    {
        UI.GetComponent<UIManager>().UpdatePlayerTurn(currentPlayer);
        ResetBall();
    }

    //Reset Ball if it goes out of bounds
    public void BallOutOfBounds()
    {
        ResetBall();
    }

    //Get Bowling Ball Reference
    public float GetBallVelocity()
    {
        if (bowlingBall != null && ballThrown == true)
        {
            float ballX = bowlingBall.GetComponent<Rigidbody>().velocity.x;
            float ballZ = bowlingBall.GetComponent<Rigidbody>().velocity.z;
            float ballVel = Mathf.Sqrt(Mathf.Pow(ballX, 2) + Mathf.Pow(ballZ, 2));
            return ballVel;
        }
        else
        {
            return 0;
        }
    }

    public void BallThrown()
    {
        ballThrown = true;
    }

    public void SetPlayerCount(int playersPlaying)
    {
        playerCount = playersPlaying;
    }

}
