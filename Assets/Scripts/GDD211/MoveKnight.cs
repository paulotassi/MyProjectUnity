using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKnight : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 2f;
    Animator anim;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       rb.velocity = new Vector2(0f, 0f);
        //Move Right
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0f);
            GetComponent<SpriteRenderer>().flipX = false;
        } 
        //Move Left
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0f);
            GetComponent<SpriteRenderer>().flipX = true;
        }

        anim.SetFloat("RunSpeed", Mathf.Abs(rb.velocity.x));

    }
}
