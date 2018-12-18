using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlManager : MonoBehaviour
{
    public GameObject cleanupManager;

    public GameObject pinSensor;
    public GameObject bowlingBall;

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

    //Reset Ball if it goes out of bounds
    public void BallOutOfBounds()
    {
        ResetBall();
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

}
