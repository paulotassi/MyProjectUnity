using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterDemo : MonoBehaviour
{
    // Start is called before the first frame update

    int ct = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ct = ct+1;
        Debug.Log(ct);
        if (ct == 100)
        {
            Debug.Log("Hello");
        }

    }
}
