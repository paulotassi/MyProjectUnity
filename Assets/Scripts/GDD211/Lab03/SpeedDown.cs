using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDown : PowerUps
{
    //Created to Find the Player Object and populate the speed function in the CarMover Script
    public GameObject MainPlayer;
    public override void PickUp()
    {
        MainPlayer = GameObject.Find("Player");
        base.PickUp();
        MainPlayer.GetComponent<CarMover>().carSpeed = 3f;
        MainPlayer.GetComponent<CarMover>().carTurnSpeed = 25f;
        MainPlayer.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, MainPlayer.GetComponent<Rigidbody>().velocity.z/2);



    }

}
