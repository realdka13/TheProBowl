using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVelocity : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Rigidbody>().maxAngularVelocity = 100;
    }
}
