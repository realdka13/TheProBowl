using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrownSensor : MonoBehaviour
{

    public GameObject bowlManager;

    private void OnTriggerEnter(Collider trigObject)
    {
        if (trigObject.tag == "BowlingBall")
        {
            bowlManager.GetComponent<BowlManager>().BallThrown();
        }
    }
}
