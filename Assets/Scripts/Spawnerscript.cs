using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Spawnerscript : MonoBehaviour
{
    public static Spawnerscript Instance;
    public GameObject[] SpawnObject;
    public Text scoreTxt;
    public Image bgImg;

    float PositionY;
    int randNum;

    public bool gameOver = false;
    public int point;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null) Instance = this; else Destroy(this.gameObject);

        Time.timeScale = 1;

        bgImg.gameObject.SetActive(false);

        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + point;

        if(gameOver == true)
        {
            bgImg.gameObject.SetActive(true);

            Time.timeScale = 0;
        }

        if (Time.timeScale == 0)
            if (Input.GetKeyDown(KeyCode.Return))
                SceneManager.LoadScene("GameScene");

    }

    void SpawnObjects()
    {
        randNum = Random.Range(0, 3);
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject[randNum], transform.position, transform.rotation);
    }
}
