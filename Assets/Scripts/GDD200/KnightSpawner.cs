using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KnightSpawner : MonoBehaviour
{

        [SerializeField] private int randomSpawnLocation = 0;
        public GameObject KnightPrefab;
        public Transform[] spawnLocations;
        // Update is called once per frame
        public string tagThatTriggers = "Player";

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == tagThatTriggers)
            {
                KnightSpawnFunction();
            }

        }

        public void KnightSpawnFunction()
        {
            Instantiate(KnightPrefab, spawnLocations[randomSpawnLocation].transform.position, Quaternion.identity);
        }

}
