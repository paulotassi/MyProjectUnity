using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BridgeActivator : MonoBehaviour
{
public GameObject bridge;
    public UnityEvent ToggleOnBridge;
    public string tagThatTriggers = "Player";
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tagThatTriggers)
        {
            ToggleOnBridge.Invoke();
        }
        
    }
}
