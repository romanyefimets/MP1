using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour {

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
        if (position.z >= 5 - (transform.localScale.z / 2))
            moveRight = false;
        if (position.z <= 0 + (transform.localScale.z / 2))
            moveRight = true;

        if (moveRight)
        {
            GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            position.z += speed * Time.deltaTime;

        }
        else
        {
            GetComponent<Renderer>().material.color = new Color(1, 1, 0);
            position.z -= speed * Time.deltaTime;

        }
        transform.position = new Vector3(transform.position.x, transform.position.y, position.z);
    }
}

