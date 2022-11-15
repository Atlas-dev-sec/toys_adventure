using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosZ = -281.0f;
    private float startDelay = 2;
    private float spawnIntverval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnIntverval);
        InvokeRepeating("SpawnRightAnimal", startDelay, spawnIntverval);
    }
    // Update is called once per frame
    
    void SpawnLeftAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
         Vector3 spawnPos = new Vector3(Random.Range(-30.0f, 70.0f), 0, spawnPosZ);
         Vector3 rotation = new Vector3(0, 180, 0);
         Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));

    }

    void SpawnRightAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
         Vector3 spawnPos = new Vector3(Random.Range(-30.0f, 70.0f), 0, -307.0f);
         Vector3 rotation = new Vector3(0, 360, 0);
         Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));

    }
}
