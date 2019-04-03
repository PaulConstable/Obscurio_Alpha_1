using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour {


    public GameObject bounceObject;
    public AudioSource bounceAudio;

    // Use this for initialization
    void Start () {
        bounceAudio = bounceObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 450);
            bounceAudio.Play();
        }
    }
}
