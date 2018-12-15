﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    //Stops Ball From Collidiing With Player

    private GameObject player;

    private void Awake()
    {
        player = GameObject.Find("Player Controller");
        Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
    }

}
