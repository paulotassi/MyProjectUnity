using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeathScript : MonoBehaviour
{


    public UnityEvent Deathzone;
    public string tagThatTriggers = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tagThatTriggers)
        {
            Deathzone.Invoke();
        }
    }
}
