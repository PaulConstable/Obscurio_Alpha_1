using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WellPlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 10f;

    WellLose myWellLose;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        myWellLose = FindObjectOfType<WellLose>();
	}

    void Update()
    {
        if (moveInput > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        if(myWellLose.wellFailed == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.UnloadSceneAsync("Well-Jump_Game");
            
        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
	}

    
}
