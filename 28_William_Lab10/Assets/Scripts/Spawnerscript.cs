using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject_Red;
    public GameObject SpawnObject_Brown;
    public GameObject SpawnObject_Green;

    public Text scoreText;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + ObstacleMovement.score;
    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        int RandomIndex = Random.Range(0, 3);
        GameObject spawnObject;

        switch (RandomIndex)
        {
            case 0:
                spawnObject = SpawnObject_Red;
                break;
            case 1:
                spawnObject = SpawnObject_Brown;
                break;
            case 2:
                spawnObject = SpawnObject_Green;
                break;
            default:
                spawnObject = SpawnObject_Green;
                break;
        }

        Instantiate(spawnObject, transform.position, transform.rotation);
    }
}
