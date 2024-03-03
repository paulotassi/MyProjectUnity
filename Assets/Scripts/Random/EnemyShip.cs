using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 initVel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = initVel;
        GetComponent<Rigidbody2D>().mass = 100f;
    }
}
