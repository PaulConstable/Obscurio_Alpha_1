using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionItem : MonoBehaviour {

    PotionManager myPotionManager;

    [SerializeField] public string correctPotionStage1 = "";
    [SerializeField] public string correctPotionStage2 = "";
    [SerializeField] public string correctPotionStage3 = "";
    public static string playerPotion = "";
    public static int buttonsPressed = 0;

    

    // Use this for initialization
    void Start() {
        myPotionManager = FindObjectOfType<PotionManager>();
    }

    // Update is called once per frame
    void Update() {

        Debug.Log(playerPotion);

        if (buttonsPressed == 2 && myPotionManager.playerStage == 1)
        {
            if (playerPotion == correctPotionStage1)
            {
                Debug.Log("Correct");
                myPotionManager.turnOnUI1();
                myPotionManager.playerStage = 2;
                
            }
            else
            {
                Debug.Log("Wrong");
                buttonsPressed = 0;
                playerPotion = "";
                myPotionManager.turnOn();
            }
        } else if (buttonsPressed == 3 && myPotionManager.playerStage == 2)
        {
            if (playerPotion == correctPotionStage2)
            {
                Debug.Log("Correct");
                myPotionManager.turnOnUI2();
                myPotionManager.playerStage = 3;
                
            }
            else
            {
                Debug.Log("Wrong");
                buttonsPressed = 0;
                playerPotion = "";
                myPotionManager.turnOn();
            }
        } else if (buttonsPressed == 4 && myPotionManager.playerStage == 3)
        {
            if (playerPotion == correctPotionStage3)
            {
                myPotionManager.turnOnUI3();
                Debug.Log("Correct");
                myPotionManager.playerStage = 4;
              
            }
            else
            {
                Debug.Log("Wrong");
                buttonsPressed = 0;
                playerPotion = "";
                myPotionManager.turnOn();
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















