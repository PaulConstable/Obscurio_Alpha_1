using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibrarianTrigger : MonoBehaviour {

    public GameObject[] librarianTexts;
    public GameObject eButton;
    public int librarianText;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            eButton.SetActive(true);

           
        }

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && librarianText == 0)
        {
            librarianTexts[0].SetActive(true);
            eButton.SetActive(false);
            librarianText = 1;
        }
        else if(Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && librarianText == 1)
        {
            librarianTexts[0].SetActive(false);
            librarianTexts[1].SetActive(true);
            eButton.SetActive(false);
            librarianText = 2;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && librarianText == 2)
        {
            librarianTexts[1].SetActive(false);
            librarianTexts[2].SetActive(true);
            eButton.SetActive(false);
            librarianText = 3;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && librarianText == 3)
        {
            librarianTexts[2].SetActive(false);
            librarianTexts[3].SetActive(true);
            eButton.SetActive(false);
            librarianText = 4;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            eButton.SetActive(false);
        }
        if(collision.gameObject.tag == "Player" && librarianText == 1)
        {
            librarianTexts[0].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && librarianText == 2)
        {
            librarianTexts[1].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && librarianText == 3)
        {
            librarianTexts[2].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && librarianText == 4)
        {
            librarianTexts[3].SetActive(false);
        }
    }


    



}
