using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MusicToggle : MonoBehaviour
{
    [SerializeField] private AudioSource asource;

    public void ToggleSound(bool soundIsOn)
    {
        Debug.Log($"Toggle Sound: {soundIsOn}");

        if (soundIsOn == false)
        {
            asource.volume = 0;
        }
        else
        {
            asource.volume = 1;
        }
    }

}