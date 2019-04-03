using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MedalManager : MonoBehaviour
{

    public int Level1;
    public int Level2;
    public int Beans;
    public int Well;
    public int Squares;
    public int Lights;
    public int Cards;
    public int Potions;
    public GameObject[] lvl1Medals;
    public GameObject[] lvl2Medals;
    public GameObject[] BeanMedals;
    public GameObject[] WellMedals;
    public GameObject[] SquareMedals;
    public GameObject[] LightMedals;
    public GameObject[] CardMedals;
    public GameObject[] PotionMedals;

    private void Awake()
    {
        int GameStatus = FindObjectsOfType<MedalManager>().Length;
        if(GameStatus > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


    public void Start()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Medal Scene")
        {
            if (Beans == 1)
            {
                BeanMedals[0].SetActive(true);
            }
            else if (Beans == 2)
            {
                BeanMedals[1].SetActive(true);
            }
            else if (Beans == 3)
            {
                BeanMedals[2].SetActive(true);
            }

            if (Well == 1)
            {
                WellMedals[0].SetActive(true);
            }
            else if (Well == 2)
            {
                WellMedals[1].SetActive(true);
            }
            else if (Well == 3)
            {
                WellMedals[2].SetActive(true);
            }

            if (Squares == 1)
            {
                SquareMedals[0].SetActive(true);
            }
            else if (Squares == 2)
            {
                SquareMedals[1].SetActive(true);
            }
            else if (Squares == 3)
            {
                SquareMedals[2].SetActive(true);
            }
        }
    }

    public void SetBeanBronze()
    {
        Beans = 1;
    }
    public void SetBeanSilver()
    {
        Beans = 2;
    }
    public void SetBeanGold()
    {
        Beans = 3;
    }
    public void SetWellBronze()
    {
        Well = 1;
    }
    public void SetWellSilver()
    {
        Well = 2;
    }
    public void SetWellGold()
    {
        Well = 3;
    }
    public void SetSquareBronze()
    {
        Squares = 1;
    }
    public void SetSquareSilver()
    {
        Squares = 2;
    }
    public void SetSquareGold()
    {
        Squares = 3;
    }





}
