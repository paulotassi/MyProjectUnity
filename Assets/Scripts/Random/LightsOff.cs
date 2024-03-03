using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightsOff : MonoBehaviour
{
     public UnityEvent LightsOffEntered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lights")
        {
            Debug.Log("Lights off");
            LightsOffEntered.Invoke();
        }
    }
}
