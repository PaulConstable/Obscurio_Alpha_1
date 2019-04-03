using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public void SetLightBronze()
    {
        Lights = 1;
    }
    public void SetLightSilver()
    {
        Lights = 2;
    }
    public void SetLightGold()
    {
        Lights = 3;
    }
    public void SetCardBronze()
    {
        Cards = 1;
    }
    public void SetCardSilver()
    {
        Cards = 2;
    }
    public void SetCardGold()
    {
        Cards = 3;
    }

    public void SetPotionBronze()
    {
        Potions = 1;
    }
    public void SetPotionSilver()
    {
        Potions = 2;
    }
    public void SetPotionGold()
    {
        Potions = 3;
    }





}
