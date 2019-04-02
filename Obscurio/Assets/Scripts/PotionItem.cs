using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionItem : MonoBehaviour {

    PotionManager myPotionManager;

    [SerializeField] public string correctItem1Stage1 = "";
    [SerializeField] public string correctItem2Stage1 = "";

    [SerializeField] public string correctItem1Stage2 = "";
    [SerializeField] public string correctItem2Stage2 = "";
    [SerializeField] public string correctItem3Stage2 = "";

    [SerializeField] public string correctItem1Stage3 = "";
    [SerializeField] public string correctItem2Stage3 = "";
    [SerializeField] public string correctItem3Stage3 = "";
    [SerializeField] public string correctItem4Stage3 = "";


    [SerializeField] GameObject correctItem1, correctItem2, correctItem3;
    [SerializeField] GameObject wrongItem1, wrongItem2, wrongItem3;

    private string correctPotionStage1 = "";
    private string correctPotionStage2 = "";
    private string correctPotionStage3 = "";
    public static string playerPotion = "";
    public static int buttonsPressed = 0;

    public int TimesWrong;
    

    // Use this for initialization
    void Start() {
        myPotionManager = FindObjectOfType<PotionManager>();

        correctPotionStage1 = correctItem1Stage1 + correctItem2Stage1;
        Debug.Log(correctPotionStage1);

        correctPotionStage2 = correctItem1Stage2 + correctItem2Stage2 + correctItem3Stage2;
        Debug.Log(correctPotionStage2);

        correctPotionStage3 = correctItem1Stage3 + correctItem2Stage3 + correctItem3Stage3 + correctItem4Stage3;
        Debug.Log(correctPotionStage3);

    }

    // Update is called once per frame
    void Update() {

        //Debug.Log(playerPotion);

        if (buttonsPressed == 2 && myPotionManager.playerStage == 1)
        {
            if (playerPotion == correctPotionStage1)
            {
                Debug.Log("Correct");
                myPotionManager.turnOnUI1();
                myPotionManager.playerStage = 2;
                resetHelp();


            }
            else
            {
                Debug.Log("Wrong");
                buttonsPressed = 0;
                playerPotion = "";
                myPotionManager.turnOn();
                TimesWrong++;
                resetHelp();
            }
        } else if (buttonsPressed == 3 && myPotionManager.playerStage == 2)
        {
            if (playerPotion == correctPotionStage2)
            {
                Debug.Log("Correct");
                myPotionManager.turnOnUI2();
                myPotionManager.playerStage = 3;
                resetHelp();
            }
            else
            {
                Debug.Log("Wrong");
                buttonsPressed = 0;
                playerPotion = "";
                myPotionManager.turnOn();
                TimesWrong++;
                resetHelp();
            }
        } else if (buttonsPressed == 4 && myPotionManager.playerStage == 3)
        {
            if (playerPotion == correctPotionStage3)
            {
                myPotionManager.turnOnUI3();
                Debug.Log("Correct");
                myPotionManager.playerStage = 4;
                resetHelp();
            }
            else
            {
                Debug.Log("Wrong");
                buttonsPressed = 0;
                playerPotion = "";
                myPotionManager.turnOn();
                TimesWrong++;
                resetHelp();
            }
        }

       
    }

    void OnMouseUp()
    {
        if (buttonsPressed < 5)
        {
            playerPotion += gameObject.name;
            gameObject.SetActive(false);
            buttonsPressed += 1;
            checkHelp();
        }
    }

    public void resetHelp()
    {
        correctItem1.SetActive(false);
        correctItem2.SetActive(false);
        correctItem3.SetActive(false);
        wrongItem1.SetActive(false);
        wrongItem2.SetActive(false);
        wrongItem3.SetActive(false);
    }


    public void checkHelp()
    {
        // stage 1 correct or wrong
        if (buttonsPressed == 1 && myPotionManager.playerStage == 1 && correctItem1Stage1 == gameObject.name)
        {
            correctItem1.SetActive(true);
        }
        else if (buttonsPressed == 1 && myPotionManager.playerStage == 1 && correctItem1Stage1 != gameObject.name)
        {
            wrongItem1.SetActive(true);
        }

        if (buttonsPressed == 2 && myPotionManager.playerStage == 1 && correctItem2Stage1 == gameObject.name)
        {
            correctItem2.SetActive(true);
        }
        else if (buttonsPressed == 2 && myPotionManager.playerStage == 1 && correctItem2Stage1 != gameObject.name)
        {
            wrongItem2.SetActive(true);
        }

        // stage 2 correct or wrong
        if (buttonsPressed == 1 && myPotionManager.playerStage == 2 && correctItem1Stage2 == gameObject.name)
        {
            correctItem1.SetActive(true);
        }
        else if (buttonsPressed == 1 && myPotionManager.playerStage == 2 && correctItem1Stage2 != gameObject.name)
        {
            wrongItem1.SetActive(true);
        }

        if (buttonsPressed == 2 && myPotionManager.playerStage == 2 && correctItem2Stage2 == gameObject.name)
        {
            correctItem2.SetActive(true);
        }
        else if (buttonsPressed == 2 && myPotionManager.playerStage == 2 && correctItem2Stage2 != gameObject.name)
        {
            wrongItem2.SetActive(true);
        }

        if (buttonsPressed == 3 && myPotionManager.playerStage == 2 && correctItem3Stage2 == gameObject.name)
        {
            correctItem3.SetActive(true);
        }
        else if (buttonsPressed == 3 && myPotionManager.playerStage == 2 && correctItem3Stage2 != gameObject.name)
        {
            wrongItem3.SetActive(true);
        }

        // stage 3 correct or wrong
        if (buttonsPressed == 1 && myPotionManager.playerStage == 3 && correctItem1Stage3 == gameObject.name)
        {
            correctItem1.SetActive(true);
        }
        else if (buttonsPressed == 1 && myPotionManager.playerStage == 3 && correctItem1Stage3 != gameObject.name)
        {
            wrongItem1.SetActive(true);
        }

        if (buttonsPressed == 2 && myPotionManager.playerStage == 3 && correctItem2Stage3 == gameObject.name)
        {
            correctItem2.SetActive(true);
        }
        else if (buttonsPressed == 2 && myPotionManager.playerStage == 3 && correctItem2Stage3 != gameObject.name)
        {
            wrongItem2.SetActive(true);
        }

        if (buttonsPressed == 3 && myPotionManager.playerStage == 3 && correctItem3Stage3 == gameObject.name)
        {
            correctItem3.SetActive(true);
        }
        else if (buttonsPressed == 3 && myPotionManager.playerStage == 3 && correctItem3Stage3 != gameObject.name)
        {
            wrongItem3.SetActive(true);
        }
    }
    

}
    /*
        void OnMouseUp()
        {
            if (gameObject.name == "EyeBall")
            {
                if (myPotionManager.playerStage == 1)
                {
                    myPotionManager.stage1Score = myPotionManager.stage1Score + 1;
                    myPotionManager.stage1Clicks += 1;
                    Debug.Log(myPotionManager.stage1Score);
                }
                else if (myPotionManager.playerStage == 2)
                {
                    myPotionManager.stage2Score = myPotionManager.stage2Score + 1;
                    myPotionManager.stage2Clicks += 1;
                    Debug.Log(myPotionManager.stage2Score);
                }
                else if (myPotionManager.playerStage == 3)
                {
                    myPotionManager.stage3Score = myPotionManager.stage3Score + 1;
                    myPotionManager.stage3Clicks += 1;
                    Debug.Log(myPotionManager.stage3Score);
                }

            }
            else if (gameObject.name == "Frog")
            {
                if (myPotionManager.playerStage == 1)
                {
                    myPotionManager.stage1Score = myPotionManager.stage1Score + 2;
                    myPotionManager.stage1Clicks += 1;
                    Debug.Log(myPotionManager.stage1Score);
                }
                else if (myPotionManager.playerStage == 2)
                {
                    myPotionManager.stage2Score = myPotionManager.stage2Score + 2;
                    myPotionManager.stage2Clicks += 1;
                    Debug.Log(myPotionManager.stage2Score);
                }
                else if (myPotionManager.playerStage == 3)
                {
                    myPotionManager.stage3Score = myPotionManager.stage3Score + 2;
                    myPotionManager.stage3Clicks += 1;
                    Debug.Log(myPotionManager.stage3Score);
                }
            }
            else if (gameObject.name == "DeadFlower")
            {
                if (myPotionManager.playerStage == 1)
                {
                    myPotionManager.stage1Score = myPotionManager.stage1Score + 4;
                    myPotionManager.stage1Clicks += 1;
                    Debug.Log(myPotionManager.stage1Score);
                }
                else if (myPotionManager.playerStage == 2)
                {
                    myPotionManager.stage2Score = myPotionManager.stage2Score + 4;
                    myPotionManager.stage2Clicks += 1;
                    Debug.Log(myPotionManager.stage2Score);
                }
                else if (myPotionManager.playerStage == 3)
                {
                    myPotionManager.stage3Score = myPotionManager.stage3Score + 4;
                    myPotionManager.stage3Clicks += 1;
                    Debug.Log(myPotionManager.stage3Score);
                }
            }
            else if (gameObject.name == "ToadStool")
            {
                if (myPotionManager.playerStage == 1)
                {
                    myPotionManager.stage1Score = myPotionManager.stage1Score + 8;
                    myPotionManager.stage1Clicks += 1;
                    Debug.Log(myPotionManager.stage1Score);
                }
                else if (myPotionManager.playerStage == 2)
                {
                    myPotionManager.stage2Score = myPotionManager.stage2Score + 8;
                    myPotionManager.stage2Clicks += 1;
                    Debug.Log(myPotionManager.stage2Score);
                }
                else if (myPotionManager.playerStage == 3)
                {
                    myPotionManager.stage3Score = myPotionManager.stage3Score + 8;
                    myPotionManager.stage3Clicks += 1;
                    Debug.Log(myPotionManager.stage3Score);
                }
            }
            else if (gameObject.name == "Feather")
            {
                if (myPotionManager.playerStage == 1)
                {
                    myPotionManager.stage1Score = myPotionManager.stage1Score + 16;
                    myPotionManager.stage1Clicks += 1;
                    Debug.Log(myPotionManager.stage1Score);
                }
                else if (myPotionManager.playerStage == 2)
                {
                    myPotionManager.stage2Score = myPotionManager.stage2Score + 16;
                    myPotionManager.stage2Clicks += 1;
                    Debug.Log(myPotionManager.stage2Score);
                }
                else if (myPotionManager.playerStage == 3)
                {
                    myPotionManager.stage3Score = myPotionManager.stage3Score + 16;
                    myPotionManager.stage3Clicks += 1;
                    Debug.Log(myPotionManager.stage3Score);
                }
            }

            if (myPotionManager.stage1Clicks > 2)
            {
                myPotionManager.stage1Score = 0; 
            }


        */















