using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HandPointer : MonoBehaviour
{

    public Transform rightHandAnchor;
    public Transform leftHandAnchor;
    public LineRenderer lineRenderer = null;
    bool useLeftLaser = false;
    bool useRightLaser = true;

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstick))
        {
            useRightLaser = true;
            useLeftLaser = false;
        }

        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
            useRightLaser = false;
            useLeftLaser = true;
        }

        if (useRightLaser)//Use the laser with Right Hand
        {
            Ray pointer = new Ray(rightHandAnchor.position, rightHandAnchor.forward);
            RaycastHit hit;//get the hit object of a raycast
            lineRenderer.SetPosition(0, pointer.origin);//Line render start point
            if (Physics.Raycast(pointer, out hit, 500f)) //Stop if it hits something
            {
                lineRenderer.SetPosition(1, hit.point);
            }
            else //Draw line 500 units if nothing is hit
            {
                lineRenderer.SetPosition(1, pointer.origin + pointer.direction * 500f);
            }
        }
        if (useLeftLaser)//Use laser with left hand
        {
            Ray pointer = new Ray(leftHandAnchor.position, leftHandAnchor.forward);
            RaycastHit hit;//get the hit object of a raycast
            lineRenderer.SetPosition(0, pointer.origin);//Line render start point
            if (Physics.Raycast(pointer, out hit, 500f)) //Stop if it hits something
            {
                lineRenderer.SetPosition(1, hit.point);
            }
            else //Draw line 500 units if nothing is hit
            {
                lineRenderer.SetPosition(1, pointer.origin + pointer.direction * 500f);
            }
        }
    }
}