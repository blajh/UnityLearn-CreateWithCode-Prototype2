using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnDelay = 1.0f; 
    private float lastPressTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float currentPressTime = Time.time;
            float timeBetweenPress = currentPressTime - lastPressTime;

            if (timeBetweenPress > spawnDelay)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                Debug.Log(timeBetweenPress);
                lastPressTime = Time.time;
            }
        }
    }
}
