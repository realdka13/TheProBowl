using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GutterBall : MonoBehaviour
{

    public GameObject bowlingBall;

    //Destroy Bowling Ball if it hits trigger
    private void OnTriggerEnter(Collider trigObject)
    {
        if (trigObject.tag == "BowlingBall")
        {
            Destroy(bowlingBall);
        }

        //Respawn Bowling Ball
        bowlingBall = Instantiate(bowlingBall, new Vector3(0, 0, 0), Quaternion.identity);

    }
}
