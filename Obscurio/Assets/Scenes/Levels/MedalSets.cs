using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MedalSets : MonoBehaviour {

    MedalManager myMedalManager;

    public GameObject[] lvl1Medals;
    public GameObject[] lvl2Medals;
    public GameObject[] BeanMedals;
    public GameObject[] WellMedals;
    public GameObject[] SquareMedals;
    public GameObject[] LightMedals;
    public GameObject[] CardMedals;
    public GameObject[] PotionMedals;

    // Use this for initialization
    void Start () {
        myMedalManager = FindObjectOfType<MedalManager>();
	}
	
	// Update is called once per frame
	void Update () {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Medal Scene")
        {
            if (myMedalManager.Beans == 1)
            {
                BeanMedals[0].SetActive(true);
            }
            else if (myMedalManager.Beans == 2)
            {
                BeanMedals[1].SetActive(true);
            }
            else if (myMedalManager.Beans == 3)
            {
                BeanMedals[2].SetActive(true);
            }

            if (myMedalManager.Well == 1)
            {
                WellMedals[0].SetActive(true);
            }
            else if (myMedalManager.Well == 2)
            {
                WellMedals[1].SetActive(true);
            }
            else if (myMedalManager.Well == 3)
            {
                WellMedals[2].SetActive(true);
            }

            if (myMedalManager.Squares == 1)
            {
                SquareMedals[0].SetActive(true);
            }
            else if (myMedalManager.Squares == 2)
            {
                SquareMedals[1].SetActive(true);
            }
            else if (myMedalManager.Squares == 3)
            {
                SquareMedals[2].SetActive(true);
            }

            if (myMedalManager.Lights == 1)
            {
                LightMedals[0].SetActive(true);
            }
            else if (myMedalManager.Lights == 2)
            {
                LightMedals[1].SetActive(true);
            }
            else if (myMedalManager.Lights == 3)
            {
                LightMedals[2].SetActive(true);
            }

            if (myMedalManager.Cards == 1)
            {
                CardMedals[0].SetActive(true);
            }
            else if (myMedalManager.Cards == 2)
            {
                CardMedals[1].SetActive(true);
            }
            else if (myMedalManager.Cards == 3)
            {
                CardMedals[2].SetActive(true);
            }

            if (myMedalManager.Potions == 1)
            {
                PotionMedals[0].SetActive(true);
            }
            else if (myMedalManager.Potions == 2)
            {
                PotionMedals[1].SetActive(true);
            }
            else if (myMedalManager.Potions == 3)
            {
                PotionMedals[2].SetActive(true);
            }

        }
    }
}
