using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCounter : MonoBehaviour
{
    public GameObject bowlManager;

    private float lastChangeTime;
    private bool ballFound = false;
    private int finalStandingCount = -1;

    private void Update()
    {
        if (ballFound == true)
        {
            CheckStandingPins();
        }
    }

    //Checks if the Pin count has changed
    private void CheckStandingPins()
    {
        int currentStanding = TrackStandingPins();

        if (currentStanding != finalStandingCount)
        {
            lastChangeTime = Time.time;
            finalStandingCount = currentStanding;
            return;
        }

        float settleTime = 3f; //The time to wait to consider pins settled
        if ((Time.time - lastChangeTime) > settleTime) //if last change was more than 3s ago
        {
            PinsSettled();
        }
    }

    //Called win pins finally settle
    private void PinsSettled()
    {
        print("Pins have settled, final count is: " + finalStandingCount);
        finalStandingCount = -1; //Reseting for next fram
        ballFound = false; //Resetting for next frame
        bowlManager.GetComponent<BowlManager>().RollComplete();
    }

    //Count the Standing Pins
    public int TrackStandingPins()
    {

        int standingPins = 0;
        foreach (Pin pin in GameObject.FindObjectsOfType<Pin>())
        {
            if (pin.IsStanding())
            {
                standingPins++;
            }
        }
        return standingPins;
    }

    //Tells pin if it left the collider
    private void OnTriggerExit(Collider trigObject)
    {
        if (trigObject.tag == "Pin")
        {
            trigObject.GetComponent<Pin>().PinLeftPlay();
        }
    }

    //Sets Pin if its always in play
    private void OnTriggerStay(Collider trigObject)
    {
        if (trigObject.tag == "Pin")
        {
            trigObject.GetComponent<Pin>().PinEnteredPlay();
        }
    }

    public void BallFound()
    {
        ballFound = true;
    }

}
