using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager thisManager;
    public Text ScoreText;
    public float ScoreValue;
    // Start is called before the first frame update
    void Start()
    {
        thisManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        ScoreValue++;
        ScoreText.text = "Score : " + ScoreValue;
    }
}
