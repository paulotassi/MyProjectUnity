using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class EnemyChaser : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float enemySpeed = 3f;
    float currentDistanceToPlayer = 0f;
    public float distanceAggro = 100f;
    private float enemyY;
    public UnityEvent onPlayerTouch;
    public float killThreshold = 3f;
    public Animator ani;

    void Start()
    {
        enemyY = transform.position.y;
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        

        
        
        currentDistanceToPlayer = Vector3.Distance(this.transform.position, target.position);

        if (currentDistanceToPlayer < distanceAggro)
        {
            transform.LookAt(target.transform);
            transform.Translate(enemySpeed*Vector3.forward *Time.deltaTime);

            ani.SetFloat("MovementSpeed", 1f);
        }

        if(currentDistanceToPlayer < killThreshold)
        {
            onPlayerTouch.Invoke();
        }
    }
}
