using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 upScale;
    private Vector3 downScale;
    private float lowLimit;
    private float highLimit;

    void Start()
    {
        upScale = new Vector3(-0.004f, 0.008f, 0);
        downScale = new Vector3(0.004f, -0.008f, 0);
        highLimit = 2.2f;
        lowLimit = 1.4f;
    }

    void Update()
    {
        Transformation();
    }

    void Transformation()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.localScale.y < highLimit)
            {
                transform.localScale += upScale;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (transform.localScale.x < lowLimit)
            {
                transform.localScale += downScale;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("GameOver");
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}
