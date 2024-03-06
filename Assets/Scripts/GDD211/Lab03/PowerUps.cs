using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
   
    public virtual void PickUp()
    {
            Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickUp();
        }
    }
    
}
