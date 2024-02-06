using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] cubePrefabs;
    float positionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        // Your Update logic (if any)
    }

    void SpawnObjects()
    {
        for (int i = 0; i < 3; i++) // Spawn three cubes at each interval
        {
            positionY = Random.Range(4f, -4f);

            // Randomly select a cube prefab from the array
            GameObject selectedCubePrefab = cubePrefabs[Random.Range(0, cubePrefabs.Length)];

            // Spawn the selected cube
            Vector3 spawnPosition = new Vector3(transform.position.x, positionY, transform.position.z);
            Instantiate(selectedCubePrefab, spawnPosition, Quaternion.identity);
        }
    }
}

