using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationTargetLoc : MonoBehaviour {

    // Use this for initialization
    public GameObject target;
    Vector3 position;

    void Start ()
    {
        position = transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit loc;

            if (Physics.Raycast(ray, out loc) && loc.collider.tag == "plane")
            {
                position = loc.point;
                position.y = target.transform.position.y;
                target.transform.position = position;
            }

        }

    }
}
