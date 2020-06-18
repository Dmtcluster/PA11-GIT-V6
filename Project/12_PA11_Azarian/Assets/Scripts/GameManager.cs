using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager thisManager = null;  
    [SerializeField] private Text Txt_Score = null;
    //[SerializeField] private Text Txt_Message = null;
    private int Score = 0;

    void Start()
    {
        thisManager = this;
        
    }

    void Update()
    {
        
    }

    public void UpdateScore(int value)
    {
        Score += value;
        Txt_Score.text = "SCORE : " + Score;
    }

    private void StartGame()
    {
        Score = 0;
        Time.timeScale = 1;
        Txt_Score.text = "SCORE : 0";
    }

}
