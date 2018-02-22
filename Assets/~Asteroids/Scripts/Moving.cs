using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    public float movementSpeed = 10;
    public float rotationSpeed = 360;

    void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Vector3 position = transform.position;
            //position.y += movementSpeed * Time.deltaTime;
            //transform.position = position;

            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }
    }

    void Rotation()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        Rotation();
    }
}
