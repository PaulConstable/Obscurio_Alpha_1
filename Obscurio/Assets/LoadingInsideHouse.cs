using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingInsideHouse : MonoBehaviour {

    
	
    public void OnTriggerStay2D(Collider2D collision)
    {
        

        if(collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("InsideHAG");
            
        }
    }

    

}
