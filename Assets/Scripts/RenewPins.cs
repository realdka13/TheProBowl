using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenewPins : MonoBehaviour
{
    public GameObject pinSet;

    private bool raisePin = false;
    private bool lowerPin = false;
    private float raiselowerDistance = .475f;

    private void Update()
    {
        if (raisePin == true)
        {
            foreach (Pin pin in GameObject.FindObjectsOfType<Pin>())
            {
                pin.transform.position = Vector3.Lerp(pin.transform.position, new Vector3(pin.transform.position.x, (pin.transform.position.y + raiselowerDistance), pin.transform.position.z), Time.deltaTime * 1.3f);
                if (pin.transform.position.y >= .5f)
                {
                    raisePin = false;
                }
            }
        }
        if (lowerPin == true)
        {
            foreach (Pin pin in GameObject.FindObjectsOfType<Pin>())
            {
                pin.transform.position = Vector3.Lerp(pin.transform.position, new Vector3(pin.transform.position.x, (pin.transform.position.y - raiselowerDistance), pin.transform.position.z), Time.deltaTime * 1.3f);
                if (pin.transform.position.y <= .04f)
                {
                    lowerPin = false;
                    pin.GetComponent<Rigidbody>().useGravity = true;
                    pin.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
        }
    }

    public void RespawnPins()
    {
        Instantiate(pinSet, new Vector3(0, .5f, 18.8293f), Quaternion.Euler(new Vector3(-90,0,0)));
        foreach (Pin pin in GameObject.FindObjectsOfType<Pin>())
        {
            pin.GetComponent<Rigidbody>().useGravity = false;
            pin.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
    public void LowerPins()
    {
        lowerPin = true;
    }
    public void RaisePins()
    {
        foreach (Pin pin in GameObject.FindObjectsOfType<Pin>())
        {
            if (pin.IsStanding())
            {
                pin.GetComponent<Rigidbody>().useGravity = false;
                pin.GetComponent<Rigidbody>().isKinematic = true;
                raisePin = true;
            }
        }
    }
}
