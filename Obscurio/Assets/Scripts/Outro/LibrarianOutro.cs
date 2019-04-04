using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LibrarianOutro : MonoBehaviour {

    public GameObject[] librarianTexts;
    public GameObject eButton;
    public int librarianText;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
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
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && librarianText == 1)
        {
            librarianTexts[0].SetActive(false);
            librarianTexts[1].SetActive(true);
            eButton.SetActive(false);
            librarianText = 2;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && librarianText == 2)
        {
            librarianTexts[1].SetActive(false);
            eButton.SetActive(false);
            librarianText = 3;
            SceneManager.LoadScene("Medal Scene");
        }

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            eButton.SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && librarianText == 1)
        {
            librarianTexts[0].SetActive(false);
        }
    }
}
