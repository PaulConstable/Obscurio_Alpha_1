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
        if(Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 0 && cardGameLoaded == false)
        {
            witchTexts[0].SetActive(true);
            eButton.SetActive(false);
            witchText = 1;
        }
        else if(Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 1 && cardGameLoaded == false)
        {
            witchTexts[0].SetActive(false);
            witchTexts[1].SetActive(true);
            eButton.SetActive(false);
            witchText = 2;
        }
        else if(Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 2 && cardGameLoaded == false)
        {
            
            eButton.SetActive(false);
            witchTexts[1].SetActive(false);
            witchTexts[2].SetActive(true);
            witchText = 3;
            
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 3 && cardGameLoaded == false)
        {
            eButton.SetActive(false);
            witchTexts[2].SetActive(false);
            witchTexts[3].SetActive(true);
            witchText = 4;
        }
        else if(Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 4 && cardGameLoaded == false)
        {
            witchTexts[3].SetActive(false);
            
            eButton.SetActive(false);
            
            SceneManager.LoadScene("CardGame2", LoadSceneMode.Additive);
            cardGameLoaded = true;
            witchText = 5;

        }
        else if(Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 5)
        {
            witchTexts[4].SetActive(true);
            witchText = 6;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 6)
        {
            witchTexts[4].SetActive(false);
            witchTexts[5].SetActive(true);
            witchText = 7;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 7 && dragGameLoaded == false)
        {
            witchTexts[5].SetActive(false);
            SceneManager.LoadScene("RecipeGame", LoadSceneMode.Additive);

            dragGameLoaded = true;
            witchText = 8;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 8 && dragGameLoaded == true)
        {
            witchTexts[6].SetActive(true);
            witchText = 9;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 9 && dragGameLoaded == true)
        {
            witchTexts[6].SetActive(false);
            witchTexts[7].SetActive(true);
            witchText = 10;
        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player" && witchText == 10 && dragGameLoaded == true)
        {
            witchTexts[7].SetActive(false);
            SceneManager.LoadScene("OutroScene");
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
        if (collision.gameObject.tag == "Player" && witchText == 5)
        {
            witchTexts[4].SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && witchText == 6)
        {
            witchTexts[5].SetActive(false);
        }

    }

   

    public void CompleteCardGame()
    {
        Debug.Log("cARD COMPELTE");
        witchTexts[4].SetActive(true);
        witchText = 5;

    }
}
