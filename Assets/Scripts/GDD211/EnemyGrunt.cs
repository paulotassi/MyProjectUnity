using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.UI;
using TMPro;


public class EnemyGrunt : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public float EnemySpeed = 2;
    public Animator EnemyAni;


    
    void Start()
    {
        currentHealth = maxHealth;

    }

    private void Update()
    {
        EnemySpeed = 1;
        transform.position -= new Vector3(0f, 0f, EnemySpeed * Time.deltaTime);
        EnemyAni.SetFloat("EnemyMove", 1);
    }

    public void TakeDamage(int Damage)
    {
        currentHealth -= Damage;
        EnemyAni.SetTrigger("GetHit");
        transform.position = transform.position;

        if (currentHealth <= 0)
        {
            Die();
        }

    }
    public void Die()
    {
        EnemyAni.SetBool("Die", true);
        Debug.Log("Enemy Died");
        this.enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<ScoreTracker>().scoreTrack();
    
    }
}
