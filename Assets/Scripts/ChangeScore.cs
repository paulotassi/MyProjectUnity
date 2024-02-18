using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ChangeScore : MonoBehaviour
{
    
    public int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    public void AddOneScore()
    {
        score++;
        GetComponent<TextMesh>().text = score.ToString();
    }
}
