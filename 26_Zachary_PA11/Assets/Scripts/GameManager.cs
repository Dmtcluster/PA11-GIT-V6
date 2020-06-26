using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private float score;

    GameManager thismanager;
    // Start is called before the first frame update
    void Start()
    {
        thismanager = this;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increasescore()
    {
        score += 10;
    }
}
