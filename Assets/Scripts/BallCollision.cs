using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    //Stops Ball From Collidiing With Player

    private GameObject player;
    private AudioSource ballHitSource;

    private void Awake()
    {
        player = GameObject.Find("Player Controller");
        Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
        ballHitSource = GetComponent<AudioSource>();
        ballHitSource.enabled = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Lane")
        {
        }
    }

}
