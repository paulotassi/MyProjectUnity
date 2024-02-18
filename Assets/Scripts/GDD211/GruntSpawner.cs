using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntSpawner : MonoBehaviour
{
    public GameObject EnemySpawnPrefab;
    private float ct = 0;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        if (ct > 5f) 
        {
        Spawn();
            ct = 0;
        }
        ct += Time.deltaTime;
    }

    void Spawn()
    {
        if (EnemySpawnPrefab == null)
        {
            Debug.LogError("Prefab is not assigned!");
            return;
        }


        // Get the parent object's pos
        Vector3 parentPosition = transform.position;

        // Instantiate the prefab at the parent's position
        // Had to rotate 180 due to Grunts Spawning backwards
        Quaternion rotation = Quaternion.Euler(0f, 180f, 0f);
        GameObject spawnedPrefab = Instantiate(EnemySpawnPrefab, parentPosition, rotation);
        
    }
}