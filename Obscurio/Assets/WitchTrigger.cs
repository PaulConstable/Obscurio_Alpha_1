using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WitchTrigger : MonoBehaviour {

    [SerializeField] public GameObject eButton;
    [SerializeField] public GameObject[] witchTexts;
    public int witchText = 10;
    public bool cardGameLoaded;
    public bool dragGameLoaded;
    
    


    public void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "Player")
       {
            eButton.SetActive(true);
            witchText = 0;
       }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 0)
        {
            witchTexts[0].SetActive(true);
            eButton.SetActive(false);
            witchText = 1;
        }
        else if(Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 1)
        {
            witchTexts[0].SetActive(false);
            witchTexts[1].SetActive(true);
            eButton.SetActive(false);
            witchText = 2;
        }
        else if(Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 2 && cardGameLoaded == false)
        {
            SceneManager.LoadScene("CardGame2", LoadSceneMode.Additive);
            eButton.SetActive(false);
            witchTexts[1].SetActive(false);
            cardGameLoaded = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 3 && cardGameLoaded == true)
        {
            eButton.SetActive(false);
            witchTexts[2].SetActive(false);
            witchTexts[3].SetActive(true);
            witchText = 4;
        }
        else if(Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 4 && cardGameLoaded == true && dragGameLoaded == false)
        {
            witchTexts[3].SetActive(false);
            eButton.SetActive(false);
            SceneManager.LoadScene("RecipeGame", LoadSceneMode.Additive);
            dragGameLoaded = true;
            
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            eButton.SetActive(false);
        }
        if(collision.gameObject.tag == "Player" && witchText == 1)
        {
            witchTexts[0].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && witchText == 2)
        {
            witchTexts[1].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && witchText == 3)
        {
            witchTexts[2].SetActive(false);
        }
        if(collision.gameObject.tag == "Player" && witchText == 4)
        {
            witchTexts[3].SetActive(false);
        }
    }

    public void CompleteCardGame()
    {
        Debug.Log("cARD COMPELTE");
        witchTexts[2].SetActive(true);
        witchText = 3;

    }
}
