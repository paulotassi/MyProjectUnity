using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCubeToggle : MonoBehaviour
{
    public Toggle toggleIsOn;

    private void Update()
    {
        if (toggleIsOn == false)
        {
            Debug.Log("False");
        }
        else if (toggleIsOn == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
    /*public void ToggleMovement(bool IsOn)
    {
        Debug.Log($"ToggleMovement {IsOn}");

        if (IsOn == false)
        {
          
        }
        else if (IsOn == true) 
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }*/

}
