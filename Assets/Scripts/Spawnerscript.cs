using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnRed;
    public GameObject SpawnGreen;
    public GameObject SpawnBrown;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjectsRed", 1, 3);
        InvokeRepeating("SpawnObjectsGreen", 2, 3);
        InvokeRepeating("SpawnObjectsBrown", 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjectsRed()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnRed, transform.position, transform.rotation);
    }

    void SpawnObjectsGreen()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnGreen, transform.position, transform.rotation);
    }

    void SpawnObjectsBrown()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnBrown, transform.position, transform.rotation);
    }
}
