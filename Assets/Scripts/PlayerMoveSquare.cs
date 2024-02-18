using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveSquare : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
            Debug.Log("Key Pressed");
            
        }
        
    }
}
