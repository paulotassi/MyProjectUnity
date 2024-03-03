using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    float ct = 0;
    private int SpawnRandom;
    
   
    // Update is called once per frame
    void Update()
    {
        SpawnRandom = Random.Range(0, 5);
        if (ct > 1f)
        {
            //Debug.Log("Spawn Timed");
            int RandNum = Random.Range(0, 1);
            Instantiate(EnemyPrefabs[RandNum], new Vector3(-30f, 2.5f, 0f), Quaternion.identity);
            
            
            /*float RandNum = Random.Range(-3f, 3f);
            float randScale = Random.Range(0.1f, 0.3f);
            GameObject newball = Instantiate(EnemyPrefab);
            newball.transform.localScale = new Vector3 (randScale, randScale, randScale);
            newball.transform.position = new Vector2(3f, RandNum);*/
         
            ct = 0;
        }


        //Debug.Log(SpawnRandom*Time.deltaTime);

        ct += Time.deltaTime;
    }
}
