using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text txtscore;
    public GameObject player;


    private float score;

    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (obstacle.transform.position.x <= player.transform.position.x)
        {
            score += 10;
        }

        

        txtscore.text = "Score: " +score;
    }

    void increasescore()
    {
        
    }
}
