using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public string keyToReset = "r";
    public KeyCode keyToReset1 = KeyCode.LeftShift;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyToReset) && Input.GetKey(keyToReset1))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void GameReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
