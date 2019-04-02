using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PotionManager : MonoBehaviour
{

    [SerializeField]  private GameObject EyeBall, Frog, DeadFlower, ToadStool, Feather, BloodVial;
    [SerializeField] private GameObject Stage1UI, Stage2UI, Stage3UI;


    public int stage1Total, stage2Total, stage3Total;
    public int stage1Score, stage2Score, stage3Score;
    public int stage1Clicks, stage2Clicks, stage3Clicks;

    public int playerStage;
    [SerializeField] private Text playerStageText;

    // Use this for initialization
    void Start()
    {
       // EyeBallOutline.SetActive(false);
       // FrogOutline.SetActive(false);
       // DeadFlowerOutline.SetActive(false);
       // ToadStoolOutline.SetActive(false);
       // FeatherOutline.SetActive(false);


        playerStage = 1;
    
    }

    // Update is called once per frame
    void Update()
    {
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
    }

    public void turnOnUI2()
    {
        Stage2UI.SetActive(true);
    }
    public void turnOnUI3()
    {
        Stage3UI.SetActive(true);
    }

    public void resetGameStage1()
    {
        Stage1UI.SetActive(false);
        EyeBall.SetActive(true);
        Frog.SetActive(true);
        DeadFlower.SetActive(true);
        ToadStool.SetActive(true);
        Feather.SetActive(true);
        BloodVial.SetActive(true);
    }

    public void resetGameStage2()
    {
        Stage2UI.SetActive(false);
        EyeBall.SetActive(true);
        Frog.SetActive(true);
        DeadFlower.SetActive(true);
        ToadStool.SetActive(true);
        Feather.SetActive(true);
        BloodVial.SetActive(true);
    }

    public void resetGameStage3()
    {
        Stage3UI.SetActive(false);
        EyeBall.SetActive(true);
        Frog.SetActive(true);
        DeadFlower.SetActive(true);
        ToadStool.SetActive(true);
        Feather.SetActive(true);
        BloodVial.SetActive(true);
    }
}
