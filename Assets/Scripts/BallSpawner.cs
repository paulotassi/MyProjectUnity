using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject inspectorBall;
    // Start is called before the first frame update
public void spawnBallInGame()
    {
        Instantiate(inspectorBall, new Vector3(0f, 60f, 0f), Quaternion.identity);

    }
}
