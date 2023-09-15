using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float timeInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //Function similar to setInterval in javascript
        InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, timeInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        // Randomize a animal to spawn on screen
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Randomize the position of the animal spawn
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        //Instantiate the animal
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
