using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // defining public fields
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 10.0f;
    public float spawnPosZ = 20.0f;

    // defining private fields
    private float spawnDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame

    /*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }
    */

    // Animal Spawner with random pick from Animal array and random position
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, 3);
        Instantiate(
            animalPrefabs[animalIndex],
            new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ),
            animalPrefabs[animalIndex].transform.rotation);
    }
}
