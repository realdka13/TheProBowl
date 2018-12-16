using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPinTrigger : MonoBehaviour
{
    public GameObject bowlManager;

    //When Ball Triggers the Trigger, destroy and respawn Ball or the Pins as well
    private void OnTriggerEnter(Collider trigObject)
    {
        if (trigObject.tag == "BowlingBall")
        {
            bowlManager.GetComponent<BowlManager>().BallFound();
        }

        if (trigObject.tag == "Pin")
        {
            Destroy(trigObject.gameObject);
        }
    }
}
