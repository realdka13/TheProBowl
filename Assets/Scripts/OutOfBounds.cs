using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    public GameObject bowlingBall;
    public GameObject bowlManager;

    //Destroy Bowling Ball if it hits trigger
    private void OnTriggerEnter(Collider trigObject)
    {
        if (trigObject.tag == "BowlingBall")
        {
            bowlManager.GetComponent<BowlManager>().BallOutOfBounds();
        }
    }
}
