using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PotionManager : MonoBehaviour
{

    [SerializeField]  private GameObject EyeBall, Frog, DeadFlower, ToadStool, Feather, BloodVial;
    [SerializeField] private GameObject Stage1UI, Stage2UI, Stage3UI;


    public int stage1Total, stage2Total, stage3Total;
    public int stage1Score, stage2Score, stage3Score;
    public int stage1Clicks, stage2Clicks, stage3Clicks;

    public int playerStage;
    [SerializeField] private Text playerStageText;

    PotionItem myPotionItem;
    public GameObject[] medals;
    public bool gameComplete;
    public GameObject removeUI;


    // Use this for initialization
    void Start()
    {
       // EyeBallOutline.SetActive(false);
       // FrogOutline.SetActive(false);
       // DeadFlowerOutline.SetActive(false);
       // ToadStoolOutline.SetActive(false);
       // FeatherOutline.SetActive(false);


        playerStage = 1;

        myPotionItem = FindObjectOfType<PotionItem>();
    
    }

    // Update is called once per frame
    void Update()
    {
        if(gameComplete == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.UnloadSceneAsync("RecipeGame");
        }
    }

    public void turnOn()
    {
        EyeBall.SetActive(true);
        Frog.SetActive(true);
        DeadFlower.SetActive(true);
        ToadStool.SetActive(true);
        Feather.SetActive(true);
        BloodVial.SetActive(true);
    }

    public void turnOff()
    {
        EyeBall.SetActive(false);
        Frog.SetActive(false);
        DeadFlower.SetActive(false);
        ToadStool.SetActive(false);
        Feather.SetActive(false);
        BloodVial.SetActive(false);
    }


    public void turnOnUI1()
    {
        Stage1UI.SetActive(true);
        removeUI.SetActive(false);
    }

    public void turnOnUI2()
    {
        Stage2UI.SetActive(true);
        removeUI.SetActive(false);
    }
    public void turnOnUI3()
    {
        Stage3UI.SetActive(true);
        gameComplete = true;
        removeUI.SetActive(false);
        if (myPotionItem.TimesWrong <=10)
        {
            medals[0].SetActive(true);
        }
        if(myPotionItem.TimesWrong >10 && myPotionItem.TimesWrong <=20)
        {
            medals[1].SetActive(true);
        }
        if(myPotionItem.TimesWrong > 30)
        {
            medals[2].SetActive(true);
        }

    }

    public void resetGameStage1()
    {
        Stage1UI.SetActive(false);
        ResetObjects();
        
    }

    public void resetGameStage2()
    {
        Stage2UI.SetActive(false);
        ResetObjects();
        
        
    }

    public void resetGameStage3()
    {
        Stage3UI.SetActive(false);
        ResetObjects();
       
    }

    public void ResetObjects()
    {
        EyeBall.SetActive(true);
        Frog.SetActive(true);
        DeadFlower.SetActive(true);
        ToadStool.SetActive(true);
        Feather.SetActive(true);
        BloodVial.SetActive(true);
        removeUI.SetActive(true);
    }
}
