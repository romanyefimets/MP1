using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    Vector3 position;
    public float speed;
    public float angleSpeed;
    bool moveUp;

	// Use this for initialization
	void Start ()
    {
        moveUp = true;
        position = transform.position;
        GetComponent<Renderer>().material.color = new Color(1, 1, 1);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (position.y >= 5 + (transform.localScale.x / 2))
            moveUp = false;
        if (position.y <= transform.localScale.y / 2)
            moveUp = true;

        if (moveUp)
        {
            GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            position.y += speed * Time.deltaTime;
        }
        else
        {
            GetComponent<Renderer>().material.color = new Color(1, 0, 1);
            position.y -= speed * Time.deltaTime;

        }
        transform.Rotate(0, angleSpeed * Time.deltaTime, 0);
        transform.position = new Vector3(transform.position.x, position.y, transform.position.z);
    }
}
