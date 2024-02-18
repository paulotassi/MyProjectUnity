using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXToggle : MonoBehaviour
{
    [SerializeField] private AudioSource SFX1;
    [SerializeField] private AudioSource SFX2;
    [SerializeField] private AudioSource SFX3;
    [SerializeField] private AudioSource SFX4;
    [SerializeField] private AudioSource SFX5;
    [SerializeField] private AudioSource SFX6;
    [SerializeField] private AudioSource SFX7;
    [SerializeField] private AudioSource SFX8;
    [SerializeField] private AudioSource SFX9;
    [SerializeField] private AudioSource SFX10;
    [SerializeField] private AudioSource SFX11;
    [SerializeField] private AudioSource SFX12;
    [SerializeField] private AudioSource SFX13;
    [SerializeField] private AudioSource SFX14;

    // Start is called before the first frame update
    public void ToggleSFX(bool sfxIsON)
    {
        if (sfxIsON == false)
        {
            SFX1.volume = 0;
            SFX2.volume = 0;
            SFX3.volume = 0;
            SFX4.volume = 0;
            SFX5.volume = 0;
            SFX6.volume = 0;
            SFX7.volume = 0;
            SFX8.volume = 0;
            SFX9.volume = 0;
            SFX10.volume = 0;
            SFX11.volume = 0;
            SFX12.volume = 0;
            SFX13.volume = 0;
            SFX14.volume = 0;
        }
        else
        {
            SFX1.volume = 1;
            SFX2.volume = 1;
            SFX3.volume = 1;
            SFX4.volume = 1;
            SFX5.volume = 1;
            SFX6.volume = 1;
            SFX7.volume = 1;
            SFX8.volume = 1;
            SFX9.volume = 1;
            SFX10.volume = 1;
            SFX11.volume = 1;
            SFX12.volume = 1;
            SFX13.volume = 1;
            SFX14.volume = 1;
        }
    }
}
