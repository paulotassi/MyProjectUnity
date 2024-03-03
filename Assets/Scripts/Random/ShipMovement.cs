using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

    float speed = 2f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
      //Foward Thruster
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * speed);
        }
      //Reverse Thruster
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.up * -speed);
        }
      //Turn Left
        if (Input.GetKey(KeyCode.A))
        {
            rb.rotation += 1f;
        }
     //Turn Right
        if (Input.GetKey(KeyCode.D))
        {
            rb.rotation += -1f;
        }
    }
}
