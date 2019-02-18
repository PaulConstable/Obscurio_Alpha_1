using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibrarianTrigger : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("1");
        }
    }
}
