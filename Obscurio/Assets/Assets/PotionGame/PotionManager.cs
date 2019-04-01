using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PotionManager : MonoBehaviour
{

    [SerializeField]  private GameObject EyeBall, Frog, DeadFlower, ToadStool, Feather;
    //[SerializeField]  private GameObject EyeBallOutline, FrogOutline, DeadFlowerOutline, ToadStoolOutline, FeatherOutline;

  
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
        Debug.Log(stage1Score);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void eyeBallLevel1()
    {
        stage1Score = stage1Score + 1;
        Debug.Log(stage1Score);
    }
  


}
