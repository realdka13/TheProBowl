using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPinTrigger : MonoBehaviour
{
    public GameObject bowlManager;

    //When Ball Triggers the Trigger, destroy and respawn Ball
    private void OnTriggerEnter(Collider trigObject)
    {
        if (trigObject.tag == "BowlingBall")
        {
            bowlManager.GetComponent<BowlManager>().ResetBall();
        }
    }
}
