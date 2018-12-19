using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Recenter Player on Start
        Recenter();
    }

    // Update is called once per frame
    void Update()
    {
        //Recenter Pplayer if player asks (both joystck buttons)
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick) && OVRInput.Get(OVRInput.Button.SecondaryThumbstick))
        {
            Recenter();
        }
    }

    private static void Recenter()
    {
        UnityEngine.XR.InputTracking.Recenter();
    }

}
