using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public float ct = 0f;
    [SerializeField] private int randomSpawnNum = 0;
    [SerializeField] private int randomSpawnLocation = 0;
    [SerializeField] private float randomSpawnTime = 0f;
    public GameObject[] PowerUpVariety;
    public Transform[] spawnLocations;
    // Update is called once per frame
    void Update()
    {
        randomSpawnTime = Random.Range(1, 4);
        randomSpawnLocation = Random.Range(0, 3);
        ct += Time.deltaTime;
        if (ct > randomSpawnTime)
        {
            randomSpawnNum = Random.Range(0, 2);
            Instantiate(PowerUpVariety[randomSpawnNum], spawnLocations[randomSpawnLocation].transform.position, Quaternion.identity);
            ct = 0f;
            Debug.Log(randomSpawnLocation);
        }
        
    }
}
