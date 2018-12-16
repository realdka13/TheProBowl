using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{

    float threshhold = 10f;
    bool pinInPlay = true;

    //Check if Pins Are Standing
    public bool IsStanding()
    {
        float eulerX = Mathf.Abs(transform.localEulerAngles.x);
        float eulerY = Mathf.Abs(transform.localEulerAngles.y);

        if ((eulerX < threshhold || eulerX > (360 - threshhold)) && (eulerY < threshhold || eulerY > (360 - threshhold)) && pinInPlay == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //If pin leaves trigger then set pinInPlay to false
    public void PinLeftPlay()
    {
        pinInPlay = false;
    }
    public void PinEnteredPlay()
    {
        pinInPlay = true;
    }
}
