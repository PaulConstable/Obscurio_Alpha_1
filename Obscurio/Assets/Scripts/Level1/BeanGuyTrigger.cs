using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeanGuyTrigger : MonoBehaviour
{

    private int speechCheck = 1;
    public bool WellCheck = false;
    public bool wellGameWon = false;
    public bool WaterUsed = false;
    public bool BeanGame = false;
    public bool BeanPlanted = false;
    public bool BeanObtained = false;
    public bool PotionGame = false;
    public bool PotionCheck = false;
    public bool PotionObtained = false;
    public bool beanGameIntro = false;
    
    

    [SerializeField] public GameObject[] beanTexts;
    [SerializeField] public GameObject[] SpeechImages;
    [SerializeField] public GameObject[] ItemIcons;
    [SerializeField] public GameObject EButton;
    [SerializeField] public GameObject beanIntro;
    [SerializeField] public GameObject beanOutro;
    
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
        if (collision.gameObject.tag == "Player" && BeanObtained == false && PotionObtained == false && WellCheck == false && WaterUsed == false )
        {
            EButton.SetActive(true);
        }
        if(WaterUsed == true)
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
            if (Input.GetKeyDown(KeyCode.E) && PotionGame == false && PotionCheck == false)
            {
                beanTexts[7].SetActive(false);
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
                    beanIntro.SetActive(true);
                    beanGameIntro = true;
                    
                    speechCheck = 5;
                    print("Speech2");
                }

               
            }
            else if (collision.gameObject.tag == "Player" && speechCheck == 5 && BeanGame == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    EButton.SetActive(false);
                    beanTexts[3].SetActive(false);
                    beanTexts[4].SetActive(true);
                    DisplayBean();
                    BeanObtained = true;
                    speechCheck = 6;
                    print("Speech2");
                }
            }
            else if (collision.gameObject.tag == "Player" && speechCheck == 6 && BeanPlanted == true)
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
            else if (collision.gameObject.tag == "Player" && speechCheck == 7  && WaterUsed == true)
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
    }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                EButton.SetActive(false);
            }
            if (collision.gameObject.tag == "Player" && speechCheck == 2)
            {
                beanTexts[0].SetActive(false);
                
            }
            if (collision.gameObject.tag == "Player" && speechCheck == 3)
            {
                beanTexts[1].SetActive(false);
                
            }
            if (collision.gameObject.tag == "Player" && speechCheck == 4)
            {
                beanTexts[2].SetActive(false);
                
            }
            if (collision.gameObject.tag == "Player" && speechCheck == 5)
            {
                beanTexts[3].SetActive(false);
                

            }
            if (collision.gameObject.tag == "Player" && speechCheck == 6)
            {
                beanTexts[4].SetActive(false);
                
            }
            if (collision.gameObject.tag == "Player" && speechCheck == 7)
            {
                beanTexts[5].SetActive(false);
                SpeechImages[0].SetActive(true); //set to false, when watering can is obtained
                
            }
            if (collision.gameObject.tag == "Player" && speechCheck == 8)
            {
                beanTexts[6].SetActive(false);
                

            }
            if (collision.gameObject.tag == "Player" && speechCheck == 8)
            {
                beanTexts[7].SetActive(false);
                SpeechImages[1].SetActive(true);
                //EButton.SetActive(true);
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
        WellCheck = false;
        }
        


        public void DisplayCan()
        {
            ItemIcons[1].SetActive(true);
        }
        public void DisplayBean()
        {
            ItemIcons[0].SetActive(true);
        }
        

       
        public void RemoveCan()
        {
            ItemIcons[1].SetActive(false);
            WaterUsed = true;
        }
    public void RemovePotion()
    {
        ItemIcons[2].SetActive(false);
    }

        public void RemoveText()
        {
            beanTexts[3].SetActive(false);
        }

    public void BeanPlantedfunc()
    {
        BeanPlanted = true;
        ItemIcons[0].SetActive(false);
        BeanObtained = false;
    }

    
    
    public void Potions()
    {
        PotionObtained = true;
        ItemIcons[2].SetActive(true);
        PotionCheck = true;
    }

    
}
