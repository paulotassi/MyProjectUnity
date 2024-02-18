using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    public Animator AttackAnimator;

    public Transform AttackPoint;
    public float AttackRange = 1f;
    public LayerMask EnemyLayers;
    public int attackDamage = 50;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
    void Attack()
    {
        //play animation
        AttackAnimator.SetTrigger("Attack");

        //Detect Enemies in range
        Collider[] HitEnemies = Physics.OverlapSphere(AttackPoint.position, AttackRange, EnemyLayers);

        //Damage
        foreach (Collider enemy in HitEnemies) 
        {
            enemy.GetComponent<EnemyGrunt>().TakeDamage(attackDamage);
            Debug.Log("We Hit" + enemy.name);
        }
    }
    void OnDrawGizmos()
    {
        if (AttackPoint == null)
            return;

        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
       
    }
}
