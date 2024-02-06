using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cube1 : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
