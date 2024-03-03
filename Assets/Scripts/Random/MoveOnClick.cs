using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnClick : MonoBehaviour
{
    public GameObject ScoreChanger;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        float randomX = Random.Range(-3f, 3f);
        float randomy = Random.Range(-2.4f, 2.3f);
        transform.position = new Vector2(randomX, randomy);
        ScoreChanger.GetComponent<ChangeScore>().AddOneScore();
    }
}
