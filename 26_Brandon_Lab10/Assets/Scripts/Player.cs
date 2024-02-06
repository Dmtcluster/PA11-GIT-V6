using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float speed;
    public float minY; 
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);
        float newYPosition = Mathf.Clamp(transform.position.y + verticalInput * speed * Time.deltaTime, minY, maxY);
        transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("LoseScene");
        }
    }
}