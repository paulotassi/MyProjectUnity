using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAmongUs : MonoBehaviour
{
    public GameObject groundCheck;
    Rigidbody2D rb;
    Animator anim;
    float JumpForce = 3f;
    float Speed = 1f;
    public bool grounded = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Jump if Character is grounded
        RaycastHit2D hit = Physics2D.Linecast(transform.position, groundCheck.transform.position);
        if (hit.collider != null)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && grounded == true) 
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        //Move left and Right
        rb.velocity = new Vector2(0, rb.velocity.y);

        if (Input.GetKey(KeyCode.A))
        {
            
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
            transform.localScale = new Vector2(-1, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            
            rb.velocity = new Vector2(Speed, rb.velocity.y);
            transform.localScale = new Vector2(1, 1);
        }

        anim.SetFloat("RunSpeed", Mathf.Abs(rb.velocity.x));
    }
}
