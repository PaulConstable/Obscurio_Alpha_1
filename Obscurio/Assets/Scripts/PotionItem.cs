using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionItem : MonoBehaviour {

    PotionManager myPotionManager;


	// Use this for initialization
	void Start () {
        myPotionManager = FindObjectOfType<PotionManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

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
    }
     


    






     void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);
    }

     void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
    }


   
}
