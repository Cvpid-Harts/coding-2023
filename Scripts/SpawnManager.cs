using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX;
    private float spawnPosZ;
    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {

        if (Input.GetKeyDown (KeyCode.S))
        {
            SpawnRandomAnimal();
        }

    }

    void SpawnRandomAnimal(){
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnPos);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],new Vector3((Random.Range(-20, 20)),0,20),animalPrefabs[animalIndex].transform.rotation);

    }

}
