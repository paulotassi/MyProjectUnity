using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : PowerUps
{
    //Variable to assign CarMover script and Carspeed function
    public GameObject MainPlayer;
    public override void PickUp()
    {
        MainPlayer = GameObject.Find("Player");
        base.PickUp();
        //Speed Up mechanic
        MainPlayer.GetComponent<CarMover>().carSpeed += 2f;
        MainPlayer.GetComponent<CarMover>().carTurnSpeed += 10f;
        MainPlayer.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, MainPlayer.GetComponent<Rigidbody>().velocity.z +25f);

    }
}
