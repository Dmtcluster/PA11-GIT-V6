using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    private float yMin = -3.9f, yMax = 3.9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");
        float yLock = Mathf.Clamp(transform.position.y, -3.9f, 3.9f);

        transform.position = new Vector3(transform.position.x, yLock, transform.position.z);

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

      

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
