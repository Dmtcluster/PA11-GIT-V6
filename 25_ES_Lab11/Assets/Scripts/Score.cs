using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoretext;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag=="Obstacle")
        {
            Destroy(collision.gameObject);
            score = score += 1;
            scoretext.GetComponent<Text>().text = "Score: " + score;
        }
    }
}
