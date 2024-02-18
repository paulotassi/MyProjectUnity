using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootmanControl : MonoBehaviour
{
    [SerializeField] private Animator ani;
    public float WalkSpeed;
    private float AnimationSpeed;
    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float input = Input.GetAxisRaw("Horizontal");

        WalkSpeed = Mathf.Lerp(WalkSpeed, input, Time.deltaTime*2);
        if (input > 0)
        {
            transform.position += new Vector3(0f, 0f, input * WalkSpeed * Time.deltaTime);
        }
        else if (input <0)
        {
            transform.position -= new Vector3(0f, 0f, input * WalkSpeed * Time.deltaTime);
        }
        AnimationSpeed = Mathf.Lerp(AnimationSpeed,input, Time.deltaTime*2);
        

        ani.SetFloat ("MovementSpeed", AnimationSpeed);
        

    }
}
