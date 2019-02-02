using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGame : MonoBehaviour {

    SpriteRenderer button;
    public Camera cam;
    public Sprite but;

// Use this for initialization
void Start () {
        button = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray click = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit connected;

            if(Physics.Raycast(click, out connected))
            {
                //Change Colour of sprite 
                button.color = Color.yellow;
            }
        }


	}
}

