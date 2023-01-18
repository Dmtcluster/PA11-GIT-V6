using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;


    private float score = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        if (transform.position.y >= 4)
        {
            transform.position = new Vector3(-7.5f, 3.9f, 0);
        }
        if (transform.position.y <= -4)
        {
            transform.position = new Vector3(-7.5f, -3.9f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("LoseScene");
        }

        if (other.gameObject.CompareTag("Avoid"))
        {
            score++;
            scoreText.text = "Score: " + score;
        }
    }
}
