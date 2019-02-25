using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibrarianTrigger : MonoBehaviour {

    [SerializeField] GameObject librarianText;
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Debug.Log("1");
            librarianText.SetActive(true);
            
        }
    }
}
