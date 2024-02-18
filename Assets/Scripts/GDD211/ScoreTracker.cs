using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text ScoreText;
    [SerializeField] public int deathCount = 0;

    // Update is called once per frame
    void Update()
    {
        
        ScoreText.text = "Orcs Killed:" + deathCount;
    }

    public void scoreTrack()
    {
        deathCount++;
        Debug.Log(deathCount);
    }
}
