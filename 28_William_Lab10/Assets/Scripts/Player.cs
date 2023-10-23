using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float minY;
    public float maxY;

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float newPositionY = transform.position.y + verticalInput * speed * Time.deltaTime;
        float clampedPositionY = Mathf.Clamp(newPositionY, minY, maxY);
        transform.position = new Vector3(transform.position.x, clampedPositionY, transform.position.z);
    }
}