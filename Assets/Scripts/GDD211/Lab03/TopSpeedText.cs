using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopSpeedText : MonoBehaviour
{
    public TMP_Text speedText;
    public float topSpeed;
    // Start is called before the first frame update
    void Start()
    {
        topSpeed = 0;
        speedText.text = "Speed: " + topSpeed + "MPH";
    }

    // Update is called once per frame
    void Update()
    {
        topSpeed = GameObject.Find("Player").GetComponent<Rigidbody>().velocity.z;
        speedText.text = "Speed: " + (int) topSpeed + "MPH";
    }
}
