using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveWithForces : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move Player Left and Right
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-1f, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(1f, 0));
        }
        //Move Player Up and Down
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector2(0 , 1f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector2(0, -1f));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("RedCircle"))
        {
           
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (collision.CompareTag("GreenCircle"))
        {
          
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        Destroy(collision.gameObject);
    }
}