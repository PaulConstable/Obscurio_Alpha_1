using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibrarianTrigger : MonoBehaviour {

    
    private int speechCheck = 1;
    [SerializeField] public GameObject[] texts;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Setting the first UI
        if (collision.gameObject.tag == "Player" && speechCheck == 1)
        {
            
            texts[0].SetActive(true);
        }

        //Changing the UI
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
            texts[0].SetActive(false);
            texts[1].SetActive(true);
            speechCheck = 2;
        }

        //Keeping the 2nd UI if player leaves trigger and returns
        if (collision.gameObject.tag == "Player" && speechCheck == 2)
        {
            texts[1].SetActive(true);
        }

    }

    //Removing UI when player leaves the trigger zone
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && speechCheck == 1)
        {
            
            texts[0].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && speechCheck == 2)
        {
            
            texts[1].SetActive(false);
        }
    }

    





}
