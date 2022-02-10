using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    float maxYlimit = 3.9f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        if(transform.position.y < -maxYlimit)
        {
            transform.position = new Vector3(transform.position.x, -maxYlimit , transform.position.z);
        }
        
        if(transform.position.y > maxYlimit)
        {
            transform.position = new Vector3(transform.position.x, maxYlimit , transform.position.z);
        }
      

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
