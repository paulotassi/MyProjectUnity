using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementShot2 : MonoBehaviour
{
        public float speed1 = 0f;
        // Update is called once per frame
        void Update()
        {
            transform.Translate((Vector3.forward * Time.deltaTime)*speed1, Space.Self);
        }
    }
