using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropOption : MonoBehaviour {

    public GameObject targetLoc;
    public Dropdown drop;
     
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (drop.value != 0)
        {
            GameObject shape = Instantiate(Resources.Load(drop.captionText.text, typeof(GameObject))) as GameObject;
            Renderer shapeRender = shape.GetComponent<Renderer>();
            Vector3 size = shapeRender.bounds.size;
            shape.transform.position = new Vector3(targetLoc.transform.position.x, size.y / 2, targetLoc.transform.position.z);
            drop.value = 0;
        }
    }
}
