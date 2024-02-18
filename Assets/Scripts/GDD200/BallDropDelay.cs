using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallDropDelay : MonoBehaviour
{
    private float ct = 0f;
    public float DelayTime;
    public UnityEvent scoreIncrease;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody>().useGravity = true;
        if (ct > DelayTime)
        {

            GetComponent<Rigidbody>().useGravity = true;
        }
        ct += Time.deltaTime;
        

        //Debug.Log(ct);
    }
    private void OnTriggerEnter(Collider other)
    {
        scoreIncrease.Invoke();
    }


}
