using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadShip : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
       if (transform.position.x < -3f)
        {
            Destroy(gameObject);
        }
      
    }
}
