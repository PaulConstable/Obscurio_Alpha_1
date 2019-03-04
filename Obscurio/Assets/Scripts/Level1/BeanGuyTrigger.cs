using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeanGuyTrigger : MonoBehaviour
{

    private int speechCheck = 1;
    public bool WellCheck = false;
    public bool wellGameWon = false;
    public bool BeanGame = false;
    public bool BeanPlanted = false;
    public bool PotionGame = false;

    [SerializeField] public GameObject[] beanTexts;
    [SerializeField] public GameObject[] SpeechImages;
    [SerializeField] public GameObject[] ItemIcons;
    [SerializeField] public GameObject EButton;
    //public bool text;

    WellWin myWellWin;

    [SerializeField] public GameObject LevelSwitch;



    private void Start()
    {
        BeanGame = true;
        PotionGame = true;
        FindObjectOfType<WellWin>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            EButton.SetActive(true);
        }
    }

   

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E) && BeanGame == false)
            {
                    SceneManager.LoadScene("BeanGame", LoadSceneMode.Additive);
                    LevelSwitch.SetActive(false);
                
            }
            if (Input.GetKeyDown(KeyCode.E) && BeanGame == false)
            {
                SceneManager.LoadScene("Puzzle-Game", LoadSceneMode.Additive);

            }

        if (collision.gameObject.tag == "Player" && speechCheck == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EButton.SetActive(false);
                beanTexts[0].SetActive(true);
                speechCheck = 2;
                print("Speech1");


            }
        }
        else if (collision.gameObject.tag == "Player" && speechCheck == 2)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EButton.SetActive(false);
                beanTexts[0].SetActive(false);
                beanTexts[1].SetActive(true);
                speechCheck = 3;
                print("Speech2");
            }
        }
        else if (collision.gameObject.tag == "Player" && speechCheck == 3)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EButton.SetActive(false);
                beanTexts[1].SetActive(false);
                beanTexts[2].SetActive(true);
                speechCheck = 4;
                print("Speech2");
            }
        }
        else if (collision.gameObject.tag == "Player" && speechCheck == 4)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EButton.SetActive(false);
                beanTexts[2].SetActive(false);
                beanTexts[3].SetActive(true);
                BeanGame = false;
                

                speechCheck = 5;
                print("Speech2");
            }
        }
        else if (collision.gameObject.tag == "Player" && speechCheck == 5 && BeanGame == true )
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EButton.SetActive(false);
                beanTexts[3].SetActive(false);
                beanTexts[4].SetActive(true);
                DisplayBean();
                speechCheck = 6;
                print("Speech2");
            }
        }
        else if (collision.gameObject.tag == "Player" && speechCheck == 6  && BeanPlanted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EButton.SetActive(false);
                beanTexts[4].SetActive(false);
                beanTexts[5].SetActive(true);
                speechCheck = 7;
                WellCheck = true; // Makes WellGamePlayable
                print("Speech2");
            }
        }
        else if (collision.gameObject.tag == "Player" && speechCheck == 7 && wellGameWon == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EButton.SetActive(false);
                beanTexts[5].SetActive(false);
                beanTexts[6].SetActive(true);
                speechCheck = 8;
                print("Speech2");
            }
        }
        else if (collision.gameObject.tag == "Player" && speechCheck == 8)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EButton.SetActive(false);
                beanTexts[6].SetActive(false);
                beanTexts[7].SetActive(true);
                speechCheck = 9;
                PotionGame = false;
                print("Speech2");
            }
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            EButton.SetActive(false);
        }
        if (collision.gameObject.tag == "Player" && speechCheck == 2)
        {
            beanTexts[0].SetActive(false);
            EButton.SetActive(true);
        }
        if (collision.gameObject.tag == "Player" && speechCheck == 3)
        {
            beanTexts[1].SetActive(false);
            EButton.SetActive(true);
        }
        if (collision.gameObject.tag == "Player" && speechCheck == 4)
        {
            beanTexts[2].SetActive(false);
            EButton.SetActive(true);
        }
        if (collision.gameObject.tag == "Player" && speechCheck == 5)
        {
            beanTexts[3].SetActive(false);
            EButton.SetActive(true);

        }
        if (collision.gameObject.tag == "Player" && speechCheck == 6)
        {
            beanTexts[4].SetActive(false);
            EButton.SetActive(true);
        }
        if (collision.gameObject.tag == "Player" && speechCheck == 7)
        {
            beanTexts[5].SetActive(false);
            SpeechImages[0].SetActive(true); //set to false, when watering can is obtained
            EButton.SetActive(true);
        }
        if (collision.gameObject.tag == "Player" && speechCheck == 8)
        {
            beanTexts[6].SetActive(false);
            EButton.SetActive(true);

        }
        if (collision.gameObject.tag == "Player" && speechCheck == 8)
        {
            beanTexts[7].SetActive(false);
            SpeechImages[1].SetActive(true);
            EButton.SetActive(true);
        }

    }

    public void CanSpeechBubbleRemoved()
    {
        SpeechImages[0].SetActive(false);
    }
    public void PotionSpeechBubbleRemoved()
    {
        SpeechImages[1].SetActive(false);
    }

    public void returnState()
    {
        wellGameWon = true;
    }

    public void DisplayCan()
    {
        ItemIcons[1].SetActive(true);
    }
    public void DisplayBean()
    {
        ItemIcons[0].SetActive(true);
    }
    public void DisplayPotion()
    {
        ItemIcons[2].SetActive(true);
    }

    public void RemoveBean()
    {
        ItemIcons[0].SetActive(false);
    }
    public void RemoveCan()
    {
        ItemIcons[1].SetActive(false);
    }

    public void RemoveText()
    {
        beanTexts[3].SetActive(false);
    }

    public void BeanPlantedfunc()
    {
        BeanPlanted = true;
    }
}
