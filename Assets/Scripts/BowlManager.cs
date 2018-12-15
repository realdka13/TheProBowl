using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlManager : MonoBehaviour
{

    public GameObject bowlingBall;

    public void ResetBall()
    {
        //Destory Bowling Ball
        Destroy(bowlingBall);

        //Respawn Bowling Ball
        bowlingBall = Instantiate(bowlingBall, new Vector3(0, .25f, 0), Quaternion.identity);
    }
}
