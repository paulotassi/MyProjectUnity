using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class CarMover : MonoBehaviour
{
    public float carSpeed = 75f;
    public float carTurnSpeed = 25f;
    public float totalSpeed;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        totalSpeed = rb.velocity.z;
        rb.velocity = new Vector3(0, 0, rb.velocity.z);
        float vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 40f)
        {
            //rb.AddForce(carTurnSpeed, 0, 0);
            rb.velocity = new Vector3(carTurnSpeed, 0, rb.velocity.z);
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -30f)
        {
            //rb.AddForce(-carTurnSpeed, 0, 0);
            rb.velocity = new Vector3 (-carTurnSpeed, 0, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.S) && rb.velocity.z > 0f)
        {
            rb.AddForce(0, 0, -carSpeed*2f);
        }
        //Moving Forward and capping out th speed
        if (Input.GetKey(KeyCode.W)  && rb.velocity.z < 300f)
        {
            rb.AddForce(0,0,carSpeed);
        }
        

    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("A");
    }
}
