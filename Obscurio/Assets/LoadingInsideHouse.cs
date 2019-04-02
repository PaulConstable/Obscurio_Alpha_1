using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingInsideHouse : MonoBehaviour {

    [SerializeField] public GameObject eButton;
    public bool keypadLoaded;
	
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            eButton.SetActive(true);
        }


        if(collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && keypadLoaded == false)
        {
            
            SceneManager.LoadScene("KeypadGame", LoadSceneMode.Additive);
            keypadLoaded = true;

        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            eButton.SetActive(false);
        }
    }

    public void LeftKeypad()
    {
        keypadLoaded = false;
    }

}
