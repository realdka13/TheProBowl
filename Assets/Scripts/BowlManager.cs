using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlManager : MonoBehaviour
{
    public GameObject cleanupManager;

    public GameObject pinSensor;
    public GameObject bowlingBall;
    public GameObject UI;

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
        ballThrown = false;
        UI.GetComponent<UIManager>().ResetMaxVel();
    }

    //If ball is found, tell PinCounter that its been found
    public void BallFound()
    {
        pinSensor.GetComponent<PinCounter>().BallFound();
    }

    //Roll is complete
    public void RollComplete()
    {
        ResetBall();
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
            return bowlingBall.GetComponent<Rigidbody>().velocity.magnitude;
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
}
