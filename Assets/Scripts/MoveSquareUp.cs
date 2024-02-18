using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquareUp : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed1 = 2f;


    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0 ,speed1, 0) * Time.deltaTime;

        if (transform.position.y >= 75f)
        {
            Destroy(gameObject);
        }
    }
}

