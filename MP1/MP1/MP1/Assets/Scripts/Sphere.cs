using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    Vector3 position;
    public float speed;
    bool moveRight;

    // Use this for initialization
    void Start()
    {
        moveRight = true;
        position = transform.position;
        GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (position.x >= 5 - (transform.localScale.x / 2))
            moveRight = false;
        if (position.x <= 0 + (transform.localScale.x / 2))
            moveRight = true;

        if (moveRight)
        {
            GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            position.x += speed * Time.deltaTime;

        }
        else
        {
            GetComponent<Renderer>().material.color = new Color(0, 1, 1);
            position.x -= speed * Time.deltaTime;

        }
        transform.position = new Vector3(position.x, transform.position.y, transform.position.z);
    }
}
