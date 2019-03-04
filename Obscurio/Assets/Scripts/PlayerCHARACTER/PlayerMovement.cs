using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController controller;


    float horizontalMove = 0f;
    public float speed = 40f;

    bool jump = false;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (TestScene.isLoaded == false)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
        }


        if (Input.GetKeyDown(KeyCode.K)) {
            TestScene.isLoaded = false;
        }

       




    }


      

	

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,jump);
        jump = false;
    }
}
