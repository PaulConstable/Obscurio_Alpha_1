using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public GameObject EButton;

    public void OnTriggerStay2D(Collider2D collision)
    {

        EButton.SetActive(true);


        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Library Scene");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        EButton.SetActive(false);
    }



}
