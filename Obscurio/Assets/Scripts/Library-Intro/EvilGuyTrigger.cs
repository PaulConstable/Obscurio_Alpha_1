using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EvilGuyTrigger : MonoBehaviour {

    public GameObject[] evilTexts;
    public GameObject eButton;
    public int evilText;

    public GameObject bookBlock;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            eButton.SetActive(true);
            //SceneManager.LoadScene("BookStory");
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && evilText == 0)
        {
            evilTexts[0].SetActive(true);
            eButton.SetActive(false);
            evilText = 1;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && evilText == 1)
        {
            evilTexts[0].SetActive(false);
            evilTexts[1].SetActive(true);
            eButton.SetActive(false);
            evilText = 2;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && evilText == 2)
        {
            evilTexts[1].SetActive(false);
            evilTexts[2].SetActive(true);
            eButton.SetActive(false);
            evilText = 3;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && evilText == 3)
        {
            evilTexts[2].SetActive(false);
            evilTexts[3].SetActive(true);
            eButton.SetActive(false);
            evilText = 4;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && evilText == 4)
        {
            evilTexts[3].SetActive(false);
            evilTexts[4].SetActive(true);
            eButton.SetActive(false);
            evilText = 5;
            bookBlock.SetActive(false);
        }

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            eButton.SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && evilText == 1)
        {
            evilTexts[0].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && evilText == 2)
        {
            evilTexts[1].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && evilText == 3)
        {
            evilTexts[2].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && evilText == 4)
        {
            evilTexts[3].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && evilText == 5)
        {
            evilTexts[4].SetActive(false);
        }
    }
}
