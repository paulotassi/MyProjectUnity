using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementShot1 : MonoBehaviour
{
    public float speed1 = 0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime, Space.Self);
    }
}
