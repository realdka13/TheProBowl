using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class HandPointer : MonoBehaviour
{

    public Transform rightHandAnchor;
    public Transform leftHandAnchor;
    public GameObject UI;
    public LineRenderer lineRenderer = null;
    bool useLeftLaser = false;
    bool useRightLaser = true;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (useRightLaser)//Use the laser with Right Hand
        {
            Ray pointer = new Ray(rightHandAnchor.position, rightHandAnchor.forward);
            RaycastHit hit;//get the hit object of a raycast
            lineRenderer.SetPosition(0, pointer.origin);//Line render start point
            if (Physics.Raycast(pointer, out hit, 2.5f) && hit.transform.gameObject.tag == "UI") //Stop if it hits something
            {
                lineRenderer.enabled = true;
                lineRenderer.SetPosition(1, hit.point);
                //Switch Hands
                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                {
                    //Switch Laser To Left
                    useRightLaser = false;
                    useLeftLaser = true;

                    //Switch Interaction to Left
                    UI.GetComponentInChildren<OVRGazePointer>().rayTransform = leftHandAnchor;
                    UI.GetComponentInChildren<OVRInputModule>().rayTransform = leftHandAnchor;
                    UI.GetComponentInChildren<OVRInputModule>().joyPadClickButton = OVRInput.Button.PrimaryIndexTrigger;
                }
            }
            else
            {
                lineRenderer.enabled = false;
            }
        }
        if (useLeftLaser)//Use laser with left hand
        {
            Ray pointer = new Ray(leftHandAnchor.position, leftHandAnchor.forward);
            RaycastHit hit;//get the hit object of a raycast
            lineRenderer.SetPosition(0, pointer.origin);//Line render start point
            if (Physics.Raycast(pointer, out hit, 2.5f) && hit.transform.gameObject.tag == "UI") //Stop if it hits something
            {
                lineRenderer.enabled = true;
                lineRenderer.SetPosition(1, hit.point);

                //Switch Hands
                if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
                {
                    //Switch Laser to Right
                    useRightLaser = true;
                    useLeftLaser = false;

                    //Switch Interactions to right
                    UI.GetComponentInChildren<OVRGazePointer>().rayTransform = rightHandAnchor;
                    UI.GetComponentInChildren<OVRInputModule>().rayTransform = rightHandAnchor;
                    UI.GetComponentInChildren<OVRInputModule>().joyPadClickButton = OVRInput.Button.SecondaryIndexTrigger;
                }
            }
            else
            {
                lineRenderer.enabled = false;
            }
        }
    }
}