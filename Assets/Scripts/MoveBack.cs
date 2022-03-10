using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    public float speed = 5f;

    private float zLimit = 3f;
    void Update()
    {
        Movement();
        OutOfBounds();
    }

    void Movement()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    void OutOfBounds()
    {
        if (transform.position.z < -zLimit)
        {
            Destroy(gameObject);
        }
    }
}
